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
    public partial class FormNuevaCompeticion : Form
    {
        public FormNuevaCompeticion()
        {
            InitializeComponent();
        }

        private void buttonNuevaCompeticion_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaramos un nuevo objeto de la Clase Competicion
                var competicion = new Competicion
                {
                    Poblacion = textPoblacion.Text,
                    Fecha = monthCalendarCompeticion.SelectionStart,
                    Borrado = false
                };

                //Validar que Población no sea Null
                if (!validaciones.ValidarNoEsNull(competicion.Poblacion) || !validaciones.ValidarFechaNoEsNull(competicion.Fecha))
                {
                    MessageBox.Show("La población y la fecha son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Obtenemos el máximo de competiciones en la BBDD
                int cantidadCompeticiones = Competicion.ObtenerMaxCompeticiones();
                //Asignamos ID a la nueva competición
                competicion.Id = cantidadCompeticiones + 1;

                // Intentar agregar la competicion a la base de datos
                //No requiere pasarle la Lista de Competiciones
                // También lo agregamos a la Lista de Competiciones
                // AgregarCompeticion devuelve Boolean
                if (Competicion.AgregarCompeticion(competicion))
                {
                    MessageBox.Show("Competición guardada correctamente en la BBDD " +
                        "con ID: " + competicion.Id, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    // Si ocurre un error al agregar a la base de datos
                    MessageBox.Show("Error al guardar la competición en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la competición: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Limpiamos campos
            textPoblacion.Clear();
            //Reseteamos calendario
            monthCalendarCompeticion.SetDate(DateTime.Today);

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            // Abrir el formulario principal
            var formCompeticiones = new FormCompeticiones();
            formCompeticiones.Show();//mostrar el menú principal
            this.Hide(); // Ocultar el menú actual
        }
    }
}
