namespace SistAlmacenamientoProfeJheyson
{
    partial class frm_registrarpaquete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registrarpaquete));
            this.lbl_nombreDestinatario = new System.Windows.Forms.Label();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.lbl_tamañoP = new System.Windows.Forms.Label();
            this.btnRegistrarP = new System.Windows.Forms.Button();
            this.dgvRegistrarPaquetes = new System.Windows.Forms.DataGridView();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxTelefono = new System.Windows.Forms.TextBox();
            this.cmbTamaño = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tboxDNI = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tbox_Casillero = new System.Windows.Forms.TextBox();
            this.lbl_casillero = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarPaquetes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombreDestinatario
            // 
            this.lbl_nombreDestinatario.AutoSize = true;
            this.lbl_nombreDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreDestinatario.Location = new System.Drawing.Point(211, 9);
            this.lbl_nombreDestinatario.Name = "lbl_nombreDestinatario";
            this.lbl_nombreDestinatario.Size = new System.Drawing.Size(150, 16);
            this.lbl_nombreDestinatario.TabIndex = 0;
            this.lbl_nombreDestinatario.Text = "Nombre Destinatario";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero.Location = new System.Drawing.Point(644, 10);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(114, 15);
            this.lbl_Numero.TabIndex = 1;
            this.lbl_Numero.Text = "Numero telefono";
            // 
            // lbl_tamañoP
            // 
            this.lbl_tamañoP.AutoSize = true;
            this.lbl_tamañoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tamañoP.Location = new System.Drawing.Point(211, 76);
            this.lbl_tamañoP.Name = "lbl_tamañoP";
            this.lbl_tamañoP.Size = new System.Drawing.Size(135, 15);
            this.lbl_tamañoP.TabIndex = 2;
            this.lbl_tamañoP.Text = "Tamaño de paquete";
            // 
            // btnRegistrarP
            // 
            this.btnRegistrarP.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnRegistrarP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarP.FlatAppearance.BorderSize = 0;
            this.btnRegistrarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarP.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarP.Location = new System.Drawing.Point(159, 184);
            this.btnRegistrarP.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrarP.Name = "btnRegistrarP";
            this.btnRegistrarP.Size = new System.Drawing.Size(243, 45);
            this.btnRegistrarP.TabIndex = 4;
            this.btnRegistrarP.Text = "Registrar Paquetes";
            this.btnRegistrarP.UseVisualStyleBackColor = false;
            this.btnRegistrarP.Click += new System.EventHandler(this.btnRegistrarP_Click);
            // 
            // dgvRegistrarPaquetes
            // 
            this.dgvRegistrarPaquetes.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegistrarPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrarPaquetes.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRegistrarPaquetes.Location = new System.Drawing.Point(75, 250);
            this.dgvRegistrarPaquetes.Name = "dgvRegistrarPaquetes";
            this.dgvRegistrarPaquetes.RowHeadersWidth = 51;
            this.dgvRegistrarPaquetes.Size = new System.Drawing.Size(787, 139);
            this.dgvRegistrarPaquetes.TabIndex = 6;
            this.dgvRegistrarPaquetes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistrarPaquetes_CellClick);
            this.dgvRegistrarPaquetes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistrarPaquetes_CellContentClick);
            this.dgvRegistrarPaquetes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRegistrarPaquetes_CellFormatting);
            // 
            // tboxNombre
            // 
            this.tboxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombre.Location = new System.Drawing.Point(198, 34);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(182, 19);
            this.tboxNombre.TabIndex = 7;
            this.tboxNombre.TextChanged += new System.EventHandler(this.tboxNombre_TextChanged);
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxTelefono.Location = new System.Drawing.Point(604, 37);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(182, 19);
            this.tboxTelefono.TabIndex = 9;
            // 
            // cmbTamaño
            // 
            this.cmbTamaño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTamaño.FormattingEnabled = true;
            this.cmbTamaño.Location = new System.Drawing.Point(198, 90);
            this.cmbTamaño.Name = "cmbTamaño";
            this.cmbTamaño.Size = new System.Drawing.Size(182, 28);
            this.cmbTamaño.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(132, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(549, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // tboxDNI
            // 
            this.tboxDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDNI.Location = new System.Drawing.Point(604, 104);
            this.tboxDNI.Name = "tboxDNI";
            this.tboxDNI.Size = new System.Drawing.Size(182, 19);
            this.tboxDNI.TabIndex = 15;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni.Location = new System.Drawing.Point(676, 76);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(31, 15);
            this.lbl_dni.TabIndex = 16;
            this.lbl_dni.Text = "DNI";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(549, 90);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVolver.Location = new System.Drawing.Point(594, 184);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(213, 45);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver al menú principal";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tbox_Casillero
            // 
            this.tbox_Casillero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_Casillero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Casillero.Location = new System.Drawing.Point(414, 141);
            this.tbox_Casillero.Name = "tbox_Casillero";
            this.tbox_Casillero.Size = new System.Drawing.Size(182, 19);
            this.tbox_Casillero.TabIndex = 19;
            // 
            // lbl_casillero
            // 
            this.lbl_casillero.AutoSize = true;
            this.lbl_casillero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_casillero.Location = new System.Drawing.Point(452, 126);
            this.lbl_casillero.Name = "lbl_casillero";
            this.lbl_casillero.Size = new System.Drawing.Size(64, 15);
            this.lbl_casillero.TabIndex = 20;
            this.lbl_casillero.Text = "Casillero";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(604, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 3);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(604, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 3);
            this.panel1.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(198, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 3);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(198, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 3);
            this.panel4.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(397, 166);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(182, 3);
            this.panel5.TabIndex = 35;
            // 
            // frm_registrarpaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(920, 416);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_casillero);
            this.Controls.Add(this.tbox_Casillero);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.tboxDNI);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbTamaño);
            this.Controls.Add(this.tboxTelefono);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.dgvRegistrarPaquetes);
            this.Controls.Add(this.btnRegistrarP);
            this.Controls.Add(this.lbl_tamañoP);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.lbl_nombreDestinatario);
            this.Name = "frm_registrarpaquete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Paquete";
            this.Load += new System.EventHandler(this.frm_registrarpaquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarPaquetes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreDestinatario;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.Label lbl_tamañoP;
        private System.Windows.Forms.DataGridView dgvRegistrarPaquetes;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxTelefono;
        private System.Windows.Forms.ComboBox cmbTamaño;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tboxDNI;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnRegistrarP;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox tbox_Casillero;
        private System.Windows.Forms.Label lbl_casillero;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}