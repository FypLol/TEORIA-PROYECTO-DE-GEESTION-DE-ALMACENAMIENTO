using System;
using System.Windows.Forms;

namespace SistAlmacenamientoProfeJheyson
{
    public partial class frm_verPaquetes : Form
    {
        
        private ColaPaquetes cola;

        public frm_verPaquetes(ColaPaquetes colaPaquetes)
        {
            InitializeComponent();
            cola = colaPaquetes;
        }

        public void frm_verPaquetes_Load(object sender, EventArgs e)
        {
            this.Text = "Ver Paquetes Pendientes - Sistema de Almacenamiento";
            ConfigurarDataGridView();
            MostrarPaquetes();
        }

        
        private void ConfigurarDataGridView()
        {
            dgvVerPaquetes.Columns.Clear();
            dgvVerPaquetes.Columns.Add("colNombre", "Nombre Destinatario");
            dgvVerPaquetes.Columns.Add("colTelefono", "Teléfono");
            dgvVerPaquetes.Columns.Add("colTamaño", "Tamaño");
            dgvVerPaquetes.Columns.Add("colDNI", "DNI");
            dgvVerPaquetes.Columns.Add("colFecha", "Fecha Registro");
            dgvVerPaquetes.Columns.Add("colEstado", "Estado");

            dgvVerPaquetes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVerPaquetes.AllowUserToAddRows = false;
            dgvVerPaquetes.ReadOnly = true;
            dgvVerPaquetes.RowHeadersVisible = false;
            dgvVerPaquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVerPaquetes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVerPaquetes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        
        private void MostrarPaquetes()
        {
            try
            {
                if (cola != null)
                {
                    cola.MostrarEnGrid(dgvVerPaquetes);
                    lblMensaje.Visible = dgvVerPaquetes.Rows.Count == 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al mostrar los paquetes:\n");
            }
        }

        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarPaquetes();
        }

        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            Form menu = Application.OpenForms["frm_panelAdmin"];

            if (menu != null)
            {
                
                menu.Show();
            }

            
            this.Close();
        }

        
        private void dgvVerPaquetes_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblMensaje_Click(object sender, EventArgs e) { }
    }
}