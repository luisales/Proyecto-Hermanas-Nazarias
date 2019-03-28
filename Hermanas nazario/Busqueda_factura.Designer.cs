namespace Hermanas_nazario
{
    partial class Busqueda_factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda_factura));
            this.label5 = new System.Windows.Forms.Label();
            this.dgvcitas = new System.Windows.Forms.DataGridView();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 37);
            this.label5.TabIndex = 30;
            this.label5.Text = "Busqueda de Facturas";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgvcitas
            // 
            this.dgvcitas.AllowUserToAddRows = false;
            this.dgvcitas.AllowUserToDeleteRows = false;
            this.dgvcitas.AllowUserToOrderColumns = true;
            this.dgvcitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvcitas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvcitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcitas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvcitas.Location = new System.Drawing.Point(95, 112);
            this.dgvcitas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvcitas.Name = "dgvcitas";
            this.dgvcitas.ReadOnly = true;
            this.dgvcitas.Size = new System.Drawing.Size(446, 179);
            this.dgvcitas.TabIndex = 28;
            this.dgvcitas.VirtualMode = true;
            this.dgvcitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcitas_CellContentClick);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(415, 71);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcodigo.MaxLength = 8;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(126, 20);
            this.txtcodigo.TabIndex = 27;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Numero de expediente del paciente: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda;
            this.pictureBox1.Image = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda__2_;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 73);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Hermanas_nazario.Properties.Resources.logoo;
            this.pictureBox8.Location = new System.Drawing.Point(591, 4);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(58, 53);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 70;
            this.pictureBox8.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.dgvcitas);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.txtcodigo);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox8);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(662, 327);
            this.bunifuGradientPanel1.TabIndex = 67;
            // 
            // Busqueda_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 327);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 200);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Busqueda_factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Busqueda_factura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvcitas;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}