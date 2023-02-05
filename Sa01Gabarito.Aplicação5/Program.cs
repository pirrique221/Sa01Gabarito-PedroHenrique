using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01Gabarito.Aplicação5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal Janeiro, Fevereiro, Março, media;
            Console.WriteLine("Digite o faturamento de Janeiro");
            Janeiro = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o faturamento de Fevereiro");
            Fevereiro = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o faturamento de Março");
            Março = decimal.Parse(Console.ReadLine());
            media = (Janeiro = Fevereiro + Março) / 3;
            Console.WriteLine("A média trimestral é de " + media);
            Console.ReadLine();



        }
    }
}
