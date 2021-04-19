using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajandoConArreglosUnidimensionales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaracion del Arreglo
        int[] array = new int[20];

        //creacion del objeto del tipo de la clase definida por el ususario
        Arreglos x = new Arreglos();
        private void crearYLlenarArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            array = x.LlenarArreglo(array);
            MessageBox.Show("El arreglo se lleno de numeros enteros aleatorios al azar", "Arreglos Unidimensionales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mostrarContenidoDelArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            x.MostrarArreglo(array, listBox1);
        }

        private void encontrarLaSumaYPromedioDelArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.SumaPromedio(array);
        }

        private void encontrarElNumeroMayorYSuPosicionDelArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.EncontrarNumeroMayorPosicion(array);
        }

        private void encontrarElNumeroMenorYSuPosicionEnElArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.EncontrarNumeroMenorPosicion(array);
        }
    }
}
