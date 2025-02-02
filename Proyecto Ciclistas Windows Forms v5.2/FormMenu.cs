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
    public partial class FormMenu : Form
    {
        private List<Ciclista> listaCiclistas; // Declaración de la Lista
        
        //Form Menu recibe el ID de la competición
        private int idCompeticionSeleccionada;

        //Usaremos esta variable como flag para marcar que la Lista ya se ha cargado al arrancar el programa
        //Así no se carga cada vez que volvemos al Menú
        private bool ciclistasCargados = false;

        public FormMenu(int idCompeticion)
        {
            InitializeComponent();            
            idCompeticionSeleccionada = idCompeticion;
            listaCiclistas = new List<Ciclista>(); // Inicialización de la Lista de ciclistas
        }

        // Constructor sin parámetros para poder volver desde un form secundario
        public FormMenu()
        {
            InitializeComponent();
            // Aquí puedes inicializar valores por defecto o dejarlo vacío
        }

        //Se le pasa por referencia una lista de ciclistas vacía
        private void CargarCiclistasAlArrancar(ref List<Ciclista> _ciclistas, ref int _idCompeticion)
        {
            // Cargar la lista de ciclistas
            //Método CargarCiclistas devuelve una lista de ciclistas
            _ciclistas = Ciclista.CargarCiclistas(_idCompeticion);

            // Mostrar los ciclistas en el DataGridView
            //dgvCiclistas.DataSource = ciclistas;
        }

        //CUANDO SE CARGA EL FORMULARIO
        private void FormMenu_Load(object sender, EventArgs e)
        {
            // Llamar al método para cargar la lista de ciclistas al abrir el programa
            //Se le pasa por referencia la Lista de Ciclistas
            if (!ciclistasCargados)
            {
                CargarCiclistasAlArrancar(ref listaCiclistas, ref idCompeticionSeleccionada);
                ciclistasCargados = true;
            }
        }



        ////CUANDO HACEMOS CLICK EN REGISTRAR NUEVO CICLISTA
        private void btnRegistrarCiclista_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de registro
            //Le pasamos la lista de ciclistas como parámetro
            var formRegistrar = new FormAgregarCiclista(listaCiclistas, idCompeticionSeleccionada);
            formRegistrar.Show();
            
            this.Hide(); // Ocultar el menú principal


        }

        //CUANDO HACEMOS CLICK EN LISTAR PARTICIPANTES
        private void btnListarParticipantes_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de lista de participantes
            //Le pasamos la lista de ciclistas como parámetro
            var formListar = new FormListarCiclistas(listaCiclistas, idCompeticionSeleccionada);
            formListar.Show();

            this.Hide(); // Ocultar el menú principal
        }

        //CUANDO HACEMOS CLICK EN SALIR
        private void Salir_Click(object sender, EventArgs e)
        {
            // Cierra toda la aplicación
            var formCompeticiones = new FormCompeticiones();
            formCompeticiones.Show();  // Mostrar el menú principal
            this.Hide();  // Ocultar el formulario actual            
        }

        private void btnEliminarCiclista_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de eliminar participante
            //Le pasamos la lista de ciclistas como parámetro
            var formEliminar = new FormEliminarCiclista(listaCiclistas);
            formEliminar.Show();

            this.Hide(); // Ocultar el menú principal
        }

        private void buttonListarCiclistasBorrados_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de lista de participantes
            //Le pasamos la lista de ciclistas como parámetro
            var formListarBorrados = new FormListarCiclistasBorrados(listaCiclistas);
            formListarBorrados.Show();

            this.Hide(); // Ocultar el menú principal
        }

        private void buttonRegistrarVariosCiclistas_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario para cargar múltiples ciclistas
            FormRegistrarVariosCiclistas form = new FormRegistrarVariosCiclistas(listaCiclistas,idCompeticionSeleccionada);
            form.ShowDialog(); // Mostrar el formulario como un cuadro de diálogo modal
        }

        private void buttonCambiarEstadoPago_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de eliminar participante
            //Le pasamos la lista de ciclistas como parámetro
            var formEstadoPago = new FormActualizarEstadoPago(listaCiclistas, idCompeticionSeleccionada);
            formEstadoPago.Show();

            this.Hide(); // Ocultar el menú principal
        }

        private void btnCambiarEstadoPago_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de eliminar participante
            //Le pasamos la lista de ciclistas como parámetro
            var formEstadoPago = new FormListarPendientesPago(listaCiclistas, idCompeticionSeleccionada);
            formEstadoPago.Show();

            this.Hide(); // Ocultar el menú principal

        }
    }
}
