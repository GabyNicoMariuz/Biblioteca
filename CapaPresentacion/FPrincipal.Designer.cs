namespace CapaPresentacion
{
    partial class FPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeAltaUnLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaunLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeAltaUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bPrestamoLibro = new System.Windows.Forms.Button();
            this.bDevolucionLibro = new System.Windows.Forms.Button();
            this.bReservarLibro = new System.Windows.Forms.Button();
            this.bRenovarPrestamo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.listadoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libroToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // libroToolStripMenuItem
            // 
            this.libroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeAltaUnLibroToolStripMenuItem,
            this.darDeBajaunLibroToolStripMenuItem});
            this.libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            this.libroToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.libroToolStripMenuItem.Text = "Libro";
            // 
            // darDeAltaUnLibroToolStripMenuItem
            // 
            this.darDeAltaUnLibroToolStripMenuItem.Name = "darDeAltaUnLibroToolStripMenuItem";
            this.darDeAltaUnLibroToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.darDeAltaUnLibroToolStripMenuItem.Text = "Agregar un libro";
            this.darDeAltaUnLibroToolStripMenuItem.Click += new System.EventHandler(this.DarDeAltaUnLibroToolStripMenuItem_Click);
            // 
            // darDeBajaunLibroToolStripMenuItem
            // 
            this.darDeBajaunLibroToolStripMenuItem.Name = "darDeBajaunLibroToolStripMenuItem";
            this.darDeBajaunLibroToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.darDeBajaunLibroToolStripMenuItem.Text = "Dar de baja un libro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeAltaUnClienteToolStripMenuItem,
            this.darDeBajaUnClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.clienteToolStripMenuItem.Text = "Socio";
            // 
            // darDeAltaUnClienteToolStripMenuItem
            // 
            this.darDeAltaUnClienteToolStripMenuItem.Name = "darDeAltaUnClienteToolStripMenuItem";
            this.darDeAltaUnClienteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.darDeAltaUnClienteToolStripMenuItem.Text = "Dar de alta un socio";
            this.darDeAltaUnClienteToolStripMenuItem.Click += new System.EventHandler(this.DarDeAltaUnClienteToolStripMenuItem_Click);
            // 
            // darDeBajaUnClienteToolStripMenuItem
            // 
            this.darDeBajaUnClienteToolStripMenuItem.Name = "darDeBajaUnClienteToolStripMenuItem";
            this.darDeBajaUnClienteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.darDeBajaUnClienteToolStripMenuItem.Text = "Dar de baja un socio";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeLibrosToolStripMenuItem,
            this.listadoDeClientesToolStripMenuItem,
            this.listadoDePrestamosToolStripMenuItem,
            this.listadoDeReservasToolStripMenuItem});
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // listadoDeLibrosToolStripMenuItem
            // 
            this.listadoDeLibrosToolStripMenuItem.Name = "listadoDeLibrosToolStripMenuItem";
            this.listadoDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listadoDeLibrosToolStripMenuItem.Text = "Listado de libros";
            this.listadoDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.ListadoDeLibrosToolStripMenuItem_Click);
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de socios";
            this.listadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.ListadoDeClientesToolStripMenuItem_Click);
            // 
            // listadoDePrestamosToolStripMenuItem
            // 
            this.listadoDePrestamosToolStripMenuItem.Name = "listadoDePrestamosToolStripMenuItem";
            this.listadoDePrestamosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listadoDePrestamosToolStripMenuItem.Text = "Listado de prestamos";
            // 
            // listadoDeReservasToolStripMenuItem
            // 
            this.listadoDeReservasToolStripMenuItem.Name = "listadoDeReservasToolStripMenuItem";
            this.listadoDeReservasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listadoDeReservasToolStripMenuItem.Text = "Listado de reservas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // bPrestamoLibro
            // 
            this.bPrestamoLibro.Location = new System.Drawing.Point(308, 108);
            this.bPrestamoLibro.Name = "bPrestamoLibro";
            this.bPrestamoLibro.Size = new System.Drawing.Size(133, 33);
            this.bPrestamoLibro.TabIndex = 1;
            this.bPrestamoLibro.Text = "Prestamo de libro";
            this.bPrestamoLibro.UseVisualStyleBackColor = true;
            // 
            // bDevolucionLibro
            // 
            this.bDevolucionLibro.Location = new System.Drawing.Point(308, 161);
            this.bDevolucionLibro.Name = "bDevolucionLibro";
            this.bDevolucionLibro.Size = new System.Drawing.Size(133, 33);
            this.bDevolucionLibro.TabIndex = 2;
            this.bDevolucionLibro.Text = "Devolución de libro";
            this.bDevolucionLibro.UseVisualStyleBackColor = true;
            // 
            // bReservarLibro
            // 
            this.bReservarLibro.Location = new System.Drawing.Point(308, 216);
            this.bReservarLibro.Name = "bReservarLibro";
            this.bReservarLibro.Size = new System.Drawing.Size(133, 33);
            this.bReservarLibro.TabIndex = 3;
            this.bReservarLibro.Text = "Reservar un libro";
            this.bReservarLibro.UseVisualStyleBackColor = true;
            // 
            // bRenovarPrestamo
            // 
            this.bRenovarPrestamo.Location = new System.Drawing.Point(308, 264);
            this.bRenovarPrestamo.Name = "bRenovarPrestamo";
            this.bRenovarPrestamo.Size = new System.Drawing.Size(133, 33);
            this.bRenovarPrestamo.TabIndex = 4;
            this.bRenovarPrestamo.Text = "Renovar Prestamo";
            this.bRenovarPrestamo.UseVisualStyleBackColor = true;
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 353);
            this.Controls.Add(this.bRenovarPrestamo);
            this.Controls.Add(this.bReservarLibro);
            this.Controls.Add(this.bDevolucionLibro);
            this.Controls.Add(this.bPrestamoLibro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaUnLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaunLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button bPrestamoLibro;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeReservasToolStripMenuItem;
        private System.Windows.Forms.Button bDevolucionLibro;
        private System.Windows.Forms.Button bReservarLibro;
        private System.Windows.Forms.Button bRenovarPrestamo;
    }
}

