using System;

namespace EXERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {

            void exercicio01()
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Digite um numero: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"O número digitado foi {numero}");
            }

            void exercicio02()
            {
                Console.WriteLine("Digite o valor em metros: ");
                double metros = double.Parse(Console.ReadLine());
                double centimetros = metros * 100;
                Console.WriteLine($"este valor em centimetros equivale a {centimetros}cm");
                double decimetros = metros * 10;
                Console.WriteLine($"O valor em decimetros equivale a {decimetros}dm");
                double milimetros = metros * 1000;
                Console.WriteLine($"Este valor em milimetros equivale a {milimetros}mm");
            }

            void exercicio03()
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("            TABUADA DE 9              ");
                Console.WriteLine("--------------------------------------");
                int variavel = 0;
                int num = 9;
                int result = 0;

                while (variavel <= 10)
                {
                    result = variavel * num;
                    Console.WriteLine($"{variavel}x{num}={result}");
                    variavel++;
                }
            }


            void ExercicioExtra()
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("              TABUADA              ");
                Console.WriteLine("--------------------------------------");
                int variavel = 0;
                Console.WriteLine("digite o valor da tabuada desejada");
                int constante = int.Parse(Console.ReadLine());
                int result = 0;

                while (variavel <= 10)
                {
                    result = variavel * constante;
                    Console.WriteLine($"{variavel}x{constante}={result}");
                    variavel++;
                }

            }

            void Exercicio05()
            {
                Console.WriteLine("digite um numero decimal: ");
                int numero = int.Parse(Console.ReadLine());
                string hexa = numero.ToString("x");
                Console.WriteLine(hexa);
            }

            void Exercicio06()
            {
                Console.WriteLine("insira a temperatura em Fahrenheit: ");
                double FT = double.Parse(Console.ReadLine());
                double celsius = (FT - 32) * (5 / 9);
                Console.WriteLine($"A temperatura em Celsius seria de {celsius}°");
            }

            void Exercicio07()
            {
                Console.WriteLine("Digite um numero: ");
                double N1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite um numero: ");
                double N2 = double.Parse(Console.ReadLine());
                double soma = N1 + N2;
                Console.WriteLine("A soma desses valores é igual a", +soma);
                double produto = (N1 * N1) / (N2 * N2);
                Console.WriteLine(" esses numeros ao quadrado divididos uns pelos outros é igual a", +produto);
                double quadrado = Math.Pow(N1, 2);
                Console.WriteLine("O primeiro numero ao quadrado é igual a", +quadrado);

            }

            void Exercicio08()
            {
                Console.WriteLine("insira um valor: ");
                int N1 = int.Parse(Console.ReadLine());
                Console.WriteLine("insira outro valor: ");
                int N2 = int.Parse(Console.ReadLine());

                if (N1==N2)
                {
                    Console.WriteLine("os numeros são iguais");
                }

                if (N1 < N2)
                {
                    while (N1 <= N2)
                    {
                        Console.WriteLine(N1++);
                    }
                 
                }
                else
                {
                    while(N2 <= N1)
                    {
                        Console.WriteLine(N1--);
                            
                    }
                }

            }



            void menu()
            {
                Console.Clear();
                Console.WriteLine("lista de exercicios\n");
                Console.WriteLine("1-exercicio 1\n");
                Console.WriteLine("2-exercicio 2\n");
                Console.WriteLine("3-exercicio 3\n");
                Console.WriteLine("4 extra-exercicio 4\n");
                Console.WriteLine("5-exercicio 5\n");
                Console.WriteLine("6-exercicio 6\n");
                Console.WriteLine("7-exercicio 7\n");
                Console.WriteLine("8-exercicio 8\n");
                Console.WriteLine("digite o numero do exercicio: ");



                var opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        exercicio01();
                        Console.ReadLine();
                        Console.Clear();
                        menu();
                        break;
                    case 2:
                        exercicio02();
                        Console.ReadLine();
                        Console.Clear();
                        menu();
                        break;
                    case 3:
                        exercicio03();
                        Console.ReadLine();
                        Console.Clear();
                        menu();
                        break;
                    case 4:
                        ExercicioExtra();
                        Console.ReadLine();
                        Console.Clear();
                        menu();
                        break;
                    case 5:
                        Exercicio05();
                        Console.ReadLine();
                        Console.Clear();
                        menu();
                        break;
                    case 6:
                        Exercicio06();
                        Console.ReadLine();
                        Console.Clear();
                        menu();
                        break;
                    case 7:
                        Exercicio07();
                        Console.ReadLine();
                        Console.Clear();
                        menu();
                        break;
                    case 8:
                        Exercicio08();
                        Console.ReadLine();
                        Console.Clear();
                        menu();
                        break;
                    default:
                        Console.WriteLine("opção inválida");
                        Console.ReadLine();
                        Console.Clear();
                        menu();
                        break;



                }
            }

            menu();

        }
    }
}
