using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAgregarCiclista : Form
    {
        private List<Ciclista> _listaCiclistas;//Variable lista local

        private int idCompeticionSeleccionada;

        //Inicialización del constructor
        //Le pasamos por referencia listaCiclistas al constructor del formulario
        public FormAgregarCiclista(List<Ciclista> listaCiclistas, int idCompeticion)
        {
            InitializeComponent();
            _listaCiclistas = listaCiclistas; //Asignar la referencia de la lista
            idCompeticionSeleccionada = idCompeticion;//Asignamos la referencia a la competición seleccionada
        }

        //Función que se dispara al hacer click en botón REGISTRAR
        private void buttonRegistrarCiclista_Click(object sender, EventArgs e)
        {
            // Crear un nuevo ciclista con los valores introducidos en el formulario
            var ciclista = new Ciclista
            {
                Nombre = textNombre.Text,
                DNI = textDNI.Text,
                ModeloBicicleta = textModeloBicicleta.Text,
                //El dorsal se calcula más abajo
                Pagado = checkPagado.Checked, //Si está checked pasará "True"
                Id_Competicion = idCompeticionSeleccionada
            };

            // Validar que no sean NULL DNI, Nombre y bicicleta
            if (!validaciones.ValidarNoEsNull(ciclista.DNI) || !validaciones.ValidarNoEsNull(ciclista.Nombre) || !validaciones.ValidarNoEsNull(ciclista.ModeloBicicleta))
            {
                MessageBox.Show("El DNI, el Nombre y el Modelo de Bicicleta son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                        
            // Validar integridad de Nombre
            if (!validaciones.ValidarNombre(ciclista.Nombre))
            {
                MessageBox.Show("El formato de 'nombre' no es correcto o es más largo de 40 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            // Validar integridad de Modelo Bicicleta
            if (!validaciones.ValidarModeloBicicleta(ciclista.ModeloBicicleta))
            {
                MessageBox.Show("El formato de 'modelo de bicicleta' no es correcto o es más largo de 40 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //Validar formato de DNI o NIE
            if (!validaciones.ValidarDNI(ciclista.DNI))
            {
                MessageBox.Show("El DNI/NIE ingresado no tiene el formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Obtenemos el máximos dorsal asignado en la BBDD
            int dorsal = Ciclista.ObtenerMaxDorsal(idCompeticionSeleccionada);
            //Asugnamos nuevo dorsal
            ciclista.Dorsal = dorsal + 1;

            // Verificar si el ciclista ya está registrado en la ListaCiclistas
            if (Ciclista.CheckCiclista(_listaCiclistas, ciclista.DNI))
            {
                MessageBox.Show("Ciclista ya registrado con este DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentar agregar el ciclista a la base de datos
            //No requiere pasarle la Lista de Ciclistas
            // También lo agregamos a la Lista de Ciclistas
            // AgregarCiclista devuelve Boolean
            if (Ciclista.AgregarCiclista(ciclista))
            {
                // Si se agregó correctamente a la base de datos, agregar también a la lista local
                _listaCiclistas.Add(ciclista);
                MessageBox.Show("Ciclista agregado correctamente." + 
                    " Tu dorsal es: " + ciclista.Dorsal, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                // Si ocurre un error al agregar a la base de datos
                MessageBox.Show("Error al agregar el ciclista a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Limpiar los campos para permitir ingresar otro ciclista
            textNombre.Clear();
            textDNI.Clear();
            textModeloBicicleta.Clear();
            checkPagado.Checked = false;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            // Abrir el formulario principal            
            FormMenu formMenu = new FormMenu(idCompeticionSeleccionada);
            formMenu.Show();//mostrar el menú principal
            this.Hide(); // Ocultar el menú actual
        }
    }
}
