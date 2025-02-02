using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormRegistrarVariosCiclistas : Form
    {
        private List<Ciclista> ListaCiclistas; // Lista local de ciclistas
        private int idCompeticionSeleccionada;

        // Constructor que recibe la lista de ciclistas y la cadena de conexión
        public FormRegistrarVariosCiclistas(List<Ciclista> listaCiclistas, int IdCompeticion)
        {
            InitializeComponent();
            ListaCiclistas = listaCiclistas;
            idCompeticionSeleccionada = IdCompeticion;
           

        }

        private void buttonAgregarVariosCiclistas_Click(object sender, EventArgs e)
        {
            // Obtener el máximo dorsal utilizando el método ObtenerMaxDorsal
            int maxDorsal = Ciclista.ObtenerMaxDorsal(idCompeticionSeleccionada);

            // Iterar sobre las filas del DataGridView
            foreach (DataGridViewRow row in dgvVariosCiclistas.Rows)
            {
                // Comprobamos si la fila es la última fila vacía
                if (row.IsNewRow)
                    continue; // Saltamos la última fila vacía

                // Verificar que la fila no esté vacía
                if (row.Cells["DNI"].Value != null && 
                    row.Cells["Nombre"].Value != null &&
                    row.Cells["ModeloBicicleta"].Value != null)
                {
                    // Si "Pagado" es null, asignar "False" por defecto
                    if (row.Cells["Pagado"].Value == null)
                    {
                        row.Cells["Pagado"].Value = "False"; // Establecer el valor por defecto
                    }

                    // Crear una instancia de Ciclista con los datos de la fila
                    Ciclista ciclista = new Ciclista
                    {
                        DNI = row.Cells["DNI"].Value.ToString(),
                        Nombre = row.Cells["Nombre"].Value.ToString(),
                        ModeloBicicleta = row.Cells["ModeloBicicleta"].Value.ToString(),
                        Pagado = bool.Parse(row.Cells["Pagado"].Value.ToString()),//Convertimos string en Boolean
                        Dorsal = ++maxDorsal, // Incrementar el máximo dorsal
                        Id_Competicion = idCompeticionSeleccionada

                    };

                    //Pasamos validaciones de los datos
                    //Validar formato de DNI o NIE
                    if (!validaciones.ValidarDNI(ciclista.DNI))
                    {
                        MessageBox.Show("El DNI/NIE ingresado no tiene el formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validar integridad de Nombre
                    if (!validaciones.ValidarNombre(ciclista.Nombre))
                    {
                        MessageBox.Show("El formato de 'nombre' no es correcto o es más largo de 40 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validar integridad de Modelo Bicicleta
                    if (!validaciones.ValidarModeloBicicleta(ciclista.ModeloBicicleta))
                    {
                        MessageBox.Show("El formato de 'modelo de bicicleta' no es correcto o es más largo de 40 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Verificar si el ciclista ya está registrado en la ListaCiclistas
                    if (Ciclista.CheckCiclista(ListaCiclistas, ciclista.DNI))
                    {
                        MessageBox.Show("Ciclista ya registrado con este DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Llamar al método AgregarCiclista
                    Ciclista.AgregarCiclista(ciclista);
                    
                    // Agregar el ciclista a la lista local
                    ListaCiclistas.Add(ciclista);
                }

                else if (row.Cells["DNI"].Value == null)
                {
                    MessageBox.Show("El DNI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (row.Cells["Nombre"].Value == null)
                {
                    MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (row.Cells["ModeloBicicleta"].Value == null)
                {
                    MessageBox.Show("El modelo de bicicleta no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }  
            }

            // Mensaje de éxito
            MessageBox.Show("Ciclistas agregados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerrar el formulario actual para volver al menú principal
            this.Close();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {            
                // Abrir el formulario principal
                var formMenu = new FormMenu();
                formMenu.Show();//mostrar el menú principal
                this.Hide(); // Ocultar el menú actual            
        }
    }
}
