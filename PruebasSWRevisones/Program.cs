using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasSWRevisones 
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2; int num2 = -1;
            if(num1 > 0 && (num2 > 0)){ //Valida que ambos números sean positivos
                Console.WriteLine("Ambos números son positivos");
            } else
            {
                Console.WriteLine("Al menos un número es negativo");
            }
            Console.ReadLine();
            return;
        }
    }
}
