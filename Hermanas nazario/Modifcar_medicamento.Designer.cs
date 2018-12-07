namespace Hermanas_nazario
{
    partial class Modifcar_medicamento
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
            this.txtUnidad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.codigomed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUnidad
            // 
            this.txtUnidad.FormattingEnabled = true;
            this.txtUnidad.Items.AddRange(new object[] {
            "Caja",
            "Unidad",
            "Frasco"});
            this.txtUnidad.Location = new System.Drawing.Point(1036, 596);
            this.txtUnidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(139, 24);
            this.txtUnidad.TabIndex = 92;
            this.txtUnidad.Text = "Medida";
            this.txtUnidad.SelectedIndexChanged += new System.EventHandler(this.txtUnidad_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(776, 591);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 29);
            this.label8.TabIndex = 91;
            this.label8.Text = "Unidad de medida:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(947, 668);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(149, 53);
            this.btnBuscar.TabIndex = 88;
            this.btnBuscar.Text = "Ingresar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(1053, 513);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtprecio.MaxLength = 8;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(101, 36);
            this.txtprecio.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(735, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 29);
            this.label3.TabIndex = 86;
            this.label3.Text = "Precio de medicamento: ";
            // 
            // txtcant
            // 
            this.txtcant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcant.Location = new System.Drawing.Point(1053, 446);
            this.txtcant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcant.MaxLength = 8;
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(101, 36);
            this.txtcant.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(735, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 29);
            this.label2.TabIndex = 84;
            this.label2.Text = "Cantidad a ingresar: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(739, 314);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.MaxLength = 80;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(499, 96);
            this.richTextBox1.TabIndex = 83;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(735, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 29);
            this.label1.TabIndex = 82;
            this.label1.Text = "Descripcion de medicamento:";
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(1053, 208);
            this.txtnom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnom.MaxLength = 30;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(189, 36);
            this.txtnom.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(735, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(313, 29);
            this.label11.TabIndex = 80;
            this.label11.Text = "Nombre de medicamento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(732, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(552, 46);
            this.label5.TabIndex = 79;
            this.label5.Text = "MODIFICAR MEDICAMENTO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1171, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 95;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codigomed
            // 
            this.codigomed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigomed.Location = new System.Drawing.Point(1053, 128);
            this.codigomed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codigomed.MaxLength = 8;
            this.codigomed.Name = "codigomed";
            this.codigomed.Size = new System.Drawing.Size(85, 36);
            this.codigomed.TabIndex = 94;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(725, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(303, 29);
            this.label9.TabIndex = 93;
            this.label9.Text = "Codigo de medicamento: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda;
            this.pictureBox1.Image = global::Hermanas_nazario.Properties.Resources.volver_boton_de_flecha_de_navegacion_que_apunta_hacia_la_izquierda__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 81);
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Modifcar_medicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 742);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.codigomed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Name = "Modifcar_medicamento";
            this.Text = "Modifcar_medicamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtUnidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox codigomed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}