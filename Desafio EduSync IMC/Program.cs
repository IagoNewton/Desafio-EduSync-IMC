using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Desafio_EduSync_IMC
{
     class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;
            string nome, sexo;
            int idade;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();
            {
                while (string.IsNullOrEmpty(nome) || Regex.IsMatch(nome, @"[0-9!""#$%&'()*+,-./:;?@[\\\]_`{|}~]"))//Verificar se só esta escrito letras usando Regex.
                {
                    Console.Write("Por favor apenas digite letras: ");
                    nome = Console.ReadLine(); //Uma repetição que só aceita letras.
                }
                
            }

            Console.Write("Informe seu sexo[M] para masculino ou [F] para feminino: ");
            sexo = Console.ReadLine();

            while(sexo.ToLower() != "m" || sexo.ToLower() != "f" )
            {

                if(sexo.ToLower() == "m")
                {
                    sexo = "Masculino";
                    break;
                }
                if(sexo.ToLower() == "f")
                {
                    sexo = "Feminino";
                    break;
                }
                Console.WriteLine("\nPor favor digite [M] para masculino ou [F] para feminino");
                sexo = Console.ReadLine();
            }


            Console.Write("Informe sua idade: ");
            int.TryParse(Console.ReadLine(), out idade);

            do
            {
                Console.Write("\nInforme sua altura: ");
                if (double.TryParse(Console.ReadLine().Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out altura))
                {
                    if (altura <= 0)
                    {
                        Console.WriteLine("\nAltura invalida. ");
                    }
                    if (altura > 2.60)
                    {
                        Console.WriteLine("\nAltura invalida. ");
                    }
                }
                else
                {
                    Console.WriteLine("\nDigite sua altura corretamente. ");
                }
            } while (altura <= 0 || altura > 2.60);

            do
            {
                Console.Write("\nInforme seu peso: ");
                if (double.TryParse(Console.ReadLine().Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out peso))
                {
                    if (peso <= 0)
                    {
                        Console.WriteLine("\nPeso invalido. ");
                    }
                    if (peso > 600)
                    {
                        Console.WriteLine("\nPeso invalido. ");
                    }
                }
                else
                {
                    Console.WriteLine("\nDigite seu peso corretamente. ");
                }
            } while (peso <= 0 || peso > 600);

            string categoria = "categoria";
            {
                switch (idade)
                {
                    case < 12:
                        categoria = "Infantil";
                        break;
                    case >= 12 and <= 20:
                        categoria = "Juvenil";
                        break;
                    case >= 21 and <= 65:
                        categoria = "Adulto";
                        break;
                    case >= 66:
                        categoria = "Idoso";
                        break;
                }
            }

            
            Console.WriteLine("IMC Desejável: entre 18,5 e 24,9");
            imc = Math.Round((peso / (altura * altura)));
            
           

            string riscos = "riscos";
            {
                switch (imc)
                {
                    case < 19:
                         riscos = "Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso.";
                        break;
                    case >= 19 and <= 24:
                        riscos = "Seu peso está ideal para suas referências.";
                        break;
                    case >= 25 and <= 29:
                        riscos = "Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.";
                        break;
                    case >= 30 and <=35:
                        riscos = "Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade.";
                        break;
                    case >= 36:
                        riscos = "O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas.";
                        break;
                }
            }
              
            string recomendaçao = "recomendaçao";
            {
                switch (imc)
                {
                    case < 19:
                         recomendaçao = "Inclua   carboidratos  simples  em  sua   dieta,  além  de  proteínas indispensáveis para ganho de massa magra. Procure um profissional .";
                        break;
                    case >= 19 and <= 24:
                        recomendaçao = "Mantenha uma dieta saudável e faça seus exames periódicos. ";
                        break;
                    case >= 25 and <= 29:
                        recomendaçao = "Adote um tratamento baseado em dieta balanceada, exercício físico e medicação. A ajuda de um profissional pode ser interessante.";
                        break;
                    case >= 30 and <= 35:
                        recomendaçao = "Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista (endócrino).";
                        break;
                    case >= 36:
                        recomendaçao = "Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médico especialista (endócrino).";
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("DIAGNÓSTICO PRÉVIO \r\n");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Peso: {peso}");
            Console.WriteLine($"Categoria: {categoria} ");
            Console.WriteLine($"Resultado IMC: {imc} ");
            Console.WriteLine($"Categoria: {categoria} ");
            Console.WriteLine($"Riscos : {riscos} ");
            Console.WriteLine($"Recomendaçao inicial : {recomendaçao} ");
        }
    }
}
