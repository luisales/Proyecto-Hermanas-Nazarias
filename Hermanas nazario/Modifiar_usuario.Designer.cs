namespace Hermanas_nazario
{
    partial class Modifiar_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifiar_usuario));
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton24 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton26 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton27 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton28 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.Enabled = false;
            this.txtCodigoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoUsuario.Location = new System.Drawing.Point(585, 146);
            this.txtCodigoUsuario.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCodigoUsuario.MaxLength = 8;
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.Size = new System.Drawing.Size(63, 30);
            this.txtCodigoUsuario.TabIndex = 66;
            this.txtCodigoUsuario.TextChanged += new System.EventHandler(this.txtCodigoUsuario_TextChanged);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(585, 192);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNombreUsuario.MaxLength = 30;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(186, 30);
            this.txtNombreUsuario.TabIndex = 65;
            this.txtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuario_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(375, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 27);
            this.label3.TabIndex = 64;
            this.label3.Text = "Codigo del Usuario: ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(375, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 29);
            this.label2.TabIndex = 63;
            this.label2.Text = "Nombre de Usuario:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(42, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 27);
            this.label1.TabIndex = 62;
            this.label1.Text = "Seleccione el usuario a modificar:";
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
            this.dataGridView1.Location = new System.Drawing.Point(27, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(320, 154);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(493, 281);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 43);
            this.btnModificar.TabIndex = 68;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda;
            this.pictureBox1.Image = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda__2_;
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Hermanas_nazario.Properties.Resources.logoo;
            this.pictureBox8.Location = new System.Drawing.Point(788, 26);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(76, 72);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 104;
            this.pictureBox8.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(426, 44);
            this.label5.TabIndex = 61;
            this.label5.Text = "Modificacíon de Usuario";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox3);
            this.bunifuGradientPanel1.Controls.Add(this.cmbestado);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.dataGridView1);
            this.bunifuGradientPanel1.Controls.Add(this.btnModificar);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox8);
            this.bunifuGradientPanel1.Controls.Add(this.panel7);
            this.bunifuGradientPanel1.Controls.Add(this.txtCodigoUsuario);
            this.bunifuGradientPanel1.Controls.Add(this.txtNombreUsuario);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(893, 424);
            this.bunifuGradientPanel1.TabIndex = 105;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Hermanas_nazario.Properties.Resources.Button_Icon_Red;
            this.pictureBox3.Location = new System.Drawing.Point(570, 244);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 109;
            this.pictureBox3.TabStop = false;
            // 
            // cmbestado
            // 
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbestado.Location = new System.Drawing.Point(585, 234);
            this.cmbestado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(121, 32);
            this.cmbestado.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(488, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 108;
            this.label4.Text = "Estado:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Hermanas_nazario.Properties.Resources.Button_Icon_Red;
            this.pictureBox2.Location = new System.Drawing.Point(567, 202);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 106;
            this.pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.bunifuFlatButton24);
            this.panel7.Controls.Add(this.bunifuFlatButton26);
            this.panel7.Controls.Add(this.bunifuFlatButton27);
            this.panel7.Controls.Add(this.bunifuFlatButton28);
            this.panel7.Location = new System.Drawing.Point(10, 703);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
            this.bunifuFlatButton24.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton24.Name = "bunifuFlatButton24";
            this.bunifuFlatButton24.Normalcolor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton24.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuFlatButton24.OnHoverTextColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bunifuFlatButton24.selected = true;
            this.bunifuFlatButton24.Size = new System.Drawing.Size(257, 27);
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
            this.bunifuFlatButton26.Location = new System.Drawing.Point(0, 25);
            this.bunifuFlatButton26.Margin = new System.Windows.Forms.Padding(4);
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
            this.bunifuFlatButton27.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton27.Name = "bunifuFlatButton27";
            this.bunifuFlatButton27.Normalcolor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton27.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuFlatButton27.OnHoverTextColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bunifuFlatButton27.selected = true;
            this.bunifuFlatButton27.Size = new System.Drawing.Size(257, 27);
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
            this.bunifuFlatButton28.Margin = new System.Windows.Forms.Padding(4);
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
            // Modifiar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 424);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(380, 180);
            this.Name = "Modifiar_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Modifiar_usuario";
            this.Load += new System.EventHandler(this.Modifiar_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton24;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton26;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton27;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton28;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label4;
    }
}