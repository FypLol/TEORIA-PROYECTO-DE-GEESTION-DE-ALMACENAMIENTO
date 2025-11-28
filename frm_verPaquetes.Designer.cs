namespace SistAlmacenamientoProfeJheyson
{
    partial class frm_verPaquetes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvVerPaquetes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblMensaje;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvVerPaquetes = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVerPaquetes
            // 
            this.dgvVerPaquetes.ColumnHeadersHeight = 34;
            this.dgvVerPaquetes.Location = new System.Drawing.Point(20, 20);
            this.dgvVerPaquetes.Name = "dgvVerPaquetes";
            this.dgvVerPaquetes.RowHeadersWidth = 62;
            this.dgvVerPaquetes.Size = new System.Drawing.Size(883, 390);
            this.dgvVerPaquetes.TabIndex = 0;
            this.dgvVerPaquetes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerPaquetes_CellContentClick_1);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(478, 436);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 40);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver al menú";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(264, 436);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 40);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblMensaje.ForeColor = System.Drawing.Color.Gray;
            this.lblMensaje.Location = new System.Drawing.Point(327, 195);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(245, 23);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "No hay paquetes pendientes 📭";
            this.lblMensaje.Visible = false;
            // 
            // frm_verPaquetes
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1213, 569);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvVerPaquetes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_verPaquetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Paquetes";
            this.Load += new System.EventHandler(this.frm_verPaquetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerPaquetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
