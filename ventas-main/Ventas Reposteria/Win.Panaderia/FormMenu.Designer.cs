namespace Win.Panaderia
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click_1);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // registroDeClienteToolStripMenuItem
            // 
            this.registroDeClienteToolStripMenuItem.Name = "registroDeClienteToolStripMenuItem";
            this.registroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.registroDeClienteToolStripMenuItem.Text = "Registro de Cliente";
            this.registroDeClienteToolStripMenuItem.Click += new System.EventHandler(this.registroDeClienteToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeProveedorToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.proveedoresToolStripMenuItem.Text = "Ventas";
            // 
            // registroDeProveedorToolStripMenuItem
            // 
            this.registroDeProveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem1});
            this.registroDeProveedorToolStripMenuItem.Name = "registroDeProveedorToolStripMenuItem";
            this.registroDeProveedorToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.registroDeProveedorToolStripMenuItem.Text = "Factura";
            this.registroDeProveedorToolStripMenuItem.Click += new System.EventHandler(this.registroDeProveedorToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem1
            // 
            this.imprimirToolStripMenuItem1.Name = "imprimirToolStripMenuItem1";
            this.imprimirToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.imprimirToolStripMenuItem1.Text = "Imprimir";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeProductoToolStripMenuItem,
            this.reporteDeClienteToolStripMenuItem,
            this.reporteDeVentasToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.reporteDeProveedoresToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeProductoToolStripMenuItem
            // 
            this.reporteDeProductoToolStripMenuItem.Name = "reporteDeProductoToolStripMenuItem";
            this.reporteDeProductoToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.reporteDeProductoToolStripMenuItem.Text = "Reporte de Clientes";
            this.reporteDeProductoToolStripMenuItem.Click += new System.EventHandler(this.reporteDeProductoToolStripMenuItem_Click);
            // 
            // reporteDeClienteToolStripMenuItem
            // 
            this.reporteDeClienteToolStripMenuItem.Name = "reporteDeClienteToolStripMenuItem";
            this.reporteDeClienteToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.reporteDeClienteToolStripMenuItem.Text = "Reporte Inventario";
            this.reporteDeClienteToolStripMenuItem.Click += new System.EventHandler(this.reporteDeClienteToolStripMenuItem_Click);
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de Producto";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.imprimirToolStripMenuItem.Text = "Reporte Ventas";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // reporteDeProveedoresToolStripMenuItem
            // 
            this.reporteDeProveedoresToolStripMenuItem.Name = "reporteDeProveedoresToolStripMenuItem";
            this.reporteDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.reporteDeProveedoresToolStripMenuItem.Text = "Reporte de Proveedores";
            this.reporteDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.reporteDeProveedoresToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logginToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // logginToolStripMenuItem
            // 
            this.logginToolStripMenuItem.Name = "logginToolStripMenuItem";
            this.logginToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.logginToolStripMenuItem.Text = "Login";
            this.logginToolStripMenuItem.Click += new System.EventHandler(this.logginToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 487);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
    }
}