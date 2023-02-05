using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01Gabarito.Aplicação2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anoAtual, subtracao;
            Console.WriteLine("Digite o ano atual");
            anoAtual = int.Parse(Console.ReadLine());
            subtracao = anoAtual - 1968;
            Console.WriteLine("O restultado é " + subtracao);
            Console.ReadLine();


        }
    }
}
