namespace Hermanas_nazario
{
    partial class Modificacion_roles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.txtCodigoRol = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDocumentos = new System.Windows.Forms.CheckBox();
            this.chkInventario = new System.Windows.Forms.CheckBox();
            this.chkFacturacion = new System.Windows.Forms.CheckBox();
            this.chkUsuarios = new System.Windows.Forms.CheckBox();
            this.chkEmpleados = new System.Windows.Forms.CheckBox();
            this.chkPacientes = new System.Windows.Forms.CheckBox();
            this.chkMantenimientos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(570, 55);
            this.label5.TabIndex = 11;
            this.label5.Text = "MODIFICACION DE ROL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 288);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(528, 265);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(98, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 42);
            this.label1.TabIndex = 42;
            this.label1.Text = "Seleccione el rol a modificar:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(748, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 42);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre del Rol:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(762, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 42);
            this.label3.TabIndex = 45;
            this.label3.Text = "Codigo del Rol:";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Enabled = false;
            this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.Location = new System.Drawing.Point(994, 309);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(277, 41);
            this.txtNombreRol.TabIndex = 46;
            // 
            // txtCodigoRol
            // 
            this.txtCodigoRol.Enabled = false;
            this.txtCodigoRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoRol.Location = new System.Drawing.Point(994, 209);
            this.txtCodigoRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoRol.Name = "txtCodigoRol";
            this.txtCodigoRol.Size = new System.Drawing.Size(93, 41);
            this.txtCodigoRol.TabIndex = 47;
            this.txtCodigoRol.TextChanged += new System.EventHandler(this.txtCodigoRol_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(994, 414);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(168, 66);
            this.btnModificar.TabIndex = 52;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda;
            this.pictureBox1.Image = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda__2_;
            this.pictureBox1.Location = new System.Drawing.Point(45, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 101);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(1308, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 42);
            this.label4.TabIndex = 72;
            this.label4.Text = "Permisos";
            // 
            // chkDocumentos
            // 
            this.chkDocumentos.AutoSize = true;
            this.chkDocumentos.Location = new System.Drawing.Point(1298, 370);
            this.chkDocumentos.Name = "chkDocumentos";
            this.chkDocumentos.Size = new System.Drawing.Size(126, 24);
            this.chkDocumentos.TabIndex = 71;
            this.chkDocumentos.Text = "Documentos";
            this.chkDocumentos.UseVisualStyleBackColor = true;
            // 
            // chkInventario
            // 
            this.chkInventario.AutoSize = true;
            this.chkInventario.Location = new System.Drawing.Point(1298, 339);
            this.chkInventario.Name = "chkInventario";
            this.chkInventario.Size = new System.Drawing.Size(105, 24);
            this.chkInventario.TabIndex = 70;
            this.chkInventario.Text = "Inventario";
            this.chkInventario.UseVisualStyleBackColor = true;
            // 
            // chkFacturacion
            // 
            this.chkFacturacion.AutoSize = true;
            this.chkFacturacion.Location = new System.Drawing.Point(1298, 308);
            this.chkFacturacion.Name = "chkFacturacion";
            this.chkFacturacion.Size = new System.Drawing.Size(119, 24);
            this.chkFacturacion.TabIndex = 69;
            this.chkFacturacion.Text = "Facturación";
            this.chkFacturacion.UseVisualStyleBackColor = true;
            // 
            // chkUsuarios
            // 
            this.chkUsuarios.AutoSize = true;
            this.chkUsuarios.Location = new System.Drawing.Point(1298, 277);
            this.chkUsuarios.Name = "chkUsuarios";
            this.chkUsuarios.Size = new System.Drawing.Size(159, 24);
            this.chkUsuarios.TabIndex = 68;
            this.chkUsuarios.Text = "Registrar Usuario";
            this.chkUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkEmpleados
            // 
            this.chkEmpleados.AutoSize = true;
            this.chkEmpleados.Location = new System.Drawing.Point(1298, 246);
            this.chkEmpleados.Name = "chkEmpleados";
            this.chkEmpleados.Size = new System.Drawing.Size(184, 24);
            this.chkEmpleados.TabIndex = 67;
            this.chkEmpleados.Text = "Registrar Empleados";
            this.chkEmpleados.UseVisualStyleBackColor = true;
            // 
            // chkPacientes
            // 
            this.chkPacientes.AutoSize = true;
            this.chkPacientes.Location = new System.Drawing.Point(1298, 215);
            this.chkPacientes.Name = "chkPacientes";
            this.chkPacientes.Size = new System.Drawing.Size(105, 24);
            this.chkPacientes.TabIndex = 66;
            this.chkPacientes.Text = "Pacientes";
            this.chkPacientes.UseVisualStyleBackColor = true;
            // 
            // chkMantenimientos
            // 
            this.chkMantenimientos.AutoSize = true;
            this.chkMantenimientos.Location = new System.Drawing.Point(1298, 400);
            this.chkMantenimientos.Name = "chkMantenimientos";
            this.chkMantenimientos.Size = new System.Drawing.Size(148, 24);
            this.chkMantenimientos.TabIndex = 73;
            this.chkMantenimientos.Text = "Mantenimientos";
            this.chkMantenimientos.UseVisualStyleBackColor = true;
            // 
            // Modificacion_roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 689);
            this.Controls.Add(this.chkMantenimientos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkDocumentos);
            this.Controls.Add(this.chkInventario);
            this.Controls.Add(this.chkFacturacion);
            this.Controls.Add(this.chkUsuarios);
            this.Controls.Add(this.chkEmpleados);
            this.Controls.Add(this.chkPacientes);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtCodigoRol);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Modificacion_roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion_roles";
            this.Load += new System.EventHandler(this.Modificacion_roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.TextBox txtCodigoRol;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkDocumentos;
        private System.Windows.Forms.CheckBox chkInventario;
        private System.Windows.Forms.CheckBox chkFacturacion;
        private System.Windows.Forms.CheckBox chkUsuarios;
        private System.Windows.Forms.CheckBox chkEmpleados;
        private System.Windows.Forms.CheckBox chkPacientes;
        private System.Windows.Forms.CheckBox chkMantenimientos;
    }
}