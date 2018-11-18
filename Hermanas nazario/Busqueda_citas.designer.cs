namespace Hermanas_nazario
{
    partial class Busqueda_citas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.dgvcitas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de expediente del paciente: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(855, 145);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcodigo.MaxLength = 8;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(167, 30);
            this.txtcodigo.TabIndex = 2;
            this.txtcodigo.Click += new System.EventHandler(this.txtcodigo_Click);
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // dgvcitas
            // 
            this.dgvcitas.AllowUserToAddRows = false;
            this.dgvcitas.AllowUserToDeleteRows = false;
            this.dgvcitas.AllowUserToOrderColumns = true;
            this.dgvcitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvcitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcitas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvcitas.Location = new System.Drawing.Point(568, 280);
            this.dgvcitas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvcitas.Name = "dgvcitas";
            this.dgvcitas.ReadOnly = true;
            this.dgvcitas.Size = new System.Drawing.Size(423, 220);
            this.dgvcitas.TabIndex = 3;
            this.dgvcitas.VirtualMode = true;
            this.dgvcitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcitas_CellClick);
            this.dgvcitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcitas_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(441, 46);
            this.label5.TabIndex = 25;
            this.label5.Text = "BUSQUEDA DE CITAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda;
            this.pictureBox1.Image = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda__2_;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 66);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Busqueda_citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1417, 652);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvcitas);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Busqueda_citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda_citas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvcitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.DataGridView dgvcitas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}