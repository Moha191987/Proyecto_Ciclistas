using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Competicion
    {
        public int Id { get; set; }  // Identificación única de la competición
        public string Poblacion { get; set; }  // Población de la competición
        public DateTime Fecha { get; set; } //Fecha de la competición
        public bool Borrado { get; set; } = false; //Estado de la competición en la BBDD

        //Método cargar competiciones
        public static List<Competicion> CargarCompeticiones()
        {
            //Declaramos objeto lista de clase competicion
            List <Competicion> ListaCompeticiones = new List<Competicion>();

            using(OracleConnection connection = new OracleConnection(Parametros.ConnectionString))
            {
                connection.Open();
                string query = "SELECT ID_COMPETICION, FECHA, POBLACION FROM COMPETICIONES WHERE BORRADO=FALSE";
                using(OracleCommand command = new OracleCommand(query,connection))
                using(OracleDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        ListaCompeticiones.Add(new Competicion{Id = reader.GetInt32(0),Fecha = reader.GetDateTime(1),Poblacion = reader.GetString(2),Borrado = false});
                        
                    }
                }
            }

            return ListaCompeticiones;
        }

        //Método agregar nueva competicion
        public static Boolean AgregarCompeticion(Competicion nuevaCompeticion)
        {
            //Definimos una variable de tipo OracleConnection
            OracleConnection connection = new OracleConnection(Parametros.ConnectionString);

            //Abrimos la conexión
            connection.Open();

            OracleCommand command = new OracleCommand(
                "INSERT INTO COMPETICIONES (ID_COMPETICION,POBLACION,FECHA,BORRADO) VALUES (:id,:poblacion, :fecha, :borrado)", connection);

            command.Parameters.Add(new OracleParameter("id", nuevaCompeticion.Id));
            command.Parameters.Add(new OracleParameter("poblacion", nuevaCompeticion.Poblacion));
            command.Parameters.Add(new OracleParameter("fecha", nuevaCompeticion.Fecha));
            command.Parameters.Add(new OracleParameter("borrado", nuevaCompeticion.Borrado));
            

            //Ejecutamos la query y controlamos el resultado devuelto
            int filasAfectadas = command.ExecuteNonQuery();

            if (filasAfectadas > 0)
                
                return true;

            else
            {                
                return false;
            }

            command.Dispose();//Liberamos comando
            connection.Close();//Cerramos la conexión
        }

        //Método eliminar una competicion
        public static bool EliminarCompeticion(int idCompeticion)
        {
            using (OracleConnection connection = new OracleConnection(Parametros.ConnectionString))
            {
                connection.Open();

                // Iniciar una transacción para asegurarnos de que ambas actualizaciones se hagan correctamente
                using (OracleTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // PRIMERO Marcar como BORRADO los ciclistas de la competición
                        string queryCiclistas = "UPDATE CICLISTAS SET BORRADO = 1 WHERE ID_COMPETICION = :idCompeticion";
                        using (OracleCommand commandCiclistas = new OracleCommand(queryCiclistas, connection))
                        {
                            commandCiclistas.Parameters.Add(new OracleParameter("idCompeticion", idCompeticion));
                            commandCiclistas.ExecuteNonQuery();
                        }

                        // SEGUNDO Marcar como BORRADO la competición
                        string queryCompeticion = "UPDATE COMPETICIONES SET BORRADO = 1 WHERE ID_COMPETICION = :idCompeticion";
                        using (OracleCommand commandCompeticion = new OracleCommand(queryCompeticion, connection))
                        {
                            commandCompeticion.Parameters.Add(new OracleParameter("idCompeticion", idCompeticion));
                            int filasAfectadas = commandCompeticion.ExecuteNonQuery();

                            // Si al menos una fila fue afectada, confirmar la transacción
                            if (filasAfectadas > 0)
                            {
                                transaction.Commit();
                                return true;
                            }
                        }

                        // Si no se actualizó la competición, hacer rollback
                        transaction.Rollback();
                        return false;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        //Método modificar competición
        public static bool ModificarCompeticion(int idCompeticion, string nuevaPoblacion, DateTime nuevaFecha)
        {
            using (OracleConnection connection = new OracleConnection(Parametros.ConnectionString))
            {
                connection.Open();
                string query = "UPDATE COMPETICIONES SET POBLACION = :poblacion, FECHA = :fecha WHERE ID_COMPETICION = :idCompeticion";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("poblacion", nuevaPoblacion));
                    command.Parameters.Add(new OracleParameter("fecha", nuevaFecha));
                    command.Parameters.Add(new OracleParameter("idCompeticion", idCompeticion));

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0; // Devuelve true si se actualizó correctamente
                }
            }
        }

        //Método para comprobar cuál es el dorsal máximo asignado
        public static int ObtenerMaxCompeticiones()
        {
            //Definimos una variable de tipo OracleConnection
            OracleConnection connection = new OracleConnection(Parametros.ConnectionString);
            connection.Open();//Abrimos la conexión con BBDD

            //Ejecutamos una consulta a la BBDD para obtener el máximo dorsal
            OracleCommand command = new OracleCommand("SELECT MAX(ID_COMPETICION) FROM COMPETICIONES WHERE ID_COMPETICION IS NOT NULL", connection);

            /*El tipo object es la clase base de todas las clases en C#. 
            En otras palabras, cualquier tipo de datos (como int, string, DateTime, etc.) 
            puede ser almacenado en una variable de tipo object, 
            ya que todos los tipos en C# derivan de object.*/
            object resultado = command.ExecuteScalar();
            /*El tipo object es la clase base de todas las clases en C#. En otras palabras, cualquier tipo de datos (como int, string, DateTime, etc.) puede ser almacenado en una variable de tipo object, ya que todos los tipos en C# derivan de object. */

            int max = Convert.ToInt32(resultado);

            return max;
        }
    }
}
