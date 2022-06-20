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

            /// <summary>
            /// Verifica se o nome foi digitado corretamente.
            /// </summary>
            
            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();
            {
                while (string.IsNullOrEmpty(nome) || Regex.IsMatch(nome, @"[0-9!""#$%&'()*+,-./:;?@[\\\]_`{|}~]"))//Verificar se só esta escrito letras usando Regex.
                {
                    Console.Write("Por favor apenas digite letras: ");
                    nome = Console.ReadLine(); //Uma repetição que só aceita letras.
                }
                
            }

            /// <summary>
            /// Faz com que o usuario escolha entre o sexo feminino ou masculino.
            /// </summary>
            
            Console.Write("Informe seu sexo [M] para masculino ou [F] para feminino: ");
            sexo = Console.ReadLine();

            while (sexo.ToLower() != "m" || sexo.ToLower() != "f")//Programa reconhece maiusculo ou minusculo graças a comando[ToLower].
            {

                if (sexo.ToLower() == "m")//Identifica o sexo e guarda ele.
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
                sexo = Console.ReadLine();//Repetiçao caso o usurio informe qualquer letra que nao seja F ou M.
            }

            /// <summary>
            ///  Verifica a idade informada
            /// </summary>
            /// <returns>num</returns>
            do
            {
                Console.Write("Informe sua idade: ");
                if (int.TryParse(Console.ReadLine(), out idade))
                {
                    if (idade <= 0)
                    {
                        Console.WriteLine("\nIdade invalida. ");//Nao aceita Idade negativa.
                    }
                    if (idade > 150)
                    {
                        Console.WriteLine("\nIdade invalida. ");//Nao aceita Idade acima de 150 anos.
                    }
                }
                else
                {
                    Console.WriteLine("\nDigite sua idade corretamente. ");
                }//Pede para o usuario corrigir sua idade caso passe os limites estabelecidos.
            } while (idade <= 0 || idade > 150);//Laço de repetiçao.
            
            

            /// <summary>
            /// Verifica a altura informada
            /// </summary>
            
            do
            {
                Console.Write("\nInforme sua altura: ");
                if (double.TryParse(Console.ReadLine().Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out altura))
                {//Guarda a entrada em double e certifica que o usuario possa usar virgula ou ponto.
                    if (altura <= 0)
                    {
                        Console.WriteLine("\nAltura invalida. ");//Nao aceita altura negativa.
                    }
                    if (altura > 2.60)
                    {
                        Console.WriteLine("\nAltura invalida. ");//Nao aceita altura acima de 2.60
                    }
                }
                else
                {
                    Console.WriteLine("\nDigite sua altura corretamente. ");
                }//Pede para o usuario corrigir sua altura caso passe os limites estabelecidos.
            } while (altura <= 0 || altura > 2.60);//Laço de repetiçao.
            
            /// <summary>
            /// Verifica o peso informado.
            /// </summary>
           
            do
            {
                Console.Write("\nInforme seu peso: ");
                if (double.TryParse(Console.ReadLine().Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out peso))
                {//Guarda a entrada em double e certifica que o usuario possa usar virgula ou ponto.
                    if (peso <= 0)
                    {
                        Console.WriteLine("\nPeso invalido. ");//Nao aceita peso negativo.
                    }
                    if (peso > 600)
                    {
                        Console.WriteLine("\nPeso invalido. ");//Nao aceita peso acima de 600kg.
                    }
                }
                else
                {
                    Console.WriteLine("\nDigite seu peso corretamente. ");
                }//Pede para o usuario corrigir seu peso caso passe os limites estabelecidos.
            } while (peso <= 0 || peso > 600);//Laço de repetiçao

            /// <summary>
            /// Switch para definir a categoria do IMC
            /// </summary>
            /// <param name="idade"></param>

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
                        categoria = "Idoso";// Verifica a Idade e guarda na variavel [categoria]
                        break;
                }
            }

            /// <summary>
            /// Calculo do IMC
            /// </summary>
           
            imc = Math.Round((peso / (altura * altura)));

            /// <summary>
            /// Switch para definir ricos.
            /// </summary>

            string riscos = "riscos";
            {
                switch (imc)
                {
                    case < 19:// Exibir uma das mensagens dependendo do resultado do IMC..
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
            /// <summary>
            /// Switch para definir Recomendaçao.
            /// </summary>

            string recomendaçao = "recomendaçao";
            {
                switch (imc)
                {
                    case < 19:// Exibir uma das mensagens dependendo do resultado do IMC..
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
            Console.Clear();//Comando para limpar o console.
            Console.WriteLine("DIAGNÓSTICO PRÉVIO \r\n");//Começar a exibir os dados armazenados.
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Peso: {peso}");
            Console.WriteLine($"Categoria: {categoria} \r\n\r\n");
            Console.WriteLine($"IMC Desejável: entre 18,5 e 24,9 \r\n");
            Console.WriteLine($"Resultado IMC: {imc} \r\n");
            Console.WriteLine($"Riscos: {riscos} \r\n");
            Console.WriteLine($"Recomendaçao inicial: {recomendaçao} \r\n");
        }
    }
}
