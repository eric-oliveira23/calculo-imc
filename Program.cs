using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;
            //início
            Console.WriteLine("Digite o seu peso:");
                peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua altura");
                altura = double.Parse(Console.ReadLine());

            //processamento

            imc = peso / (altura * altura);

            //saída

            Console.WriteLine("O seu IMC é: " + imc);
                Console.ReadKey();






        }
    }
}
