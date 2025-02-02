using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class FormCompeticiones : Form
    {                
        public FormCompeticiones()
        {
            InitializeComponent();
            CargarCompeticionesAlArrancar();
            
        }

        private void CargarCompeticionesAlArrancar()
        {
            cbCompeticiones.Items.Clear(); // Limpiar el ComboBox antes de llenarlo

            List<Competicion> competiciones = Competicion.CargarCompeticiones();

            if (competiciones.Count == 0)
            {
                MessageBox.Show("No hay competiciones disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var competicion in competiciones)
            {
                cbCompeticiones.Items.Add(new CompeticionComboItem
                {
                    ID_Competicion = competicion.Id,
                    Poblacion = competicion.Poblacion,
                    Fecha = competicion.Fecha
                });
            }


        }
        private void FormCompeticiones_Load(object sender, EventArgs e)
        {
            //Este es el evento donde cargaremos las competiciones
        }

        private void btnNuevaCompeticion_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de registro
            var nuevaCompeticion = new FormNuevaCompeticion();
            nuevaCompeticion.Show();

            this.Hide(); // Ocultar el menú principal
        }

        private void btnModificarCompeticion_Click(object sender, EventArgs e)
        {
            if (cbCompeticiones.SelectedItem is CompeticionComboItem competicionSeleccionada)
            {
                //Pasamos al formulario los datos obtenido desde el combo
                int idCompeticion = competicionSeleccionada.ID_Competicion;
                string poblacion = competicionSeleccionada.Poblacion;
                DateTime fecha = competicionSeleccionada.Fecha;

                // Abrir el formulario de registro            
                var formEditar = new FormEditarCompeticion(idCompeticion, poblacion,fecha);
                formEditar.Show();
                this.Hide(); // Ocultar el menú principal
            }
            else
            {
                MessageBox.Show("Seleccione una competición antes de editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarCompeticion_Click(object sender, EventArgs e)
        {
            if (cbCompeticiones.SelectedItem is CompeticionComboItem competicionSeleccionada)
            {
                int idCompeticion = competicionSeleccionada.ID_Competicion;

                //Confirmar antes de eliminar
                DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta competición? Se marcarán como borrados todos los ciclistas asociados.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // Llamar al método para eliminar la competición
                    bool eliminado = Competicion.EliminarCompeticion(idCompeticion);

                    if (eliminado)
                    {
                        MessageBox.Show("Competición eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCompeticionesAlArrancar(); // Refrescar la lista de competiciones
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la competición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una competición antes de eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    


        private void buttonBuscarCompeticion_Click(object sender, EventArgs e)
        {
            //Guardar la información de la competición seleccionada
            if (cbCompeticiones.SelectedItem is CompeticionComboItem competicionSeleccionada)
            {
                int idCompeticion = competicionSeleccionada.ID_Competicion;

                // Abrir FormMenu pasando el ID de la competición seleccionada
                FormMenu formMenu = new FormMenu(idCompeticion);
                formMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seleccione una competición antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //Pasar la información al formulario principal de ciclistas
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    //Clase para gestionar el combo
    public class CompeticionComboItem
    {
        public int ID_Competicion { get; set; }
        public string Poblacion { get; set; }
        public DateTime Fecha { get; set; }

        // Mostrar Población y Fecha en el ComboBox
        public override string ToString()
        {
            return $"{Poblacion} - {Fecha.ToShortDateString()}"; // Ejemplo: "Barcelona - 31/01/2025"
        }

        /*public CompeticionComboItem(int id, string poblacion, DateTime fecha)
        {
            ID_Competicion = id;
            Poblacion = poblacion;
            Fecha = fecha; 
        }*/
    }
}
