using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajandoConArreglosUnidimensionales
{
    class Arreglos
    {
        public int [] LlenarArreglo (int [] A) 
        {

            Random rnd = new Random();
            for(int i =0; i<20; i++)
            {
                A[i] = rnd.Next(500);
            }
            return (A);

        }

        public  void MostrarArreglo(int[] A , ListBox caja ) 
        {
            for (int i = 0; i < 20; i++) 
            {
                caja.Items.Add(A[i]);
            }

        }

        public void SumaPromedio(int[] A) 
        {
            double prom = 0;
            int suma = 0;
            for(int i = 0; i<20; i++) 
            {
                suma = suma + A[i];
            }
            prom = suma / 20;
            MessageBox.Show("La suma de los numeros del arreglo es :" + suma + "\n" + "El promedio de los numeros del promedio es :" + prom, "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void  EncontrarNumeroMayorPosicion(int[] A) 
        {
           
            float mayor;
            int pos;
            mayor = A[0];
            pos = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > mayor)
                {
                    mayor = A[i];
                    pos = i;
                }

            
            }
            MessageBox.Show("El numero mayor es :" + A[pos] + " y se encuentra en la posicion "+ pos);

      



        }

        public void EncontrarNumeroMenorPosicion(int[] A)
        {

            float menor;
            int pos;
            menor = A[0];
            pos = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < menor)
                {
                    menor = A[i];
                    pos = i;
                }
            }
            MessageBox.Show("El numero menor  es :" + A[pos] + "y se encuentra en la posicion " + pos);





        }


    }
}
