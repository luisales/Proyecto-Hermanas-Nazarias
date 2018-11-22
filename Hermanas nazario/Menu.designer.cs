namespace Hermanas_nazario
{
    partial class menu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.burcarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarFacturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarIngresoDeMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenciaMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosEstadisticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosMasVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifcarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.registarEmpleadoToolStripMenuItem,
            this.registrarUsuarioToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.documentosMedicosToolStripMenuItem,
            this.datosEstadisticosToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPacienteToolStripMenuItem,
            this.burcarPacienteToolStripMenuItem,
            this.modificarPacienteToolStripMenuItem,
            this.buscarCitasToolStripMenuItem,
            this.generarRecetaToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // registrarPacienteToolStripMenuItem
            // 
            this.registrarPacienteToolStripMenuItem.Name = "registrarPacienteToolStripMenuItem";
            this.registrarPacienteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.registrarPacienteToolStripMenuItem.Text = "Registrar paciente";
            this.registrarPacienteToolStripMenuItem.Click += new System.EventHandler(this.registrarPacienteToolStripMenuItem_Click);
            // 
            // burcarPacienteToolStripMenuItem
            // 
            this.burcarPacienteToolStripMenuItem.Name = "burcarPacienteToolStripMenuItem";
            this.burcarPacienteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.burcarPacienteToolStripMenuItem.Text = "Buscar paciente";
            this.burcarPacienteToolStripMenuItem.Click += new System.EventHandler(this.burcarPacienteToolStripMenuItem_Click);
            // 
            // modificarPacienteToolStripMenuItem
            // 
            this.modificarPacienteToolStripMenuItem.Name = "modificarPacienteToolStripMenuItem";
            this.modificarPacienteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.modificarPacienteToolStripMenuItem.Text = "Modificar paciente";
            this.modificarPacienteToolStripMenuItem.Click += new System.EventHandler(this.modificarPacienteToolStripMenuItem_Click);
            // 
            // buscarCitasToolStripMenuItem
            // 
            this.buscarCitasToolStripMenuItem.Name = "buscarCitasToolStripMenuItem";
            this.buscarCitasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.buscarCitasToolStripMenuItem.Text = "Buscar citas";
            this.buscarCitasToolStripMenuItem.Click += new System.EventHandler(this.buscarCitasToolStripMenuItem_Click);
            // 
            // generarRecetaToolStripMenuItem
            // 
            this.generarRecetaToolStripMenuItem.Name = "generarRecetaToolStripMenuItem";
            this.generarRecetaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.generarRecetaToolStripMenuItem.Text = "Generar receta";
            this.generarRecetaToolStripMenuItem.Click += new System.EventHandler(this.generarRecetaToolStripMenuItem_Click);
            // 
            // registarEmpleadoToolStripMenuItem
            // 
            this.registarEmpleadoToolStripMenuItem.Name = "registarEmpleadoToolStripMenuItem";
            this.registarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.registarEmpleadoToolStripMenuItem.Text = "Registar empleado";
            this.registarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.registarEmpleadoToolStripMenuItem_Click);
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar usuario";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarFacturarToolStripMenuItem,
            this.buscarFacturaToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // generarFacturarToolStripMenuItem
            // 
            this.generarFacturarToolStripMenuItem.Name = "generarFacturarToolStripMenuItem";
            this.generarFacturarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.generarFacturarToolStripMenuItem.Text = "Generar Factura";
            this.generarFacturarToolStripMenuItem.Click += new System.EventHandler(this.generarFacturarToolStripMenuItem_Click);
            // 
            // buscarFacturaToolStripMenuItem
            // 
            this.buscarFacturaToolStripMenuItem.Name = "buscarFacturaToolStripMenuItem";
            this.buscarFacturaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.buscarFacturaToolStripMenuItem.Text = "Buscar Factura";
            this.buscarFacturaToolStripMenuItem.Click += new System.EventHandler(this.buscarFacturaToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarIngresoDeMedicamentosToolStripMenuItem,
            this.buscarMedicamentoToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // registrarIngresoDeMedicamentosToolStripMenuItem
            // 
            this.registrarIngresoDeMedicamentosToolStripMenuItem.Name = "registrarIngresoDeMedicamentosToolStripMenuItem";
            this.registrarIngresoDeMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.registrarIngresoDeMedicamentosToolStripMenuItem.Text = "Ingresar nuevo producto";
            this.registrarIngresoDeMedicamentosToolStripMenuItem.Click += new System.EventHandler(this.registrarIngresoDeMedicamentosToolStripMenuItem_Click);
            // 
            // buscarMedicamentoToolStripMenuItem
            // 
            this.buscarMedicamentoToolStripMenuItem.Name = "buscarMedicamentoToolStripMenuItem";
            this.buscarMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.buscarMedicamentoToolStripMenuItem.Text = "Buscar medicamento";
            this.buscarMedicamentoToolStripMenuItem.Click += new System.EventHandler(this.buscarMedicamentoToolStripMenuItem_Click);
            // 
            // documentosMedicosToolStripMenuItem
            // 
            this.documentosMedicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referenciaMedicaToolStripMenuItem});
            this.documentosMedicosToolStripMenuItem.Name = "documentosMedicosToolStripMenuItem";
            this.documentosMedicosToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.documentosMedicosToolStripMenuItem.Text = "Documentos Medicos";
            // 
            // referenciaMedicaToolStripMenuItem
            // 
            this.referenciaMedicaToolStripMenuItem.Name = "referenciaMedicaToolStripMenuItem";
            this.referenciaMedicaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.referenciaMedicaToolStripMenuItem.Text = "Referencia Medica";
            this.referenciaMedicaToolStripMenuItem.Click += new System.EventHandler(this.referenciaMedicaToolStripMenuItem_Click);
            // 
            // datosEstadisticosToolStripMenuItem
            // 
            this.datosEstadisticosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicamentosMasVendidosToolStripMenuItem});
            this.datosEstadisticosToolStripMenuItem.Name = "datosEstadisticosToolStripMenuItem";
            this.datosEstadisticosToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.datosEstadisticosToolStripMenuItem.Text = "Datos estadisticos";
            // 
            // medicamentosMasVendidosToolStripMenuItem
            // 
            this.medicamentosMasVendidosToolStripMenuItem.Name = "medicamentosMasVendidosToolStripMenuItem";
            this.medicamentosMasVendidosToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.medicamentosMasVendidosToolStripMenuItem.Text = "Medicamentos mas vendidos";
            this.medicamentosMasVendidosToolStripMenuItem.Click += new System.EventHandler(this.medicamentosMasVendidosToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarRolesToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // agregarRolesToolStripMenuItem
            // 
            this.agregarRolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modifcarToolStripMenuItem});
            this.agregarRolesToolStripMenuItem.Name = "agregarRolesToolStripMenuItem";
            this.agregarRolesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarRolesToolStripMenuItem.Text = "Roles";
            this.agregarRolesToolStripMenuItem.Click += new System.EventHandler(this.agregarRolesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(23, 80);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(604, 244);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "Medicamentos mas vendidos";
            this.chart1.Titles.Add(title3);
            this.chart1.Visible = false;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modifcarToolStripMenuItem
            // 
            this.modifcarToolStripMenuItem.Name = "modifcarToolStripMenuItem";
            this.modifcarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modifcarToolStripMenuItem.Text = "Modifcar";
            this.modifcarToolStripMenuItem.Click += new System.EventHandler(this.modifcarToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hermanas_nazario.Properties.Resources.imagenmenu1;
            this.ClientSize = new System.Drawing.Size(1028, 452);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem burcarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarIngresoDeMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosMedicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenciaMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarRecetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarMedicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarFacturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarFacturaToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem datosEstadisticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosMasVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifcarToolStripMenuItem;
    }
}