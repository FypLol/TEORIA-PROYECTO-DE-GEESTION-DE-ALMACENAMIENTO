namespace SistAlmacenamientoProfeJheyson
{
    partial class frm_LiberarEntregarPaquete
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPaquetes;
        private System.Windows.Forms.Label lblMsgVacio;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnVerTodos;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnCerrar;

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
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.lblMsgVacio = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnVerTodos = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPaquetes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPaquetes.ColumnHeadersHeight = 34;
            this.dgvPaquetes.Location = new System.Drawing.Point(13, 74);
            this.dgvPaquetes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.RowHeadersWidth = 62;
            this.dgvPaquetes.Size = new System.Drawing.Size(1185, 266);
            this.dgvPaquetes.TabIndex = 0;
            // 
            // lblMsgVacio
            // 
            this.lblMsgVacio.AutoSize = true;
            this.lblMsgVacio.ForeColor = System.Drawing.Color.Gray;
            this.lblMsgVacio.Location = new System.Drawing.Point(12, 55);
            this.lblMsgVacio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsgVacio.Name = "lblMsgVacio";
            this.lblMsgVacio.Size = new System.Drawing.Size(209, 16);
            this.lblMsgVacio.TabIndex = 1;
            this.lblMsgVacio.Text = "No hay paquetes registrados aún.";
            this.lblMsgVacio.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(16, 20);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(228, 26);
            this.txtBuscar.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnBuscar.Location = new System.Drawing.Point(252, 15);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(85, 37);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnVerTodos
            // 
            this.BtnVerTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerTodos.ForeColor = System.Drawing.Color.White;
            this.BtnVerTodos.Location = new System.Drawing.Point(348, 15);
            this.BtnVerTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnVerTodos.Name = "BtnVerTodos";
            this.BtnVerTodos.Size = new System.Drawing.Size(103, 37);
            this.BtnVerTodos.TabIndex = 4;
            this.BtnVerTodos.Text = "Ver todos";
            this.BtnVerTodos.UseVisualStyleBackColor = false;
            this.BtnVerTodos.Click += new System.EventHandler(this.BtnVerTodos_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnRegistrar.Location = new System.Drawing.Point(459, 15);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(117, 37);
            this.BtnRegistrar.TabIndex = 5;
            this.BtnRegistrar.Text = "Entregar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnCerrar.Location = new System.Drawing.Point(588, 15);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(85, 37);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // frm_LiberarEntregarPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1213, 569);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.BtnVerTodos);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblMsgVacio);
            this.Controls.Add(this.dgvPaquetes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_LiberarEntregarPaquete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberar / Entregar Paquetes";
            this.Load += new System.EventHandler(this.frm_LiberarEntregarPaquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
