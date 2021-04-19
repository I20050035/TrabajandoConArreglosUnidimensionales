
namespace TrabajandoConArreglosUnidimensionales
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arreglosUnidimensionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearYLlenarArregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarContenidoDelArregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encontrarLaSumaYPromedioDelArregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encontrarElNumeroMayorYSuPosicionDelArregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encontrarElNumeroMenorYSuPosicionEnElArregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(189, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 212);
            this.listBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arreglosUnidimensionalesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arreglosUnidimensionalesToolStripMenuItem
            // 
            this.arreglosUnidimensionalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearYLlenarArregloToolStripMenuItem,
            this.mostrarContenidoDelArregloToolStripMenuItem,
            this.encontrarLaSumaYPromedioDelArregloToolStripMenuItem,
            this.encontrarElNumeroMayorYSuPosicionDelArregloToolStripMenuItem,
            this.encontrarElNumeroMenorYSuPosicionEnElArregloToolStripMenuItem});
            this.arreglosUnidimensionalesToolStripMenuItem.Name = "arreglosUnidimensionalesToolStripMenuItem";
            this.arreglosUnidimensionalesToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.arreglosUnidimensionalesToolStripMenuItem.Text = "Arreglos Unidimensionales";
            // 
            // crearYLlenarArregloToolStripMenuItem
            // 
            this.crearYLlenarArregloToolStripMenuItem.Name = "crearYLlenarArregloToolStripMenuItem";
            this.crearYLlenarArregloToolStripMenuItem.Size = new System.Drawing.Size(360, 22);
            this.crearYLlenarArregloToolStripMenuItem.Text = "Crear y Llenar Arreglo";
            this.crearYLlenarArregloToolStripMenuItem.Click += new System.EventHandler(this.crearYLlenarArregloToolStripMenuItem_Click);
            // 
            // mostrarContenidoDelArregloToolStripMenuItem
            // 
            this.mostrarContenidoDelArregloToolStripMenuItem.Name = "mostrarContenidoDelArregloToolStripMenuItem";
            this.mostrarContenidoDelArregloToolStripMenuItem.Size = new System.Drawing.Size(360, 22);
            this.mostrarContenidoDelArregloToolStripMenuItem.Text = "Mostrar contenido del arreglo";
            this.mostrarContenidoDelArregloToolStripMenuItem.Click += new System.EventHandler(this.mostrarContenidoDelArregloToolStripMenuItem_Click);
            // 
            // encontrarLaSumaYPromedioDelArregloToolStripMenuItem
            // 
            this.encontrarLaSumaYPromedioDelArregloToolStripMenuItem.Name = "encontrarLaSumaYPromedioDelArregloToolStripMenuItem";
            this.encontrarLaSumaYPromedioDelArregloToolStripMenuItem.Size = new System.Drawing.Size(360, 22);
            this.encontrarLaSumaYPromedioDelArregloToolStripMenuItem.Text = "Encontrar la suma y promedio del arreglo";
            this.encontrarLaSumaYPromedioDelArregloToolStripMenuItem.Click += new System.EventHandler(this.encontrarLaSumaYPromedioDelArregloToolStripMenuItem_Click);
            // 
            // encontrarElNumeroMayorYSuPosicionDelArregloToolStripMenuItem
            // 
            this.encontrarElNumeroMayorYSuPosicionDelArregloToolStripMenuItem.Name = "encontrarElNumeroMayorYSuPosicionDelArregloToolStripMenuItem";
            this.encontrarElNumeroMayorYSuPosicionDelArregloToolStripMenuItem.Size = new System.Drawing.Size(360, 22);
            this.encontrarElNumeroMayorYSuPosicionDelArregloToolStripMenuItem.Text = "Encontrar el numero mayor y su posicion del arreglo";
            this.encontrarElNumeroMayorYSuPosicionDelArregloToolStripMenuItem.Click += new System.EventHandler(this.encontrarElNumeroMayorYSuPosicionDelArregloToolStripMenuItem_Click);
            // 
            // encontrarElNumeroMenorYSuPosicionEnElArregloToolStripMenuItem
            // 
            this.encontrarElNumeroMenorYSuPosicionEnElArregloToolStripMenuItem.Name = "encontrarElNumeroMenorYSuPosicionEnElArregloToolStripMenuItem";
            this.encontrarElNumeroMenorYSuPosicionEnElArregloToolStripMenuItem.Size = new System.Drawing.Size(360, 22);
            this.encontrarElNumeroMenorYSuPosicionEnElArregloToolStripMenuItem.Text = "Encontrar el numero menor y su posicion en el arreglo";
            this.encontrarElNumeroMenorYSuPosicionEnElArregloToolStripMenuItem.Click += new System.EventHandler(this.encontrarElNumeroMenorYSuPosicionEnElArregloToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arreglosUnidimensionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearYLlenarArregloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarContenidoDelArregloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encontrarLaSumaYPromedioDelArregloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encontrarElNumeroMayorYSuPosicionDelArregloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encontrarElNumeroMenorYSuPosicionEnElArregloToolStripMenuItem;
    }
}

