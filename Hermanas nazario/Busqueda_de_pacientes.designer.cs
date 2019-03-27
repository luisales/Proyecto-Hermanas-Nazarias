namespace Hermanas_nazario
{
    partial class Busqueda_de_pacientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda_de_pacientes));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnGencita = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGencita = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton24 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton26 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton27 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton28 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(617, 64);
            this.label5.TabIndex = 10;
            this.label5.Text = "Busqueda de Pacientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Primer nombre: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(753, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Primer apellido:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(534, 194);
            this.txtnom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnom.MaxLength = 30;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(212, 32);
            this.txtnom.TabIndex = 13;
            this.txtnom.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            this.txtnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnom_KeyPress);
            // 
            // txtape
            // 
            this.txtape.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtape.Location = new System.Drawing.Point(1004, 194);
            this.txtape.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtape.MaxLength = 30;
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(212, 32);
            this.txtape.TabIndex = 14;
            this.txtape.TextChanged += new System.EventHandler(this.txtape_TextChanged);
            this.txtape.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtape_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(66, 243);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 180);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(62, 168);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(218, 71);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo de Busqueda";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(102, 30);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Identidad";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 29);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nombres";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(534, 194);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.MaxLength = 30;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(212, 32);
            this.txtId.TabIndex = 33;
            this.txtId.Visible = false;
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGencita
            // 
            this.btnGencita.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGencita.Enabled = false;
            this.btnGencita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGencita.Location = new System.Drawing.Point(879, 446);
            this.btnGencita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGencita.Name = "btnGencita";
            this.btnGencita.Size = new System.Drawing.Size(192, 51);
            this.btnGencita.TabIndex = 34;
            this.btnGencita.Text = "Generar Cita";
            this.btnGencita.UseVisualStyleBackColor = false;
            this.btnGencita.Click += new System.EventHandler(this.btnGencita_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Tan;
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(877, 501);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(320, 51);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar paciente";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtir
            // 
            this.txtir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtir.Enabled = false;
            this.txtir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtir.Location = new System.Drawing.Point(1077, 446);
            this.txtir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtir.Name = "txtir";
            this.txtir.Size = new System.Drawing.Size(120, 51);
            this.txtir.TabIndex = 38;
            this.txtir.Text = "Ir a cita";
            this.txtir.UseVisualStyleBackColor = false;
            this.txtir.Click += new System.EventHandler(this.txtir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Hermanas_nazario.Properties.Resources.punto_rojo;
            this.pictureBox2.Location = new System.Drawing.Point(974, 204);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Hermanas_nazario.Properties.Resources.punto_rojo;
            this.pictureBox5.Location = new System.Drawing.Point(501, 204);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda;
            this.pictureBox1.Image = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtGencita
            // 
            this.txtGencita.Enabled = false;
            this.txtGencita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGencita.Location = new System.Drawing.Point(749, 457);
            this.txtGencita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGencita.Name = "txtGencita";
            this.txtGencita.Size = new System.Drawing.Size(124, 32);
            this.txtGencita.TabIndex = 35;
            this.txtGencita.Click += new System.EventHandler(this.txtGencita_Click);
            this.txtGencita.TextChanged += new System.EventHandler(this.txtGencita_TextChanged);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Hermanas_nazario.Properties.Resources.logoo;
            this.pictureBox8.Location = new System.Drawing.Point(1166, 6);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(87, 81);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 70;
            this.pictureBox8.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnModificar);
            this.bunifuGradientPanel1.Controls.Add(this.txtnom);
            this.bunifuGradientPanel1.Controls.Add(this.txtir);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox8);
            this.bunifuGradientPanel1.Controls.Add(this.txtId);
            this.bunifuGradientPanel1.Controls.Add(this.panel7);
            this.bunifuGradientPanel1.Controls.Add(this.btnGencita);
            this.bunifuGradientPanel1.Controls.Add(this.txtGencita);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.txtape);
            this.bunifuGradientPanel1.Controls.Add(this.dataGridView1);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox5);
            this.bunifuGradientPanel1.Controls.Add(this.groupBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1266, 605);
            this.bunifuGradientPanel1.TabIndex = 107;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.bunifuFlatButton24);
            this.panel7.Controls.Add(this.bunifuFlatButton26);
            this.panel7.Controls.Add(this.bunifuFlatButton27);
            this.panel7.Controls.Add(this.bunifuFlatButton28);
            this.panel7.Location = new System.Drawing.Point(15, 1082);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(386, 152);
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
            this.bunifuFlatButton24.Location = new System.Drawing.Point(0, 112);
            this.bunifuFlatButton24.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton24.Name = "bunifuFlatButton24";
            this.bunifuFlatButton24.Normalcolor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton24.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuFlatButton24.OnHoverTextColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bunifuFlatButton24.selected = true;
            this.bunifuFlatButton24.Size = new System.Drawing.Size(386, 42);
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
            this.bunifuFlatButton26.Location = new System.Drawing.Point(0, 38);
            this.bunifuFlatButton26.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton26.Name = "bunifuFlatButton26";
            this.bunifuFlatButton26.Normalcolor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton26.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuFlatButton26.OnHoverTextColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bunifuFlatButton26.selected = true;
            this.bunifuFlatButton26.Size = new System.Drawing.Size(386, 40);
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
            this.bunifuFlatButton27.Location = new System.Drawing.Point(0, 75);
            this.bunifuFlatButton27.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton27.Name = "bunifuFlatButton27";
            this.bunifuFlatButton27.Normalcolor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton27.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuFlatButton27.OnHoverTextColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bunifuFlatButton27.selected = true;
            this.bunifuFlatButton27.Size = new System.Drawing.Size(386, 42);
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
            this.bunifuFlatButton28.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton28.Name = "bunifuFlatButton28";
            this.bunifuFlatButton28.Normalcolor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton28.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuFlatButton28.OnHoverTextColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bunifuFlatButton28.selected = true;
            this.bunifuFlatButton28.Size = new System.Drawing.Size(384, 39);
            this.bunifuFlatButton28.TabIndex = 5;
            this.bunifuFlatButton28.Text = "Medida";
            this.bunifuFlatButton28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton28.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton28.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Busqueda_de_pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1258, 605);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Busqueda_de_pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de pacientes";
            this.Load += new System.EventHandler(this.Busqueda_de_pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtape;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGencita;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button txtir;
        private System.Windows.Forms.TextBox txtGencita;
        private System.Windows.Forms.PictureBox pictureBox8;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton24;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton26;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton27;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton28;
    }
}