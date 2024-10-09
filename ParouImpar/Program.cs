using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParouImpar
{
    public class Program
    {
        static void Main(string[] args)
        {
            int par, impar, val;
            par = 0;
            impar = 1;

            Console.WriteLine("Digite o valor: ");
            val = Convert.ToInt32(Console.ReadLine());

            if (par <= 10)
            {
                Console.WriteLine("Par");
            }
            else 
            {
                Console.WriteLine("Impar");
            }

            Console.ReadKey();
        }
    }
}
