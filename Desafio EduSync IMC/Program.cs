using System;

namespace Desafio_EduSync_IMC
{
     class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;
            string nome, sexo, resultado;
            int idade;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Informe seu sexo: ");
            sexo = Console.ReadLine();

            Console.Write("Informe sua idade: ");
            int.TryParse(Console.ReadLine(), out idade);

            Console.Write("Informe sua altura: ");
            double.TryParse(Console.ReadLine(), out altura);

            Console.Write("Informe seu peso: ");
            double.TryParse(Console.ReadLine(), out peso);

           

        }
    }
}
