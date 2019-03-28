namespace Hermanas_nazario
{
    partial class Factura_servicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura_servicios));
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSerCodigo = new System.Windows.Forms.RadioButton();
            this.radioSerNombre = new System.Windows.Forms.RadioButton();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnFacturaNueva = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigoFacturaSer = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton24 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton26 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton27 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton28 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 37);
            this.label5.TabIndex = 38;
            this.label5.Text = "Factura de Servicios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(681, 349);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 32);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(565, 349);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 32);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Enabled = false;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(312, 91);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescripcion.MaxLength = 30;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(171, 30);
            this.txtdescripcion.TabIndex = 42;
            this.txtdescripcion.TextChanged += new System.EventHandler(this.txtCita_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 164);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(265, 181);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(132, 122);
            this.txtCod.Margin = new System.Windows.Forms.Padding(2);
            this.txtCod.MaxLength = 13;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(143, 30);
            this.txtCod.TabIndex = 47;
            this.txtCod.Visible = false;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioSerCodigo);
            this.groupBox1.Controls.Add(this.radioSerNombre);
            this.groupBox1.Location = new System.Drawing.Point(10, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(265, 47);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo de Busqueda";
            // 
            // radioSerCodigo
            // 
            this.radioSerCodigo.AutoSize = true;
            this.radioSerCodigo.Location = new System.Drawing.Point(147, 21);
            this.radioSerCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.radioSerCodigo.Name = "radioSerCodigo";
            this.radioSerCodigo.Size = new System.Drawing.Size(99, 17);
            this.radioSerCodigo.TabIndex = 3;
            this.radioSerCodigo.Text = "Código Servicio";
            this.radioSerCodigo.UseVisualStyleBackColor = true;
            this.radioSerCodigo.CheckedChanged += new System.EventHandler(this.radioSerCodigo_CheckedChanged);
            // 
            // radioSerNombre
            // 
            this.radioSerNombre.AutoSize = true;
            this.radioSerNombre.Checked = true;
            this.radioSerNombre.Location = new System.Drawing.Point(12, 21);
            this.radioSerNombre.Margin = new System.Windows.Forms.Padding(2);
            this.radioSerNombre.Name = "radioSerNombre";
            this.radioSerNombre.Size = new System.Drawing.Size(103, 17);
            this.radioSerNombre.TabIndex = 2;
            this.radioSerNombre.TabStop = true;
            this.radioSerNombre.Text = "Nombre Servicio";
            this.radioSerNombre.UseVisualStyleBackColor = true;
            this.radioSerNombre.CheckedChanged += new System.EventHandler(this.radioSerNombre_CheckedChanged);
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(132, 122);
            this.txtnom.Margin = new System.Windows.Forms.Padding(2);
            this.txtnom.MaxLength = 30;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(143, 30);
            this.txtnom.TabIndex = 44;
            this.txtnom.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            this.txtnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnom_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nombre:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(426, 129);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.MaxLength = 5;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(57, 30);
            this.txtCantidad.TabIndex = 49;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(498, 97);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 50;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnFacturaNueva
            // 
            this.btnFacturaNueva.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFacturaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturaNueva.Location = new System.Drawing.Point(312, 349);
            this.btnFacturaNueva.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturaNueva.Name = "btnFacturaNueva";
            this.btnFacturaNueva.Size = new System.Drawing.Size(153, 32);
            this.btnFacturaNueva.TabIndex = 51;
            this.btnFacturaNueva.Text = "Nueva Factura";
            this.btnFacturaNueva.UseVisualStyleBackColor = false;
            this.btnFacturaNueva.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "No. Factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Fecha:";
            // 
            // lblCodigoFacturaSer
            // 
            this.lblCodigoFacturaSer.AutoSize = true;
            this.lblCodigoFacturaSer.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoFacturaSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFacturaSer.Location = new System.Drawing.Point(746, 94);
            this.lblCodigoFacturaSer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoFacturaSer.Name = "lblCodigoFacturaSer";
            this.lblCodigoFacturaSer.Size = new System.Drawing.Size(20, 25);
            this.lblCodigoFacturaSer.TabIndex = 54;
            this.lblCodigoFacturaSer.Text = "*";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(744, 124);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(20, 25);
            this.lblFecha.TabIndex = 55;
            this.lblFecha.Text = "*";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Tomato;
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(498, 131);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(94, 29);
            this.btnQuitar.TabIndex = 57;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(312, 164);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(481, 181);
            this.dataGridView2.TabIndex = 58;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = "Cantidad:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnCancelar);
            this.bunifuGradientPanel1.Controls.Add(this.btnFacturaNueva);
            this.bunifuGradientPanel1.Controls.Add(this.btnGuardar);
            this.bunifuGradientPanel1.Controls.Add(this.btnQuitar);
            this.bunifuGradientPanel1.Controls.Add(this.dataGridView2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox3);
            this.bunifuGradientPanel1.Controls.Add(this.btnAgregar);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.txtCantidad);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.txtdescripcion);
            this.bunifuGradientPanel1.Controls.Add(this.dataGridView1);
            this.bunifuGradientPanel1.Controls.Add(this.panel7);
            this.bunifuGradientPanel1.Controls.Add(this.lblFecha);
            this.bunifuGradientPanel1.Controls.Add(this.lblCodigoFacturaSer);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.groupBox1);
            this.bunifuGradientPanel1.Controls.Add(this.txtCod);
            this.bunifuGradientPanel1.Controls.Add(this.txtnom);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(851, 410);
            this.bunifuGradientPanel1.TabIndex = 107;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Hermanas_nazario.Properties.Resources.Button_Icon_Red;
            this.pictureBox3.Location = new System.Drawing.Point(111, 131);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 92;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Hermanas_nazario.Properties.Resources.logoo;
            this.pictureBox2.Location = new System.Drawing.Point(763, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda;
            this.pictureBox1.Image = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda__2_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.bunifuFlatButton24);
            this.panel7.Controls.Add(this.bunifuFlatButton26);
            this.panel7.Controls.Add(this.bunifuFlatButton27);
            this.panel7.Controls.Add(this.bunifuFlatButton28);
            this.panel7.Location = new System.Drawing.Point(10, 704);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(257, 99);
            this.panel7.TabIndex = 4;
            // 
            // bunifuFlatButton24
            // 
            this.bunifuFlatButton24.Activecolor = System.Drawing.Color.Turquoise;
            this.bunifuFlatButton24.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton24.BorderRadius = 0;
            this.bunifuFlatButton24.ButtonText = "Nivel economico";
            this.bunifuFlatButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton24.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton24.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton24.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton24.Iconimage")));
            this.bunifuFlatButton24.Iconimage_right = null;
            this.bunifuFlatButton24.Iconimage_right_Selected = null;
            this.bunifuFlatButton24.Iconimage_Selected = null;
            this.bunifuFlatButton24.IconMarginLeft = 0;
            this.bunifuFlatButton24.IconMarginRight = 0;
            this.bunifuFlatButton24.IconRightVisible = true;
            this.bunifuFlatButton24.IconRightZoom = 0D;
            this.bunifuFlatButton24.IconVisible = true;
            this.bunifuFlatButton24.IconZoom = 90D;
            this.bunifuFlatButton24.IsTab = false;
            this.bunifuFlatButton24.Location = new System.Drawing.Point(0, 73);
            this.bunifuFlatButton24.Name = "bunifuFlatButton24";
            this.bunifuFlatButton24.Normalcolor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton24.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuFlatButton24.OnHoverTextColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bunifuFlatButton24.selected = true;
            this.bunifuFlatButton24.Size = new System.Drawing.Size(257, 28);
            this.bunifuFlatButton24.TabIndex = 8;
            this.bunifuFlatButton24.Text = "Nivel economico";
            this.bunifuFlatButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton24.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton24.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton26
            // 
            this.bunifuFlatButton26.Activecolor = System.Drawing.Color.Turquoise;
            this.bunifuFlatButton26.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton26.BorderRadius = 0;
            this.bunifuFlatButton26.ButtonText = "Rol";
            this.bunifuFlatButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton26.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton26.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton26.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton26.Iconimage")));
            this.bunifuFlatButton26.Iconimage_right = null;
            this.bunifuFlatButton26.Iconimage_right_Selected = null;
            this.bunifuFlatButton26.Iconimage_Selected = null;
            this.bunifuFlatButton26.IconMarginLeft = 0;
            this.bunifuFlatButton26.IconMarginRight = 0;
            this.bunifuFlatButton26.IconRightVisible = true;
            this.bunifuFlatButton26.IconRightZoom = 0D;
            this.bunifuFlatButton26.IconVisible = true;
            this.bunifuFlatButton26.IconZoom = 90D;
            this.bunifuFlatButton26.IsTab = false;
            this.bunifuFlatButton26.Location = new System.Drawing.Point(0, 24);
            this.bunifuFlatButton26.Name = "bunifuFlatButton26";
            this.bunifuFlatButton26.Normalcolor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton26.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuFlatButton26.OnHoverTextColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bunifuFlatButton26.selected = true;
            this.bunifuFlatButton26.Size = new System.Drawing.Size(257, 26);
            this.bunifuFlatButton26.TabIndex = 6;
            this.bunifuFlatButton26.Text = "Rol";
            this.bunifuFlatButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton26.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton26.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton27
            // 
            this.bunifuFlatButton27.Activecolor = System.Drawing.Color.Turquoise;
            this.bunifuFlatButton27.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton27.BorderRadius = 0;
            this.bunifuFlatButton27.ButtonText = "Servicio";
            this.bunifuFlatButton27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton27.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton27.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton27.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton27.Iconimage")));
            this.bunifuFlatButton27.Iconimage_right = null;
            this.bunifuFlatButton27.Iconimage_right_Selected = null;
            this.bunifuFlatButton27.Iconimage_Selected = null;
            this.bunifuFlatButton27.IconMarginLeft = 0;
            this.bunifuFlatButton27.IconMarginRight = 0;
            this.bunifuFlatButton27.IconRightVisible = true;
            this.bunifuFlatButton27.IconRightZoom = 0D;
            this.bunifuFlatButton27.IconVisible = true;
            this.bunifuFlatButton27.IconZoom = 90D;
            this.bunifuFlatButton27.IsTab = false;
            this.bunifuFlatButton27.Location = new System.Drawing.Point(0, 49);
            this.bunifuFlatButton27.Name = "bunifuFlatButton27";
            this.bunifuFlatButton27.Normalcolor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton27.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuFlatButton27.OnHoverTextColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bunifuFlatButton27.selected = true;
            this.bunifuFlatButton27.Size = new System.Drawing.Size(257, 28);
            this.bunifuFlatButton27.TabIndex = 7;
            this.bunifuFlatButton27.Text = "Servicio";
            this.bunifuFlatButton27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton27.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton27.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton28
            // 
            this.bunifuFlatButton28.Activecolor = System.Drawing.Color.Turquoise;
            this.bunifuFlatButton28.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton28.BorderRadius = 0;
            this.bunifuFlatButton28.ButtonText = "Medida";
            this.bunifuFlatButton28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton28.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton28.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton28.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton28.Iconimage")));
            this.bunifuFlatButton28.Iconimage_right = null;
            this.bunifuFlatButton28.Iconimage_right_Selected = null;
            this.bunifuFlatButton28.Iconimage_Selected = null;
            this.bunifuFlatButton28.IconMarginLeft = 0;
            this.bunifuFlatButton28.IconMarginRight = 0;
            this.bunifuFlatButton28.IconRightVisible = true;
            this.bunifuFlatButton28.IconRightZoom = 0D;
            this.bunifuFlatButton28.IconVisible = true;
            this.bunifuFlatButton28.IconZoom = 90D;
            this.bunifuFlatButton28.IsTab = false;
            this.bunifuFlatButton28.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton28.Name = "bunifuFlatButton28";
            this.bunifuFlatButton28.Normalcolor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton28.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuFlatButton28.OnHoverTextColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bunifuFlatButton28.selected = true;
            this.bunifuFlatButton28.Size = new System.Drawing.Size(256, 25);
            this.bunifuFlatButton28.TabIndex = 5;
            this.bunifuFlatButton28.Text = "Medida";
            this.bunifuFlatButton28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton28.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton28.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Factura_servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 410);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(400, 210);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Factura_servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Factura_servicios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton radioSerCodigo;
        private System.Windows.Forms.RadioButton radioSerNombre;
        private System.Windows.Forms.Button btnFacturaNueva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigoFacturaSer;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton24;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton26;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton27;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton28;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}