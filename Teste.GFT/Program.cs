using System;
using Teste.GFT.src;

namespace Teste.GFT
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("Digite em que turno você trabalha");
            Console.WriteLine("M - matutino,");
            Console.WriteLine("V - vespertino");
            Console.WriteLine("N - noturno");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "M":
                Console.WriteLine("Bom dia");
                break;

                case "V":
                Console.WriteLine("Boa tarde");
                break;

                case "N":
                Console.WriteLine("Boa noite");
                break;

                default:
                Console.WriteLine("Valor inválido");
                break;

            }
            Console.WriteLine("Venda de Sucos - Limão e Tamarindo");
            Console.WriteLine("Digite L para suco de Limão");
            Console.WriteLine("Digite T para suco de tamarindo");

            double valorLitroLimao = 10;
            double valorLitroTamarindo = 15;

            string saborSuco = Console.ReadLine();

            Console.WriteLine("Agora, digite a quantidade de Litros desejada");

            int quantidadeLitros = 0;
            Int32.TryParse(Console.ReadLine(), out quantidadeLitros);

            if (saborSuco == "L")
            {
                if (quantidadeLitros < 2)
                {
                    Console.WriteLine((valorLitroLimao * quantidadeLitros) - ((valorLitroLimao / 100)* 3) *quantidadeLitros);
                }
                else if (quantidadeLitros > 5)
                {
                    Console.WriteLine((valorLitroLimao * quantidadeLitros) - ((valorLitroLimao / 100)* 5) *quantidadeLitros);
                }
                else
                {
                    Console.WriteLine(quantidadeLitros * valorLitroLimao);
                }
            }
            else if (saborSuco == "T")
            {
                if (quantidadeLitros < 2)
                {
                    Console.WriteLine((valorLitroTamarindo * quantidadeLitros) - ((valorLitroTamarindo / 100)* 4) *quantidadeLitros);
                }
                else if (quantidadeLitros > 5)
                {
                    Console.WriteLine((valorLitroTamarindo * quantidadeLitros) - ((valorLitroTamarindo / 100)* 6) *quantidadeLitros);
                }
                else
                {
                    Console.WriteLine(quantidadeLitros * valorLitroTamarindo);
                }
            }
            else
            {
                Console.WriteLine("Opção incorreta, tente novamente");
            }
            




             
            Console.WriteLine("Bem vindo ao banco de doação de sangue");
            Console.WriteLine("Por favor digite sua idade");
            int Idade = 0;
            Int32.TryParse(Console.ReadLine(), out Idade);
            if (Idade < 18 || Idade > 67 )
            {
                Console.WriteLine("Desculpe, infelizmente você não pode doar sangue");
            }
            else
            {
                Console.WriteLine("Você está apto para doar sangue");
            }

        } 
    }
}
