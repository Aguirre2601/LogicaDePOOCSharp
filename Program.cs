using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logica_de_POO
{
    class Program
    {
        public static void Main(string[] args)
        {
            variables.Array1 = new int[5];
            variables.Array2 = new int[5];
            variables.numero = new Random();
            variables.num = 0;
            string hora = "";
            string fecha = "";
            variables.Archivo = File.AppendText("Texto.txt");
            hora = DateTime.Now.ToString("hh:mm:ss");
            fecha = DateTime.Now.ToShortDateString();
            Console.WriteLine("" + hora + "  " + fecha + "\n");
            variables.Archivo.Write("\n" + "" + hora + "  " + fecha + "\n");
            variables.Archivo.WriteLine("Ejercicio: ");
            Console.Write("Array 1:");
            variables.Archivo.Write("Array 1:");
            For(variables.Array1, variables.numero);
            Console.Write("Array 2:");
            variables.Archivo.Write("Array 2:");
            For(variables.Array2, variables.numero);
            Console.Write("Resultante:  ");
            variables.Archivo.Write("Resultante:  ");
            multiplicacion.multi();
            variables.Archivo.Close();
            Console.Write("\n Presione cualquier tecla para SALIR");
            Console.ReadKey();
        }
        public static void For(int[] Array, Random numero)
        {
            for (int f = 0; f < 5; f++)
            {
                Array[f] = numero.Next(1, 9);
                Console.Write("  " + Array[f]);
                variables.Archivo.Write("  " + Array[f]);
            }
            Console.Write("\n\n");
            variables.Archivo.Write("\n\n");
        }
    }
}
