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
    public partial class frm_Dashboard : Form
{
    
    private PilaHistorial pilaHistorial = new PilaHistorial(); 
    private ColaPaquetes colaPaquetes = new ColaPaquetes();    
    private ListaHistorial listaHistorial = new ListaHistorial(); 

    public frm_Dashboard()
    {
        InitializeComponent();
    }

    
    private void frm_panelAdmin_Load(object sender, EventArgs e)
    {
        
            this.Text = "Panel de Administración - Sistema de Almacenamiento";
    }

    
    private void btn_VRegistrar_Click(object sender, EventArgs e)
    {
        var frm = new frm_registrarpaquete();
        frm.ShowDialog();
    }

    
    private void btn_verPaquetes_Click(object sender, EventArgs e)
    {
        var frm = new frm_verPaquetes(colaPaquetes);
        frm.ShowDialog();
    }

       
        private void btn_entregarPaquete_Click(object sender, EventArgs e)
        {
            
            var frm = new frm_LiberarEntregarPaquete(colaPaquetes, pilaHistorial, listaHistorial);
            frm.ShowDialog();
        }

        
        private void btn_historiaPaquetes_Click(object sender, EventArgs e)
        {
            
            var frm = new frm_historial(listaHistorial);
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "¿Deseas cerrar sesión?",
            "Cerrar sesión",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); 
            }
        }

        private void lbl_registraPaquetes_Click(object sender, EventArgs e)
        {

        }
    }
}