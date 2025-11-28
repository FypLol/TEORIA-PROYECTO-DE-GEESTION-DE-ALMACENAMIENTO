using System;
using System.Windows.Forms;

namespace SistAlmacenamientoProfeJheyson
{
    public partial class frm_LiberarEntregarPaquete : Form
    {
        private ColaPaquetes cola;
        private PilaHistorial pila;
        private ListaHistorial lista;

        
        public frm_LiberarEntregarPaquete(ColaPaquetes colaCompartida, PilaHistorial pilaCompartida, ListaHistorial listaCompartida)
        {
            InitializeComponent();
            cola = colaCompartida;
            pila = pilaCompartida;
            lista = listaCompartida;

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.Load += frm_LiberarEntregarPaquete_Load;
        }

        
        private void frm_LiberarEntregarPaquete_Load(object sender, EventArgs e)
        {
            
            cola = new ColaPaquetes();

            ConfigurarTabla();
            MostrarCola();
        }

        
        private void ConfigurarTabla()
        {
            dgvPaquetes.Columns.Clear();
            dgvPaquetes.Columns.Add("colNombre", "Nombre");
            dgvPaquetes.Columns.Add("colTelefono", "Teléfono");
            dgvPaquetes.Columns.Add("colTamaño", "Tamaño");
            dgvPaquetes.Columns.Add("colDNI", "DNI");
            dgvPaquetes.Columns.Add("colFecha", "Fecha Ingreso");
            dgvPaquetes.Columns.Add("colEstado", "Estado");

            dgvPaquetes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaquetes.AllowUserToAddRows = false;
            dgvPaquetes.ReadOnly = true;
            dgvPaquetes.RowHeadersVisible = false;
            dgvPaquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        
        private void MostrarCola()
        {
            if (cola != null)
            {
                cola.MostrarEnGrid(dgvPaquetes);
                lblMsgVacio.Visible = dgvPaquetes.Rows.Count == 0;
            }
        }

        
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Ingrese un nombre o teléfono para buscar.",
                                "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvPaquetes.ClearSelection();
            bool encontrado = false;

            foreach (DataGridViewRow fila in dgvPaquetes.Rows)
            {
                bool coincide = false;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value != null &&
                        celda.Value.ToString().IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        coincide = true;
                        break;
                    }
                }

                fila.Visible = coincide;
                if (coincide) encontrado = true;
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró ningún paquete con esos datos.",
                                "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            MostrarCola();
        }

        
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (cola == null || pila == null)
            {
                MessageBox.Show(" Las estructuras no están inicializadas correctamente.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Nodo paquete = cola.Desencolar();

            if (paquete != null)
            {
               
                pila.Apilar(paquete);
                lista.InsertarFinal(paquete.NombreDestinatario, paquete.Telefono, paquete.Tamaño, paquete.DNI, paquete.FechaIngreso);

                MessageBox.Show($"Paquete de {paquete.NombreDestinatario} entregado correctamente.",
                                "Entrega Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                MostrarCola();
            }
            else
            {
                MessageBox.Show(" No hay paquetes pendientes.",
                                "Cola Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        
        private void BtnCerrar_Click(object sender, EventArgs e)
        {

            if (this.Owner != null)
            {
                this.Owner.Show(); 
            }

            this.Close(); 

        }

    }
}
