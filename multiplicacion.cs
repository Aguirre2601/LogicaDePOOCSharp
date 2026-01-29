
using System;
namespace Logica_de_POO
{
    public class multiplicacion
    {
        public static void multi()
        {
            for (int f = 0; f < 5; f++)
            {
                for (int ff = 0; ff < 5; ff++)
                {
                    variables.num = variables.Array1[f] *= variables.Array2[ff];
                }
                Console.Write("" + variables.num + " ");
                variables.Archivo.Write("" + variables.num + " ");
            }
        }
    }
}