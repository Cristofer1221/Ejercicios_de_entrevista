using System;

namespace multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // primer ejercicio           
            for (int num = 1; num <= 100; num++)
            {
                Console.WriteLine("{0}", multiplos(num));                
            }
        }

        public static string multiplos(int num)
        {
            if (num % 3==0 && num %5==0)
            {
                return "Senir Op";
            }
            else if (num % 3 == 0)
            {
                return "Senir";
            }
            else if (num % 5 == 0)
            {
                return "Op";
            }
            string res = num.ToString(); 
            return res;
        }
    }
}
