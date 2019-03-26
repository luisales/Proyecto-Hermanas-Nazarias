namespace Hermanas_nazario
{
    partial class Generar_factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generar_factura));
            this.txtCita = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtValorC = new System.Windows.Forms.TextBox();
            this.txtIngresar = new System.Windows.Forms.TextBox();
            this.chkIngresar = new System.Windows.Forms.CheckBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.txtMedicamentos = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton24 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton26 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton27 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton28 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCita
            // 
            this.txtCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCita.Location = new System.Drawing.Point(207, 128);
            this.txtCita.Margin = new System.Windows.Forms.Padding(2);
            this.txtCita.MaxLength = 8;
            this.txtCita.Name = "txtCita";
            this.txtCita.Size = new System.Drawing.Size(69, 30);
            this.txtCita.TabIndex = 3;
            this.txtCita.TextChanged += new System.EventHandler(this.txtCita_TextChanged);
            this.txtCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCita_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(815, 581);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.MaxLength = 30;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(83, 30);
            this.txtTotal.TabIndex = 28;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtValorC
            // 
            this.txtValorC.Enabled = false;
            this.txtValorC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorC.Location = new System.Drawing.Point(745, 133);
            this.txtValorC.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorC.MaxLength = 8;
            this.txtValorC.Name = "txtValorC";
            this.txtValorC.Size = new System.Drawing.Size(66, 30);
            this.txtValorC.TabIndex = 29;
            this.txtValorC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorC.TextChanged += new System.EventHandler(this.txtValorC_TextChanged);
            this.txtValorC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorC_KeyPress);
            // 
            // txtIngresar
            // 
            this.txtIngresar.Enabled = false;
            this.txtIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresar.Location = new System.Drawing.Point(514, 410);
            this.txtIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.txtIngresar.MaxLength = 7;
            this.txtIngresar.Name = "txtIngresar";
            this.txtIngresar.Size = new System.Drawing.Size(74, 30);
            this.txtIngresar.TabIndex = 31;
            this.txtIngresar.Text = "0";
            this.txtIngresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIngresar.TextChanged += new System.EventHandler(this.txtIngresar_TextChanged);
            this.txtIngresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresar_KeyPress);
            // 
            // chkIngresar
            // 
            this.chkIngresar.AutoSize = true;
            this.chkIngresar.Enabled = false;
            this.chkIngresar.Location = new System.Drawing.Point(396, 418);
            this.chkIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.chkIngresar.Name = "chkIngresar";
            this.chkIngresar.Size = new System.Drawing.Size(64, 17);
            this.chkIngresar.TabIndex = 32;
            this.chkIngresar.Text = "Ingresar";
            this.chkIngresar.UseVisualStyleBackColor = true;
            this.chkIngresar.CheckedChanged += new System.EventHandler(this.chkIngresar_CheckedChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPagar.Enabled = false;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(382, 568);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(112, 43);
            this.btnPagar.TabIndex = 33;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(514, 568);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 43);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(817, 491);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubTotal.MaxLength = 30;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(83, 30);
            this.txtSubTotal.TabIndex = 40;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Enabled = false;
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(815, 536);
            this.txtConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsulta.MaxLength = 30;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(83, 30);
            this.txtConsulta.TabIndex = 41;
            this.txtConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMedicamentos
            // 
            this.txtMedicamentos.Enabled = false;
            this.txtMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicamentos.Location = new System.Drawing.Point(815, 407);
            this.txtMedicamentos.Margin = new System.Windows.Forms.Padding(2);
            this.txtMedicamentos.MaxLength = 30;
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.Size = new System.Drawing.Size(83, 30);
            this.txtMedicamentos.TabIndex = 72;
            this.txtMedicamentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(817, 449);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.MaxLength = 30;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(83, 30);
            this.txtDesc.TabIndex = 73;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda;
            this.pictureBox2.Image = global::Hermanas_nazario.Properties.Resources.Signo_más;
            this.pictureBox2.Location = new System.Drawing.Point(280, 132);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(56, 183);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(842, 211);
            this.dataGridView1.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(388, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(219, 44);
            this.label12.TabIndex = 61;
            this.label12.Text = "Facturación";
            this.label12.Click += new System.EventHandler(this.label12_Click);
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
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Hermanas_nazario.Properties.Resources.logoo;
            this.pictureBox8.Location = new System.Drawing.Point(1018, 11);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(76, 72);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 104;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.ErrorImage = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda;
            this.pictureBox3.Image = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda__2_;
            this.pictureBox3.Location = new System.Drawing.Point(10, 9);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(587, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 27);
            this.label5.TabIndex = 105;
            this.label5.Text = "Valor Cita (Lps)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(126, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 106;
            this.label1.Text = "N.Cita:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(660, 410);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 27);
            this.label2.TabIndex = 107;
            this.label2.Text = "Medicamentos:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(694, 449);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 27);
            this.label8.TabIndex = 107;
            this.label8.Text = "Descuento:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(703, 491);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 27);
            this.label9.TabIndex = 108;
            this.label9.Text = "Sub-Total:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(712, 536);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 27);
            this.label10.TabIndex = 109;
            this.label10.Text = "Consulta:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(740, 581);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 27);
            this.label11.TabIndex = 107;
            this.label11.Text = "Total:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.txtDesc);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.txtMedicamentos);
            this.bunifuGradientPanel1.Controls.Add(this.label11);
            this.bunifuGradientPanel1.Controls.Add(this.txtConsulta);
            this.bunifuGradientPanel1.Controls.Add(this.label10);
            this.bunifuGradientPanel1.Controls.Add(this.txtSubTotal);
            this.bunifuGradientPanel1.Controls.Add(this.label9);
            this.bunifuGradientPanel1.Controls.Add(this.label8);
            this.bunifuGradientPanel1.Controls.Add(this.txtTotal);
            this.bunifuGradientPanel1.Controls.Add(this.btnCancelar);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.btnPagar);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.txtIngresar);
            this.bunifuGradientPanel1.Controls.Add(this.chkIngresar);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox3);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox8);
            this.bunifuGradientPanel1.Controls.Add(this.panel7);
            this.bunifuGradientPanel1.Controls.Add(this.label12);
            this.bunifuGradientPanel1.Controls.Add(this.dataGridView1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1104, 629);
            this.bunifuGradientPanel1.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(467, 410);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 107;
            this.label3.Text = "Lps:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Hermanas_nazario.Properties.Resources.logoo;
            this.pictureBox1.Location = new System.Drawing.Point(928, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // Generar_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 629);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtValorC);
            this.Controls.Add(this.txtCita);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Generar_factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar_factura";
            this.Load += new System.EventHandler(this.Generar_factura_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Generar_factura_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCita;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtValorC;
        private System.Windows.Forms.TextBox txtIngresar;
        private System.Windows.Forms.CheckBox chkIngresar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtMedicamentos;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton24;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton26;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton27;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton28;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}