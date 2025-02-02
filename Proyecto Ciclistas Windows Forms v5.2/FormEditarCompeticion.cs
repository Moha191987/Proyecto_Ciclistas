using Oracle.ManagedDataAccess.Client;
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
    public partial class FormEditarCompeticion : Form
    {
        private int idCompeticion;

        public FormEditarCompeticion(int id, string poblacion, DateTime fecha)
        {
            InitializeComponent();           
            idCompeticion = id;

            // Llenar los campos con los datos actuales
            textPoblacion.Text = poblacion;
            dateTimePicker.Value = fecha; // Cargar la fecha actual de la competición en el DateTimePicker del Form

        }

        private void btnEditarCompeticion_Click(object sender, EventArgs e)
        {
            string nuevaPoblacion = textPoblacion.Text;
            // Obtener la nueva fecha seleccionada
            DateTime nuevaFecha = dateTimePicker.Value;

            // Llamar al método de la clase Competicion
            bool actualizado = Competicion.ModificarCompeticion(idCompeticion, nuevaPoblacion, nuevaFecha);

            if (actualizado)
            {
                MessageBox.Show("Competición actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Abrir el formulario principal
                var formCompeticiones = new FormCompeticiones();
                formCompeticiones.Show();//mostrar el menú principal
                this.Hide(); // Ocultar el menú actual
            }

            else
            {
                MessageBox.Show("Error al actualizar la competición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
