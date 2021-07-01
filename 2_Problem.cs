using System;

namespace arreglos
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arreglo = { 3,2,7 };
            int[] arreglo = { 8, 8, 0, 9 };
            //int[] arreglo = { 0, 1, 0, 2, 0};
            //int[] arreglo = { 1, 2, 3 };

            string resultado = ">";

            for (int i = 1; i < arreglo.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arreglo[i] == arreglo[j])
                    {
                        resultado += "+";
                        if (arreglo[i] == 9)
                            arreglo[i] = 0;
                        else
                            arreglo[i] = arreglo[i] + 1;
                        j = i;
                    }

                }
                if (i != arreglo.Length - 1)
                    resultado += ">";

            }
            Console.WriteLine(resultado);



        }
    }
}
