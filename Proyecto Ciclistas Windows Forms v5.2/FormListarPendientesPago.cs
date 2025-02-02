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
    public partial class FormListarPendientesPago : Form
    {
        private List<Ciclista> _listaCiclistas;
        private int _idCompeticionSeleccionada;

        public FormListarPendientesPago(List<Ciclista> listaCiclistas, int idCompeticionSeleccionada)
        {
            InitializeComponent();
            _listaCiclistas = listaCiclistas; // Asignar la referencia de la lista            
            dgvCiclistasPendientesPago.CellValueChanged += dgvPendientesDePago_CellValueChanged;
            dgvCiclistasPendientesPago.CurrentCellDirtyStateChanged += dgvPendientesDePago_CurrentCellDirtyStateChanged;
            _idCompeticionSeleccionada = idCompeticionSeleccionada;
        }

        private void FormListarPendientesPago_Load(object sender, EventArgs e)
        {
            // Verificar si la lista está vacía antes de mostrarla
            if (_listaCiclistas == null || _listaCiclistas.Count == 0)
            {
                MessageBox.Show("No hay ciclistas para mostrar.");
                return; // Salir si la lista está vacía
            }

            // Crear una lista auxiliar para almacenar los ciclistas no pagados
            List<Ciclista> ciclistasNoPagados = new List<Ciclista>();

            // Recorrer todos los ciclistas en la lista original que tiene todos los ciclistas
            foreach (Ciclista ciclista in _listaCiclistas)
            {
                // Si el ciclista no está marcado como borrado y no está marcado como pagado, lo agregamos a la nueva lista
                if (!ciclista.Pagado && !ciclista.BORRADO)
                {
                    ciclistasNoPagados.Add(ciclista);
                }
            }

            // Verificar si existen ciclistas no pagados
            if (ciclistasNoPagados.Count == 0)
            {
                MessageBox.Show("Ningún participante pendiente de pago.");
                return; // Salir si no hay ciclistas no borrados
            }

            // Mostrar los ciclistas no pagados en el DataGridView
            dgvCiclistasPendientesPago.DataSource = null; // Reinicia la fuente de datos para asegurarte
            dgvCiclistasPendientesPago.DataSource = ciclistasNoPagados;//Se define fuente de datos del Data Grid View
        }

        //Este procedimiento es para cambiar de color las filas seleccionadas
        private void dgvPendientesDePago_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si estamos en la columna del checkbox "Pagado"
            if (e.ColumnIndex == dgvCiclistasPendientesPago.Columns["Pagado"].Index)
            {
                DataGridViewRow row = dgvCiclistasPendientesPago.Rows[e.RowIndex];

                // Comprobar si el checkbox está marcado
                bool pagadoSeleccionado = Convert.ToBoolean(row.Cells["Pagado"].Value);

                if (pagadoSeleccionado)
                {
                    // Cambiar el color de fondo a naranja para filas marcadas
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
                else
                {
                    // Restaurar el color original para filas desmarcadas
                    row.DefaultCellStyle.BackColor = dgvCiclistasPendientesPago.DefaultCellStyle.BackColor;
                }
            }
        }
        private void dgvPendientesDePago_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCiclistasPendientesPago.IsCurrentCellDirty)
            {
                dgvCiclistasPendientesPago.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void buttonActualizarEstadoPago_Click(object sender, EventArgs e)
        {
            // Iterar por las filas del DataGridView
            foreach (DataGridViewRow row in dgvCiclistasPendientesPago.Rows)
            {
                // Verificar si la fila está marcada (checkbox "Pagado" seleccionado)
                if (Convert.ToBoolean(row.Cells["Pagado"].Value) == true)
                {
                    // Obtener el DNI del ciclista
                    string dni = row.Cells["DNI"].Value.ToString();

                    // Buscar el ciclista en la lista local (ListaCiclistas) con foreach
                    Ciclista ciclista = null;
                    foreach (Ciclista c in _listaCiclistas)
                    {
                        if (c.DNI == dni)
                        {
                            ciclista = c;
                            break; // Encontrado, salir del bucle
                        }
                    }

                    if (ciclista != null)
                    {
                        // Marcar el ciclista como pagado en la lista local
                        ciclista.Pagado = true;

                        // Actualizar el estado de pago en la base de datos
                        ciclista.ActualizarEstadoPago();

                        // También actualizamos la celda correspondiente en el DataGridView para reflejar el cambio visualmente
                        row.Cells["Pagado"].Value = true;
                        row.DefaultCellStyle.BackColor = Color.Green; // Cambiar color de la fila para indicar que está pagado


                    }
                }
            }
            // Mensaje de éxito si al menos una fila fue procesada
            MessageBox.Show("Los ciclistas seleccionados han sido marcados como pagados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Llamar al método FormListarPendientesPago_Load para recargar los ciclistas no pagados
            // Recargar el DataGridView para reflejar el estado de los ciclistas no pagados
            RecargarDataGridView();
            // Vuelve a cargar el DataGridView con los ciclistas no pagados



        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            // Abrir el formulario principal
            FormMenu formMenu = new FormMenu(_idCompeticionSeleccionada);
            formMenu.Show();//mostrar el menú principal
            this.Hide(); // Ocultar el menú actual
        }

        

        private void RecargarDataGridView()
        {
            // Crear una lista temporal para los ciclistas no pagados
            List<Ciclista> ciclistasNoPagados = new List<Ciclista>();

            // Recorrer la lista local de ciclistas con foreach
            foreach (Ciclista ciclista in _listaCiclistas)
            {
                // Si el ciclista no ha pagado, agregarlo a la lista de no pagados
                if (!ciclista.Pagado && !ciclista.BORRADO)
                {
                    ciclistasNoPagados.Add(ciclista);
                }
            }

            // Crear un BindingList con los ciclistas no pagados
            BindingList<Ciclista> bindingListCiclistasNoPagados = new BindingList<Ciclista>(ciclistasNoPagados);

            // Asignar la BindingList filtrada como fuente de datos del DataGridView
            dgvCiclistasPendientesPago.DataSource = bindingListCiclistasNoPagados;

            // Desactivar la opción de agregar filas al final
            dgvCiclistasPendientesPago.AllowUserToAddRows = false;
        }
    }
}


