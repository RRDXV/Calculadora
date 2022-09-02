using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        enum menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7 }

        static void Main(string[] args)
        {
            bool es = false;
            while (!es) // ! - se colocar isso antes de qualquer variavel declarada ela vira verdadeira
            {
                Console.WriteLine("Seja bem vindo a Calculadora \nSelecione uma opção: \n");
                Console.WriteLine("\n1-Soma \n2-Subtracao \n3-Divisao \n4-Multiplicacao \n5-Potencia \n6-Raiz \n7-sair \n");

                /*
                String opcaotxt = Console.ReadLine();
                int opcaoint = int.Parse(opcaotxt);
                menu opcao = (menu)opcaoint;  */

                menu opcao = (menu)int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case menu.Soma: // Chamar a variavel soma
                        Soma();
                        break;

                    case menu.Subtracao: // Chamar a variavel subtracao
                        Sub();
                        break;

                    case menu.Divisao: // chamar a variavel Divisão
                        Div();
                        break;

                    case menu.Multiplicacao: //chamar a variavel multiplicação
                        Mult();
                        break;

                    case menu.Potencia: //chamar a variavel multiplicação
                        Pot();
                        break;

                    case menu.Raiz: //chamar a variavel multiplicação
                        Raiz();
                        break;

                    case menu.Sair: // Chamar a variavel sair
                        es = true;
                        break;
                }

                Console.WriteLine("\n");
                Console.Clear();
            }



        }

        static void Soma()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Digite o Segunto numero: ");
            int b = int.Parse(Console.ReadLine());
            int res = a + b;
            Console.WriteLine("\n");
            Console.WriteLine($"O resultado é: {res}");
            Console.ReadLine();
        }

        static void Sub()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Subtração de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Digite o Segunto numero: ");
            int b = int.Parse(Console.ReadLine());
            int res = a - b;
            Console.WriteLine("\n");
            Console.WriteLine($"O resultado é: {res}");
            Console.ReadLine();
        }

        static void Div()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Divisão de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Digite o Segunto numero: ");
            int b = int.Parse(Console.ReadLine());
            float res = (float)a / (float)b;
            Console.WriteLine("\n");
            Console.WriteLine($"O resultado é: {res}");
            Console.ReadLine();
        }

        static void Mult()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Multiplicação de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Digite o Segunto numero: ");
            int b = int.Parse(Console.ReadLine());
            int res = a * b;
            Console.WriteLine("\n");
            Console.WriteLine($"O resultado é: {res}");
            Console.ReadLine();
        }

        static void Pot()
        {
            Console.WriteLine("\n");
            Console.WriteLine("A pontencia de um numero: ");
            Console.WriteLine("Digite a base: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Digite o expoente: ");
            int b = int.Parse(Console.ReadLine());
            int res = (int)Math.Pow(a, b);

            // Float 6a 9 digitos
            // Double 15 a 17 digitos
            // Decimal de 28 a 29 digitos


            Console.WriteLine("\n");
            Console.WriteLine($"O resultado é: {res}");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Raiz de um numero: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            double res = Math.Sqrt(a);
            Console.WriteLine("\n");
            Console.WriteLine($"O resultado é: {res}");
            Console.ReadLine();
        }


    }
}
