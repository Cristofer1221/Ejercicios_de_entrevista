using System;
using System.Collections.Generic;

namespace casi_palindromo
{
    class NearPalindromeDiv1
    {
        static void Main(string[] args)
        {
            string cad = "abcdefgh"; //cadena de prueba
                        
            List<char> charArr = new List<char>();
            charArr.AddRange(cad);
            
            int der,izq, total= 26, result=0;

            //comprobacion
            while (charArr.Count > 1) {
                int menor = 0, pos = 0;
                int[] numeros_arreglo = new int[charArr.Count];  //arreglo a utilizar para los numeros de la cadena

                for (int i = 0; i < charArr.Count; i++) //equivalencia de numeros de la cadena ingresada en un solo arreglo
                {
                    numeros_arreglo[i] = char.ToUpper(charArr[i]) - 64;
                }

                for (int j = 1; j < charArr.Count; j++) //comparandos
                {
                    
                    if (numeros_arreglo[0] == numeros_arreglo[j])
                    {
                        menor = 0;
                        pos = j;
                        break;
                    }
                    else {
                        int distancia = 0;
                        der = Math.Abs(numeros_arreglo[0] - numeros_arreglo[j]);
                        izq = total - der;
                        if (der < izq)
                            distancia = der;
                        else
                            distancia = izq;
                        if (j == 1 || distancia < menor) {
                            menor = distancia;
                            pos = j;
                        }
                            
                       
                    }
                                       
                }
                charArr.RemoveAt(pos);
                charArr.RemoveAt(0);
                
                result += menor;
                
            }
            Console.WriteLine(result);
          
        }


    }
}
