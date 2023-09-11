using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o peso em Kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura em cm: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 20)
            {
                Console.WriteLine("\nSeu IMC é: " + imc + " ABAIXO DO PESO NORMAL");
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("Seu IMC é: " + imc + " PESO NORMAL");
            }
            else if (imc >= 24.9 && imc < 29.9)
            {
                Console.WriteLine("Seu IMC é: " + imc + " EXECESSO DE PESO");
            }
            else if (imc >= 29.9 && imc < 34.9)
            {
                Console.WriteLine("Seu IMC é: " + imc + " OBESIDADE CLASSE I");
            }
            else if (imc >=34.9 && imc < 39.9)
            {
                Console.WriteLine("Seu IMC é:  " + imc + " OBESIDADE CLASE II");
            }
            else
            {
                Console.WriteLine("Seu IMC é: " + imc + " OBESIDADE CLASSE III");
            }
            Console.WriteLine(imc);
            Console.ReadKey();
        }
    }
}
