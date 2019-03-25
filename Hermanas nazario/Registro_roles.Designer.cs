namespace Hermanas_nazario
{
    partial class Registro_roles
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btningresar = new System.Windows.Forms.Button();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkMantenimientos = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDocumentos = new System.Windows.Forms.CheckBox();
            this.chkInventario = new System.Windows.Forms.CheckBox();
            this.chkFacturacion = new System.Windows.Forms.CheckBox();
            this.chkUsuarios = new System.Windows.Forms.CheckBox();
            this.chkEmpleados = new System.Windows.Forms.CheckBox();
            this.chkPacientes = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "REGISTRO DE ROL";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(89, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 27);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre del Rol:";
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btningresar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btningresar.Location = new System.Drawing.Point(298, 222);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(119, 45);
            this.btningresar.TabIndex = 40;
            this.btningresar.Text = "Registrar";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.Location = new System.Drawing.Point(298, 143);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNombreRol.MaxLength = 30;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(143, 30);
            this.txtNombreRol.TabIndex = 41;
            this.txtNombreRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreRol_KeyPress);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Hermanas_nazario.Properties.Resources.punto_rojo;
            this.pictureBox5.Location = new System.Drawing.Point(274, 155);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(13, 10);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 57;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda;
            this.pictureBox1.Image = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda__2_;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 66);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chkMantenimientos
            // 
            this.chkMantenimientos.AutoSize = true;
            this.chkMantenimientos.Location = new System.Drawing.Point(488, 276);
            this.chkMantenimientos.Margin = new System.Windows.Forms.Padding(2);
            this.chkMantenimientos.Name = "chkMantenimientos";
            this.chkMantenimientos.Size = new System.Drawing.Size(100, 17);
            this.chkMantenimientos.TabIndex = 74;
            this.chkMantenimientos.Text = "Mantenimientos";
            this.chkMantenimientos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(495, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 27);
            this.label2.TabIndex = 73;
            this.label2.Text = "Permisos";
            // 
            // chkDocumentos
            // 
            this.chkDocumentos.AutoSize = true;
            this.chkDocumentos.Location = new System.Drawing.Point(488, 257);
            this.chkDocumentos.Margin = new System.Windows.Forms.Padding(2);
            this.chkDocumentos.Name = "chkDocumentos";
            this.chkDocumentos.Size = new System.Drawing.Size(86, 17);
            this.chkDocumentos.TabIndex = 72;
            this.chkDocumentos.Text = "Documentos";
            this.chkDocumentos.UseVisualStyleBackColor = true;
            // 
            // chkInventario
            // 
            this.chkInventario.AutoSize = true;
            this.chkInventario.Location = new System.Drawing.Point(488, 237);
            this.chkInventario.Margin = new System.Windows.Forms.Padding(2);
            this.chkInventario.Name = "chkInventario";
            this.chkInventario.Size = new System.Drawing.Size(73, 17);
            this.chkInventario.TabIndex = 71;
            this.chkInventario.Text = "Inventario";
            this.chkInventario.UseVisualStyleBackColor = true;
            // 
            // chkFacturacion
            // 
            this.chkFacturacion.AutoSize = true;
            this.chkFacturacion.Location = new System.Drawing.Point(488, 216);
            this.chkFacturacion.Margin = new System.Windows.Forms.Padding(2);
            this.chkFacturacion.Name = "chkFacturacion";
            this.chkFacturacion.Size = new System.Drawing.Size(82, 17);
            this.chkFacturacion.TabIndex = 70;
            this.chkFacturacion.Text = "Facturación";
            this.chkFacturacion.UseVisualStyleBackColor = true;
            // 
            // chkUsuarios
            // 
            this.chkUsuarios.AutoSize = true;
            this.chkUsuarios.Location = new System.Drawing.Point(488, 196);
            this.chkUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.chkUsuarios.Name = "chkUsuarios";
            this.chkUsuarios.Size = new System.Drawing.Size(107, 17);
            this.chkUsuarios.TabIndex = 69;
            this.chkUsuarios.Text = "Registrar Usuario";
            this.chkUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkEmpleados
            // 
            this.chkEmpleados.AutoSize = true;
            this.chkEmpleados.Location = new System.Drawing.Point(488, 176);
            this.chkEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.chkEmpleados.Name = "chkEmpleados";
            this.chkEmpleados.Size = new System.Drawing.Size(123, 17);
            this.chkEmpleados.TabIndex = 68;
            this.chkEmpleados.Text = "Registrar Empleados";
            this.chkEmpleados.UseVisualStyleBackColor = true;
            // 
            // chkPacientes
            // 
            this.chkPacientes.AutoSize = true;
            this.chkPacientes.Location = new System.Drawing.Point(488, 156);
            this.chkPacientes.Margin = new System.Windows.Forms.Padding(2);
            this.chkPacientes.Name = "chkPacientes";
            this.chkPacientes.Size = new System.Drawing.Size(73, 17);
            this.chkPacientes.TabIndex = 67;
            this.chkPacientes.Text = "Pacientes";
            this.chkPacientes.UseVisualStyleBackColor = true;
            // 
            // Registro_roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 319);
            this.Controls.Add(this.chkMantenimientos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkDocumentos);
            this.Controls.Add(this.chkInventario);
            this.Controls.Add(this.chkFacturacion);
            this.Controls.Add(this.chkUsuarios);
            this.Controls.Add(this.chkEmpleados);
            this.Controls.Add(this.chkPacientes);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_roles";
            this.Load += new System.EventHandler(this.Registro_roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox chkMantenimientos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDocumentos;
        private System.Windows.Forms.CheckBox chkInventario;
        private System.Windows.Forms.CheckBox chkFacturacion;
        private System.Windows.Forms.CheckBox chkUsuarios;
        private System.Windows.Forms.CheckBox chkEmpleados;
        private System.Windows.Forms.CheckBox chkPacientes;
    }
}