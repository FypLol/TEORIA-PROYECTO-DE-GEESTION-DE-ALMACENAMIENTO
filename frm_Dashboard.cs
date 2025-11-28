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
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;


        private void frm_panelAdmin_Load(object sender, EventArgs e)
    {
        
            this.Text = "Panel de Administración - Sistema de Almacenamiento";
    }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panel_contenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btn_VRegistrar_Click(object sender, EventArgs e)
    {
           AbrirFormulario(new frm_registrarpaquete());
    }

    
    private void btn_verPaquetes_Click(object sender, EventArgs e)
    {
            AbrirFormulario(new frm_verPaquetes(colaPaquetes));


        }


        private void btn_entregarPaquete_Click(object sender, EventArgs e)
        {

            AbrirFormulario(new frm_LiberarEntregarPaquete(colaPaquetes,pilaHistorial,listaHistorial));

        }


        private void btn_historiaPaquetes_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario(new frm_historial(listaHistorial));
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_titulo_Paint(object sender, PaintEventArgs e)
        {
           
        }
        //abrir formularios metodo
        private void AbrirFormulario(Form formulario)
        {
            // Busca si ya existe una instancia del mismo tipo
            Form existente = panel_formularios.Controls
                .OfType<Form>()
                .FirstOrDefault(f => f.GetType() == formulario.GetType());

            if (existente == null)
            {
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel_formularios.Controls.Add(formulario);
                panel_formularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                existente.BringToFront();
            }
        }

    }
}