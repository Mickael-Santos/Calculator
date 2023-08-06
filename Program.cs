using System;

namespace Calculadora
{
    class Program
    {
        static void Main()
        {
            Menu();

        }

        static void Menu()
        {
            DesenharTela(30, 10, 30, 30);
            EscreverOpcoes(2, 2);
            Menu();
        }

        static void DesenharTela(int cabecalho, int altura, int largura = 0, int rodape = 0)
        {
            Console.Clear();
            Console.Write("|");
            for (var i = 0; i <= cabecalho; i++)
            {
                Console.Write("°");
            }
            Console.WriteLine("|");
            for (var i = 0; i <= altura; i++)
            {
                Console.Write("|");
                for (var i2 = 0; i2 <= largura; i2++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
            Console.Write("|");
            for (var i = 0; i <= rodape; i++)
            {
                Console.Write("°");
            }
            Console.WriteLine("|");
        }
        static void EscreverOpcoes(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" [1] - Soma");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine(" [1] - Subtração");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine(" [1] - Multiplicação");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine(" [1] - Divisão");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine(" [1] - Sair");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine("Opção:");
            Console.SetCursorPosition(x + 9, y + 6);
            int escolhaMenu = int.Parse(Console.ReadLine());
            int valor1, valor2;
            Thread.Sleep(2000);
            Console.Clear();
            switch (escolhaMenu)
            {
                case 1: Soma(); break;
                case 2: Subtrair(); break;
                case 3: Multiplicar(); break;
                case 4: Dividir(); break;
                default:
                    Console.WriteLine("Encerrando aplicação...");
                    Thread.Sleep(1000);
                    Console.WriteLine("Aplicação encerrada!...");
                    System.Environment.Exit(0);
                    break;
            }
        }
        static void Soma()
        {
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da soma é {0}", valor1 + valor2);

        }
        static void Subtrair()
        {
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da subtração é {0}", valor1 - valor2);
        }
        static void Multiplicar()
        {
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da subtração é {0}", valor1 * valor2);

        }
        static void Dividir()
        {
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da divisão é {0}", valor1 / valor2);
        }
    }
}