using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SistAlmacenamientoProfeJheyson
{
    public partial class frm_registrarpaquete : Form
    {
        
        private PilaHistorial pilaPaquetes = new PilaHistorial();

        public frm_registrarpaquete()
        {
            InitializeComponent();
        }

        private void frm_registrarpaquete_Load(object sender, EventArgs e)
        {
            
            CrearColumnasGrid();

           
            cmbTamaño.Items.AddRange(new string[] { "Pequeño", "Mediano", "Grande" });
            cmbTamaño.SelectedIndex = 0;

            
            actualizarTabla();
        }

        
        private void CrearColumnasGrid()
        {
            dgvRegistrarPaquetes.Columns.Clear();
            dgvRegistrarPaquetes.Columns.Add("colNombre", "Nombre Destinatario");
            dgvRegistrarPaquetes.Columns.Add("colTelefono", "Teléfono");
            dgvRegistrarPaquetes.Columns.Add("colTamaño", "Tamaño");
            dgvRegistrarPaquetes.Columns.Add("colDNI", "DNI");
            dgvRegistrarPaquetes.Columns.Add("colFecha", "Fecha Registro");
            dgvRegistrarPaquetes.Columns.Add("colCasi", "Casillero");

            dgvRegistrarPaquetes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistrarPaquetes.AllowUserToAddRows = false;
            dgvRegistrarPaquetes.ReadOnly = true;
        }

        
        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            string nombre = tboxNombre.Text.Trim();
            string telefono = tboxTelefono.Text.Trim();
            string tamaño = cmbTamaño.Text.Trim();
            string dni = tboxDNI.Text.Trim();
            string casillero = tbox_Casillero.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) ||
                string.IsNullOrEmpty(tamaño) || string.IsNullOrEmpty(dni)|| string.IsNullOrEmpty(casillero))
            {
                MessageBox.Show("Por favor completa todos los campos antes de registrar.",
                                "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            Nodo nuevoPaquete = new Nodo
            {
                NombreDestinatario = nombre,
                Telefono = telefono,
                Tamaño = tamaño,
                DNI = dni,
                Casillero = casillero,
                FechaIngreso = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            
            pilaPaquetes.Apilar(nuevoPaquete);

            
            try
            {
                using (var cn = new System.Data.SQLite.SQLiteConnection(BDHelper.CadenaConexion))
                {
                    cn.Open();
                    string sql = @"INSERT INTO paquetes (nombre, telefono, tamano, fecha_ingreso, estado, casillero)
               VALUES (@n, @t, @tam, @f, 'Pendiente', @casi);";
                    using (var cmd = new System.Data.SQLite.SQLiteCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@n", nombre);
                        cmd.Parameters.AddWithValue("@t", telefono);
                        cmd.Parameters.AddWithValue("@tam", tamaño + " - DNI:" + dni);
                        cmd.Parameters.AddWithValue("@f", nuevoPaquete.FechaIngreso);
                        cmd.Parameters.AddWithValue("@casi", casillero);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(" Paquete registrado correctamente y guardado en la base de datos.",
                                "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCamposRegistro();
                actualizarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el paquete:\n" + ex.Message,
                                "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void actualizarTabla()
        {
            if (dgvRegistrarPaquetes != null)
            {
                pilaPaquetes.MostrarEnGrid(dgvRegistrarPaquetes);
            }
        }

        
        private void LimpiarCamposRegistro()
        {
            tboxNombre.Clear();
            tboxTelefono.Clear();
            tboxDNI.Clear();
            tbox_Casillero.Clear();
            cmbTamaño.SelectedIndex = 0;
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

        #region
        private void dgvRegistrarPaquetes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) { }
        private void dgvRegistrarPaquetes_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvRegistrarPaquetes_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void tboxNombre_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        #endregion
    }
}