using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01Gabarito.Aplicação1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VoeAirLines");
            Console.WriteLine("Qual o valor do primeiro avião?");
            decimal valor1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"o valor digitado foi:{valor1}");;
            
            Console.WriteLine("Qual o valor do segundo avião?");
            decimal valor2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"o valor digitado foi:{valor2}"); ;
            decimal total = valor1+ valor2;
            Console.WriteLine($"O total é:R$ {total}");
            Console.ReadKey();
        }
    }

}
