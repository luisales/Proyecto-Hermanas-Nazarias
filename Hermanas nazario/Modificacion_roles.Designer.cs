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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificacion_roles));
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.txtCodigoRol = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkMantenimientos = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDocumentos = new System.Windows.Forms.CheckBox();
            this.chkInventario = new System.Windows.Forms.CheckBox();
            this.chkFacturacion = new System.Windows.Forms.CheckBox();
            this.chkUsuarios = new System.Windows.Forms.CheckBox();
            this.chkEmpleados = new System.Windows.Forms.CheckBox();
            this.chkPacientes = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(379, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "MODIFICACION DE ROL";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(352, 172);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 27);
            this.label1.TabIndex = 42;
            this.label1.Text = "Seleccione el rol a modificar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(370, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 27);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre del Rol:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(384, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 27);
            this.label3.TabIndex = 45;
            this.label3.Text = "Codigo del Rol:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Enabled = false;
            this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.Location = new System.Drawing.Point(529, 179);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNombreRol.MaxLength = 30;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(186, 30);
            this.txtNombreRol.TabIndex = 46;
            // 
            // txtCodigoRol
            // 
            this.txtCodigoRol.Enabled = false;
            this.txtCodigoRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoRol.Location = new System.Drawing.Point(529, 132);
            this.txtCodigoRol.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCodigoRol.MaxLength = 8;
            this.txtCodigoRol.Name = "txtCodigoRol";
            this.txtCodigoRol.Size = new System.Drawing.Size(63, 30);
            this.txtCodigoRol.TabIndex = 47;
            this.txtCodigoRol.TextChanged += new System.EventHandler(this.txtCodigoRol_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(544, 295);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 43);
            this.btnModificar.TabIndex = 52;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda;
            this.pictureBox1.Image = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda__2_;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
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
            this.chkMantenimientos.BackColor = System.Drawing.Color.Transparent;
            this.chkMantenimientos.Location = new System.Drawing.Point(730, 260);
            this.chkMantenimientos.Margin = new System.Windows.Forms.Padding(2);
            this.chkMantenimientos.Name = "chkMantenimientos";
            this.chkMantenimientos.Size = new System.Drawing.Size(100, 17);
            this.chkMantenimientos.TabIndex = 74;
            this.chkMantenimientos.Text = "Mantenimientos";
            this.chkMantenimientos.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(742, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 27);
            this.label4.TabIndex = 73;
            this.label4.Text = "Permisos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkDocumentos
            // 
            this.chkDocumentos.AutoSize = true;
            this.chkDocumentos.BackColor = System.Drawing.Color.Transparent;
            this.chkDocumentos.Location = new System.Drawing.Point(730, 240);
            this.chkDocumentos.Margin = new System.Windows.Forms.Padding(2);
            this.chkDocumentos.Name = "chkDocumentos";
            this.chkDocumentos.Size = new System.Drawing.Size(86, 17);
            this.chkDocumentos.TabIndex = 72;
            this.chkDocumentos.Text = "Documentos";
            this.chkDocumentos.UseVisualStyleBackColor = false;
            // 
            // chkInventario
            // 
            this.chkInventario.AutoSize = true;
            this.chkInventario.BackColor = System.Drawing.Color.Transparent;
            this.chkInventario.Location = new System.Drawing.Point(730, 220);
            this.chkInventario.Margin = new System.Windows.Forms.Padding(2);
            this.chkInventario.Name = "chkInventario";
            this.chkInventario.Size = new System.Drawing.Size(73, 17);
            this.chkInventario.TabIndex = 71;
            this.chkInventario.Text = "Inventario";
            this.chkInventario.UseVisualStyleBackColor = false;
            // 
            // chkFacturacion
            // 
            this.chkFacturacion.AutoSize = true;
            this.chkFacturacion.BackColor = System.Drawing.Color.Transparent;
            this.chkFacturacion.Location = new System.Drawing.Point(730, 200);
            this.chkFacturacion.Margin = new System.Windows.Forms.Padding(2);
            this.chkFacturacion.Name = "chkFacturacion";
            this.chkFacturacion.Size = new System.Drawing.Size(82, 17);
            this.chkFacturacion.TabIndex = 70;
            this.chkFacturacion.Text = "Facturación";
            this.chkFacturacion.UseVisualStyleBackColor = false;
            // 
            // chkUsuarios
            // 
            this.chkUsuarios.AutoSize = true;
            this.chkUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.chkUsuarios.Location = new System.Drawing.Point(730, 179);
            this.chkUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.chkUsuarios.Name = "chkUsuarios";
            this.chkUsuarios.Size = new System.Drawing.Size(107, 17);
            this.chkUsuarios.TabIndex = 69;
            this.chkUsuarios.Text = "Registrar Usuario";
            this.chkUsuarios.UseVisualStyleBackColor = false;
            // 
            // chkEmpleados
            // 
            this.chkEmpleados.AutoSize = true;
            this.chkEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.chkEmpleados.Location = new System.Drawing.Point(730, 160);
            this.chkEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.chkEmpleados.Name = "chkEmpleados";
            this.chkEmpleados.Size = new System.Drawing.Size(123, 17);
            this.chkEmpleados.TabIndex = 68;
            this.chkEmpleados.Text = "Registrar Empleados";
            this.chkEmpleados.UseVisualStyleBackColor = false;
            this.chkEmpleados.CheckedChanged += new System.EventHandler(this.chkEmpleados_CheckedChanged);
            // 
            // chkPacientes
            // 
            this.chkPacientes.AutoSize = true;
            this.chkPacientes.BackColor = System.Drawing.Color.Transparent;
            this.chkPacientes.Location = new System.Drawing.Point(730, 140);
            this.chkPacientes.Margin = new System.Windows.Forms.Padding(2);
            this.chkPacientes.Name = "chkPacientes";
            this.chkPacientes.Size = new System.Drawing.Size(73, 17);
            this.chkPacientes.TabIndex = 67;
            this.chkPacientes.Text = "Pacientes";
            this.chkPacientes.UseVisualStyleBackColor = false;
            this.chkPacientes.CheckedChanged += new System.EventHandler(this.chkPacientes_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(442, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 27);
            this.label7.TabIndex = 116;
            this.label7.Text = "Estado:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cmbestado
            // 
            this.cmbestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbestado.Location = new System.Drawing.Point(529, 226);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(121, 32);
            this.cmbestado.TabIndex = 115;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.textBox1);
            this.bunifuGradientPanel1.Controls.Add(this.btnModificar);
            this.bunifuGradientPanel1.Controls.Add(this.cmbestado);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.txtCodigoRol);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox8);
            this.bunifuGradientPanel1.Controls.Add(this.txtNombreRol);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.chkMantenimientos);
            this.bunifuGradientPanel1.Controls.Add(this.dataGridView1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.chkDocumentos);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.chkInventario);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.chkFacturacion);
            this.bunifuGradientPanel1.Controls.Add(this.chkPacientes);
            this.bunifuGradientPanel1.Controls.Add(this.chkUsuarios);
            this.bunifuGradientPanel1.Controls.Add(this.chkEmpleados);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(911, 353);
            this.bunifuGradientPanel1.TabIndex = 117;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Hermanas_nazario.Properties.Resources.logoo;
            this.pictureBox8.Location = new System.Drawing.Point(841, 10);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(58, 53);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 70;
            this.pictureBox8.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 117;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Modificacion_roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 353);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(360, 200);
            this.Name = "Modificacion_roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Modificacion_roles";
            this.Load += new System.EventHandler(this.Modificacion_roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox chkMantenimientos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkDocumentos;
        private System.Windows.Forms.CheckBox chkInventario;
        private System.Windows.Forms.CheckBox chkFacturacion;
        private System.Windows.Forms.CheckBox chkUsuarios;
        private System.Windows.Forms.CheckBox chkEmpleados;
        private System.Windows.Forms.CheckBox chkPacientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbestado;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox textBox1;
    }
}