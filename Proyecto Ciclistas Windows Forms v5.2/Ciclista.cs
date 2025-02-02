using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Ciclista
    {
        public string Nombre { get; set; }  // Nombre del ciclista
        public string DNI { get; set; }  // Identificación única
        public string ModeloBicicleta { get; set; }  // Modelo de bicicleta
        public int Dorsal { get; set; }  // Número de dorsal
        public bool Pagado { get; set; } = false;  // Estado de pago
        public bool BORRADO { get; set; } = false; //Estado del usuario
        public int Id_Competicion { get; set; }//ID de la competición a la que pertenece el ciclista


        // Método para cargar todos los ciclistas desde la base de datos
        //Recibe por valor los datos de conexión
        //Devuelve mediante return una Lista de la clase Ciclista
        public static List<Ciclista> CargarCiclistas(int idCompeticion)
        {
            int contador = 0;
            //Declaramos una lista de objetios de clase ciclista
            List<Ciclista> ciclistas = new List<Ciclista>();

            // Crear la conexión a la base de datos
            OracleConnection connection = new OracleConnection(Parametros.ConnectionString);

            // Abrir la conexión
            connection.Open();

            // Consulta para obtener todos los ciclistas
            OracleCommand command = new OracleCommand(
                "SELECT DNI, Nombre, ModeloBicicleta, Dorsal, Pagado, BORRADO, ID_COMPETICION FROM CICLISTAS WHERE ID_COMPETICION= :idCompeticion", connection);
            
            //Rellenamos parámetro del command
            command.Parameters.Add(new OracleParameter("idCompeticion", idCompeticion));
            
            //Declaramos un Reader
            OracleDataReader reader = command.ExecuteReader();//Ejecutamos la consulta y obtenemos resultados

            //Bucle para leer todos los registros
            while (reader.Read())
            {
                ciclistas.Add(new Ciclista //Añadimos un nuevo elemento a la lista
                {
                    DNI = reader.GetString(0),
                    Nombre = reader.GetString(1),
                    ModeloBicicleta = reader.GetString(2),
                    Dorsal = reader.GetInt32(3),
                    Pagado = reader.GetBoolean(4),
                    BORRADO=reader.GetBoolean(5),
                    Id_Competicion=reader.GetInt32(6)
                });

                contador++;//Incrementamos contador de ciclistas
            }

            reader.Close();//Cerramos el lector de datos
            command.Dispose();//Liberar el comando
            connection.Close();//Cerramos la conexión con la BBDD

            return ciclistas; // Retornar la lista de ciclistas
        }

        //Método para comprobar si ciclista ya está registrado
        public static bool CheckCiclista(List<Ciclista> listaCiclistas, string dni)
        {
            // Buscar si el DNI ya existe en la lista
            foreach (var ciclista in listaCiclistas)
            {
                if (ciclista.DNI == dni)
                {
                    return true; // Si lo encuentra, devuelve true
                }
            }

            return false; // Si no lo encuentra, devuelve false
        }

        // Método para agregar un nuevo ciclista a la base de datos
        //Recibe como parámetros un nuevoCiclista y las credenciales
        public static Boolean AgregarCiclista(Ciclista nuevoCiclista)
        {
            //Definimos una variable de tipo OracleConnection
            OracleConnection connection = new OracleConnection(Parametros.ConnectionString);

            //Abrimos la conexión
            connection.Open();

            OracleCommand command = new OracleCommand(
                "INSERT INTO CICLISTAS (DNI,NOMBRE,MODELOBICICLETA,DORSAL,PAGADO, ID_COMPETICION) VALUES (:dni,:nombre, :modeloBicicleta, :dorsal,:pagado, :idCompeticion)", connection);

            command.Parameters.Add(new OracleParameter("dni", nuevoCiclista.DNI));
            command.Parameters.Add(new OracleParameter("nombre", nuevoCiclista.Nombre));
            command.Parameters.Add(new OracleParameter("modeloBicicleta", nuevoCiclista.ModeloBicicleta));
            command.Parameters.Add(new OracleParameter("dorsal", nuevoCiclista.Dorsal));
            command.Parameters.Add(new OracleParameter("pagado", nuevoCiclista.Pagado));
            command.Parameters.Add(new OracleParameter("idCompeticion", nuevoCiclista.Id_Competicion));

            //Ejecutamos la query y controlamos el resultado devuelto
            int filasAfectadas = command.ExecuteNonQuery();

            if (filasAfectadas > 0)

                return true;

            else {
            
                return false; 
            }

            command.Dispose();//Liberamos comando
            connection.Close();//Cerramos la conexión

        }

        //Método para comprobar cuál es el dorsal máximo asignado
        public static int ObtenerMaxDorsal(int idCompeticion)
        {
            int maxDorsal = 0;

            //Definimos una variable de tipo OracleConnection
            OracleConnection connection = new OracleConnection(Parametros.ConnectionString);
            connection.Open();//Abrimos la conexión con BBDD

            //Ejecutamos una consulta a la BBDD para obtener el máximo dorsal
            OracleCommand maxDorsalCommand = new OracleCommand("SELECT MAX(DORSAL) FROM CICLISTAS WHERE ID_COMPETICION = :idCompeticion AND DNI IS NOT NULL", connection);

            maxDorsalCommand.Parameters.Add(new OracleParameter("idCompeticion", idCompeticion));

            /*El tipo object es la clase base de todas las clases en C#. 
            En otras palabras, cualquier tipo de datos (como int, string, DateTime, etc.) 
            puede ser almacenado en una variable de tipo object, 
            ya que todos los tipos en C# derivan de object.*/
            object resultado = maxDorsalCommand.ExecuteScalar();/*El tipo object es la clase base de todas las clases en C#. En otras palabras, cualquier tipo de datos (como int, string, DateTime, etc.) puede ser almacenado en una variable de tipo object, ya que todos los tipos en C# derivan de object. */

            // Si el resultado es null o DBNull, se deja maxDorsal como 0; en otro caso, se convierte el resultado.
            if (resultado != null && resultado != DBNull.Value)
                maxDorsal = Convert.ToInt32(resultado);

            maxDorsalCommand.Dispose();//Liberamos comando
            connection.Close();//Cerramos la conexión
            
            return maxDorsal;
        }

        //Método para ELIMINAR ciclista
        public static void EliminarCiclista(string DNI)
        {
            //Definimos una variable de tipo OracleConnection
            OracleConnection connection = new OracleConnection(Parametros.ConnectionString);
            connection.Open();//Abrimos la conexión con BBDD
                        
            if (string.IsNullOrWhiteSpace(DNI) || DNI.Length != 9)
            {
                MessageBox.Show("El DNI no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OracleCommand command = new OracleCommand(
                "UPDATE CICLISTAS SET BORRADO = TRUE WHERE DNI = :dni", connection);
            
            //Asignamos a los parámetros del comando la correspondencia con la propiedad de la clase
            command.Parameters.Add(new OracleParameter("dni", DNI));

            //Guardamos en un entero lo que devuelve la ejecución del comandando
            int filasAfectadas = command.ExecuteNonQuery();

            if (filasAfectadas == 1)//Si todo ha ido bien la consulta devuelve 1 file
                MessageBox.Show("Ciclista eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else//Si algo va mal devuelve 0
                MessageBox.Show("No se encontró un ciclista con el DNI proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            command.Dispose();//Liberamos comando
            connection.Close();//Cerramos la conexión

        }
        public void ActualizarEstadoPago()
        {
            //Definimos una variable de tipo OracleConnection
            OracleConnection connection = new OracleConnection(Parametros.ConnectionString);
            connection.Open();//Abrimos la conexión con BBDD

            OracleCommand command = new OracleCommand(
                "UPDATE CICLISTAS SET PAGADO = :pagado WHERE DNI = :dni AND ID_COMPETICION= :idCompeticion", connection);
            //Asignamos a los parámetros del comando la correspondencia con la propiedad de la clase
            command.Parameters.Add(new OracleParameter("pagado", Pagado));
            command.Parameters.Add(new OracleParameter("dni", DNI));
            command.Parameters.Add(new OracleParameter("idCompeticion", Id_Competicion));


            //Guardamos en un entero lo que devuelve la ejecución del comandando
            int filasAfectadas = command.ExecuteNonQuery();

            if (filasAfectadas == 1)
            {
                // Actualizar el estado de pago en la lista local
                Pagado = !Pagado;

                //MessageBox.Show("El estado de pago del ciclista se ha actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //MessageBox.Show("No se encontró un ciclista con el DNI proporcionado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            command.Dispose();//Liberamos comando
            connection.Close();//Cerramos la conexión

        }
    }
}
