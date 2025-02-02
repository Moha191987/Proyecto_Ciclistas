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
    public partial class FormActualizarEstadoPago : Form
    {
        private List<Ciclista> ListaCiclistas; // Lista local de ciclistas       
        private int _idCompeticionSeleccionada;

        // Constructor que recibe la lista de ciclistas y la cadena de conexión
        public FormActualizarEstadoPago(List<Ciclista> listaCiclistas, int idCompeticionSeleccionada)
        {
            InitializeComponent();
            ListaCiclistas = listaCiclistas;
            _idCompeticionSeleccionada = idCompeticionSeleccionada;
        }
               
        private void btnCambiarAPagado_Click(object sender, EventArgs e)
        {
            // Obtener el DNI ingresado por el usuario
            string dni = textDNI.Text.Trim();

            // Validar que el campo DNI no esté vacío
            if (!validaciones.ValidarNoEsNull(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar el formato del DNI usando el método validaciones.ValidarDNI
            if (!validaciones.ValidarDNI(dni))
            {
                MessageBox.Show("El formato del DNI ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el ciclista existe en la lista local usando un bucle for
            Ciclista ciclista = null;
            for (int i = 0; i < ListaCiclistas.Count; i++)
            {
                if (ListaCiclistas[i].DNI == dni && ListaCiclistas[i].Id_Competicion== _idCompeticionSeleccionada)
                {
                    ciclista = ListaCiclistas[i];
                    if (ciclista.Pagado == true)//Encontrado
                    {
                        //En caso que ese ciclista ya esté pagado
                        MessageBox.Show("El ciclista ya ha pagado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        //Actualizo la lista local
                        ListaCiclistas[i].Pagado = true;
                        //Paso el ciclista al método de la clase
                        ciclista.ActualizarEstadoPago();
                        if(ciclista.Pagado == true)
                            MessageBox.Show($"El ciclista con DNI {dni} ha sido marcado como pagado.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }

            //En caso que sea null --> no existe
            if (ciclista == null)
            {
                MessageBox.Show("El ciclista con el DNI ingresado no está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cerrar el formulario actual para volver al menú principal
            // Abrir el formulario principal
            var formMenu = new FormMenu();
            formMenu.Show();//mostrar el menú principal
            this.Hide(); // Ocultar el menú actual
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