/*      BindingList<T> es una colección genérica que se utiliza comúnmente en Windows Forms y otros entornos de .NET donde se necesita enlazar datos a controles como DataGridView.
        A diferencia de una lista simple (List<T>), un BindingList<T> proporciona soporte para notificaciones automáticas de cambios. Esto significa que si agregas, eliminas o modificas
        elementos en el BindingList, el control que está vinculado a esa lista se actualiza automáticamente para reflejar esos cambios.
        En este caso, el tipo de la lista es Ciclista, por lo que esta lista contendrá objetos de tipo Ciclista.

        new BindingList<Ciclista>(ciclistasNoPagados):
        Aquí estamos creando una nueva instancia de un BindingList<Ciclista>.
        El constructor de BindingList<T> acepta como parámetro una colección existente que contiene los elementos que deseas agregar a la lista enlazada. En este caso, ciclistasNoPagados
        es una lista que contiene los ciclistas que no están marcados como pagados.
        ciclistasNoPagados es una lista normal (List<Ciclista>) que previamente creamos para almacenar los ciclistas no pagados. Al pasarlo al constructor de BindingList<T>, 
        estamos transformando esa lista normal en una lista que puede ser "enlazada" (o vinculada) al DataGridView, lo que permite la actualización automática cuando se realizan cambios.

        bindingListCiclistasNoPagados:
        Este es el nombre de la nueva variable que hemos creado para almacenar la instancia de BindingList<Ciclista>.
        Esta lista ahora contendrá los ciclistas no pagados y puede ser utilizada como fuente de datos para el DataGridView.

        ¿Por qué usar BindingList<T>?

        La principal razón para usar BindingList<T> en lugar de una List<T> es que BindingList<T> admite el enlace de datos. Esto significa que si cambian los elementos dentro de la lista 
        (por ejemplo, si modificas el estado de pago de un ciclista), el DataGridView se actualizará automáticamente para reflejar esos cambios sin necesidad de recargar manualmente todo el control.

        ¿Por qué usar BindingList<T> entonces?

        El uso de BindingList<T> hace que este proceso sea más eficiente y cómodo. En lugar de tener que hacer todo el trabajo manual de recargar el DataGridView después de cada cambio, 
        BindingList<T> se encarga de eso automáticamente. Si necesitas algo más simple y tienes control total sobre cómo y cuándo actualizas los datos, puedes usar List<T> y recargar el DataGridView manualmente.*/
