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
    public partial class FormListarCiclistas : Form
    {
        private List<Ciclista> _listaCiclistas;
        private int _idCompeticionSeleccionada;

        //Inicialización del constructor
        //Le pasamos por referencia listaCiclistas al constructor del formulario
        public FormListarCiclistas(List<Ciclista> listaCiclistas, int idCompeticionSeleccionada)
        {
            InitializeComponent();
            _listaCiclistas = listaCiclistas; // Asignar la referencia de la lista
            _idCompeticionSeleccionada = idCompeticionSeleccionada;


        }

        private void FormListarCiclistas_Load(object sender, EventArgs e)
        {
            // Verificar si la lista está vacía antes de mostrarla
            if (_listaCiclistas == null || _listaCiclistas.Count == 0)
            {
                MessageBox.Show("No hay ciclistas para mostrar.");
                return; // Salir si la lista está vacía
            }

            // Crear una lista auxiliar para almacenar los ciclistas no borrados
            List<Ciclista> ciclistasNoBorrados = new List<Ciclista>();

            // Recorrer todos los ciclistas en la lista original que tiene todos los ciclistas
            foreach (Ciclista ciclista in _listaCiclistas)
            {
                // Si el ciclista no está marcado como borrado, lo agregamos a la nueva lista
                if (!ciclista.BORRADO && ciclista.Id_Competicion == _idCompeticionSeleccionada)
                {
                    ciclistasNoBorrados.Add(ciclista);
                }
            }

            // Verificar si existen ciclistas no borrados
            if (ciclistasNoBorrados.Count == 0)
            {
                MessageBox.Show("Ningún participante apuntado en la competición.");
                return; // Salir si no hay ciclistas no borrados
            }

            // Mostrar los ciclistas en el DataGridView
            dgvCiclistas.DataSource = null; // Reinicia la fuente de datos para asegurarte
            dgvCiclistas.DataSource = ciclistasNoBorrados;//Se define fuente de datos del Data Grid View

        }



        private void buttonVolver_Click(object sender, EventArgs e)
        {
            var formMenu = new FormMenu(_idCompeticionSeleccionada);
            formMenu.Show();  // Mostrar el menú principal
            this.Hide();  // Ocultar el formulario actual
        }
      
        
    }
}
