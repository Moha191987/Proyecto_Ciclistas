using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormEliminarCiclista : Form
    {
        private List<Ciclista> _listaCiclistas;//Variable lista local

        public FormEliminarCiclista(List<Ciclista> listaCiclistas)
        {
            InitializeComponent();
            _listaCiclistas = listaCiclistas; //Asignar la referencia de la lista
        }

        private void btnEliminarCiclista_Click(object sender, EventArgs e)
        {
            // Obtener el DNI del campo de texto
            string DNI = textDNI.Text.Trim();

            // Validar el formato del DNI
            if (!validaciones.ValidarDNI(DNI))
            {
                MessageBox.Show("El formato del DNI no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Confirmar la eliminación
            var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar al ciclista con DNI {DNI}?",
                                        "Confirmar eliminación",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                // Intentar eliminar al ciclista
                Ciclista.EliminarCiclista(DNI);
                //MessageBox.Show("Solicitud de eliminación procesada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Ahora tenemos que marcar el ciclista a eliminar como BORRADO
            foreach (Ciclista ciclista in _listaCiclistas)
            {
                // Si encontramos el ciclista con el DNI que buscamos
                if (ciclista.DNI == DNI)
                {
                    // Marcamos el estado BORRADO como true. No eliminamos nada.
                    ciclista.BORRADO = true;
                    break;// Terminamos el bucle si ya encontramos el ciclista
                }
            }

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
