using System;

namespace EXERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            void escolha()
            {
                Console.WriteLine("digite [1] para voltar para o menu");
                Console.WriteLine("digite [2] para voltar para encerrar o programa");
                int alternativa = int.Parse(Console.ReadLine());

                switch (alternativa)
                {
                    case 1:
                        menu();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }

            void exercicio01()
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Digite um numero: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"O número digitado foi {numero}");
                escolha();
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
                escolha();
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
                escolha();
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
                escolha();
            }

            void Exercicio05()
            {
                Console.WriteLine("digite um numero : ");
                int numero = int.Parse(Console.ReadLine());
                string hexa = numero.ToString("x");
                Console.WriteLine(hexa);
                escolha();
            }

            void Exercicio06()
            {
                Console.WriteLine("insira a temperatura em Fahrenheit: ");
                double FT = double.Parse(Console.ReadLine());
                double celsius = (FT - 32) * (5 / 9);
                Console.WriteLine($"A temperatura em Celsius seria de {celsius}°");
                escolha();
            }

            void Exercicio07()
            {
                Console.WriteLine("Digite um numero: ");
                double N1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite um numero: ");
                double N2 = double.Parse(Console.ReadLine());
                double soma = N1 + N2;
                Console.WriteLine($"A soma desses valores é igual a {soma}");
                double produto = (N1 * N1) / (N2 * N2);
                Console.WriteLine($" esses numeros ao quadrado divididos uns pelos outros é igual a {produto}");
                double quadrado = Math.Pow(N1, 2);
                Console.WriteLine($"O primeiro numero ao quadrado é igual a {quadrado}");
                escolha();
            }

            void Exercicio08()
            {
                Console.WriteLine("insira um valor: ");
                int N1 = int.Parse(Console.ReadLine());
                Console.WriteLine("insira outro valor: ");
                int N2 = int.Parse(Console.ReadLine());

                if (N1 == N2)
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
                    while (N2 <= N1)
                    {
                        Console.WriteLine(N1--);
                    }
                }
                escolha();
            }

            void ContadorInfinito()
            {
               
                Console.WriteLine("Atenção! Pessoas epilépticas não devem usar este programa");
                Console.WriteLine("digite qualquer numero maior que 0: ");
                int william = int.Parse(Console.ReadLine());

                while (0 < william)
                {
                    Console.WriteLine(william++);
                    if (william % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                }
            }

                void Exercicio10()

                {
                    Console.WriteLine("Digite o valor do produto adquirido: ");
                    Console.WriteLine();
                    double produto = double.Parse(Console.ReadLine());

                    if (produto < 100)
                    {
                        double semitotal = (produto * 10) / 100;
                        double total = produto + semitotal;
                        Console.WriteLine($"O novo valor do produto com a porcetagem de 10% será {total}\n");
                    }
                    else
                    {
                        double semitotal = (produto * 20) / 100;
                        double total = produto + semitotal;
                        //Console.WriteLine($"O novo valor do produto com a porcetagem de 20% será {total}\n");
                        Console.WriteLine("SEU RESULTADO E .\n " + total );
                        Console.WriteLine("\n");

                    }

                escolha();

                }

            void Exercicio11()
            {
                Console.Write("digite um valor: ");
                int N1 = int.Parse(Console.ReadLine());

                //escolha dos operadores para a estrutura de condição
                Console.WriteLine(" 1 = + ");
                Console.WriteLine(" 2 = - ");
                Console.WriteLine(" 3 = * ");
                Console.WriteLine(" 4 = / ");
                Console.WriteLine(" Escolha um dos operadores:  ");
                int operadores = int.Parse(Console.ReadLine());

                Console.Write("digite outro valor: ");
                int N2 = int.Parse(Console.ReadLine());

                if (operadores == 1)
                {
                    double total = N1 + N2;
                    Console.WriteLine($"O resultado da soma entre {N1} e {N2} é igual a {total} ");
                }

                if (operadores == 2)
                {
                    double total = N1 - N2;
                    Console.WriteLine($"O resultado da subtração entre {N1} e {N2} é igual a {total} ");
                }

                if (operadores == 3)
                {
                    double total = N1 * N2;
                    Console.WriteLine($"O resultado da multiplicação entre {N1} e {N2} é igual a {total} ");
                }

                if (operadores == 4)
                {
                    double total = N1 / N2;
                    Console.WriteLine($"O resultado da divisão entre {N1} e {N2} é igual a {total} ");
                }
                escolha();
            }

            void Exercicio12()
            {
                Console.Write("digite a nota da primeira prova do aluno: ");
                double N1 = double.Parse(Console.ReadLine());
                Console.Write("Digite a nota da segunda prova do aluno : ");
                double N2 = double.Parse(Console.ReadLine());

                if ((N1 + N2) / 2 >= 7)
                {
                    Console.WriteLine("ALUNO APROVADO");
                }
                else
                {
                    Console.WriteLine("ALUNO REPROVADO");
                }
                escolha();
            }

            void ExercicioExtraFor()
            {
                for(int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"o valor de i é {i}. ");
                }
                escolha();

            }

            void ExercicioDeFuncoes1()
            {
                double F(double x, int n)
                {
                    return Math.Pow(x, n);
                }
                Console.WriteLine("Digite o valor da base: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do expoente desejado: ");
                int expoente = int.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado {F(b, expoente)}");
                escolha();
            }

            void ExercicioDeFuncoes2()
            {
                int recursiva(int x)
                {
                    return ((x <= 1) ? 1 : (x * recursiva(x - 1)));
                }
                int laco(int x)
                {
                    int fat = x;
                    for (int cont = x; cont >= 2; cont--)
                    {
                        fat *= cont - 1;
                    }
                    return fat;
                }
                Console.WriteLine("Digite um valor: ");
                int fatorial = int.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado {laco(fatorial)}");
                escolha();
            }

            void ExerciciodeFuncoes3()
            {
                Console.WriteLine("Digite o valor da sua compra em nossa loja: ");
                double compra = double.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------");
                Console.WriteLine(" ESCOLHA A OPÇÃO DE PAGAMENTO   ");
                Console.WriteLine("--------------------------------");

                Console.WriteLine(" selecione [1] para pagamento a vista");
                Console.WriteLine(" selecione [2] para pagamento no cartão");
                var pagamento = int.Parse(Console.ReadLine());
                switch (pagamento)
                {
                    case 1:
                        Console.WriteLine("Compras a vista levam 10% de desconto");
                        double total = compra - (compra / 10);
                        Console.WriteLine($"O valor final da sua compra é igual a {total:C}");
                        break;
                    case 2:
                        Console.WriteLine("selecione [1] para parcelar em 2 vezez");
                        Console.WriteLine("selecione [2] para parcelar em 3 vezez");
                        var parcelas = int.Parse(Console.ReadLine());
                        switch (parcelas)
                        {
                            case 1:
                                Console.WriteLine($" O valor será igual o valor do Preço da etiqueta");
                                double parcela2x = compra / 2;
                                Console.WriteLine($"O valor da parcela será igual a 2 parcelas de {parcela2x:C} ");
                                break;
                            case 2:
                                Console.WriteLine("Compras em 3 vezes acima de R$100,00 levam 3% de juros ao mês");
                                if (compra > 100)
                                {
                                    double parcela3x = compra / 3;
                                    double total_juros = (parcela3x / 100) * 3;
                                    double valor_final = parcela3x + total_juros;
                                    Console.WriteLine($"O valor da sua parcela será 3x de {valor_final:C} ");
                                }
                                else
                                {
                                    double parcelax = compra / 3;
                                    Console.WriteLine($"O valor da sua parcela será 3x de {parcelax:C}");
                                }
                                break;
                        }
                        break;
                }
                escolha();
            }

            void ExercicioString()
            {
                Console.WriteLine("Digite uma qualquer palavra de no máximo 80 caracteres:  ");
                string palavra = Console.ReadLine();
                int tamanho = palavra.Length;
                if (tamanho <= 80) 
                {
                    char[] letra = palavra.ToCharArray();
                    int pontuacao = 0;
                    int numeros = 0;
                    int minuscula = 0;
                    for (int i = 0; i < letra.Length; i++)
                    {
                        if (Char.IsPunctuation(letra[i]))
                        {
                            pontuacao = pontuacao + 1;
                        }

                        if (Char.IsNumber(letra[i]))
                        {
                            numeros++;
                        }

                        if (Char.IsLower(letra[i]))
                        {
                            minuscula++;
                        }
                    }
                     Console.WriteLine($"A seu texto Possui {tamanho} caracteres , {pontuacao} sinais de pontuação, {minuscula} letras minusculas e {numeros} numeros");
                }
                else
                {
                    Console.WriteLine("A sua frase passou de 80 caracteres!");
                }      
            }

            void ExercicioString2()
            {
                Console.WriteLine("Digite uma frase: ");
                string frase = Console.ReadLine();
                string[] palavras = frase.Split(' ');
                for (int i = 0; i < palavras.Length; i++)
                {
                    Console.WriteLine(palavras[i]);
                }
                escolha();
            }

            void ExercicioString3()
            {
                Console.WriteLine("Digite O seu Nome:  ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o seu endereço: ");
                string endereco = Console.ReadLine();
                Console.WriteLine("Digite o sua idade: ");
                string idade = Console.ReadLine();
                Console.WriteLine("digite o seu numero de telefone: ");
                string telefone = Console.ReadLine();
                Console.WriteLine($"Seu nome é {nome}, você tem {idade} anos, mora na rua {endereco}, seu número de telefone é {telefone}\n");
                escolha();
            }

            void ExercicioString4()
            {
                Console.WriteLine("Digite 'sim' ou 'nao': ");
                var SN = Console.ReadLine();
                string sim = "sim";
                string nao = "nao";
                if (SN == sim)
                {
                    Console.WriteLine("1\n");
                }
                else
                {
                    if (SN == nao) 
                    {
                        Console.WriteLine("0\n");
                    }
                }
                if ((SN != sim) & (SN != nao))
                {
                    Console.WriteLine("Digite Conforme o ordenado\n");
                }
                escolha();
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
                    Console.WriteLine("9-contador infinito 9\n");
                    Console.WriteLine("10-exercicio 10\n");
                    Console.WriteLine("11-exercicio 11\n");
                    Console.WriteLine("12-exercicio 12\n"); 
                    Console.WriteLine("13-exercicio extra-for 13\n");
                    Console.WriteLine("14-exercicio de funções 1\n"); 
                    Console.WriteLine("15-exercicio de funções 2\n");
                    Console.WriteLine("16-exercicio de funções 3\n");
                    Console.WriteLine("17-exercicio strings 1\n"); 
                    Console.WriteLine("18-exercicio strings 2\n");
                    Console.WriteLine("19-exercicio strings 3\n");
                    Console.WriteLine("20-exercicio strings 4\n");
                    Console.WriteLine("digite o numero do exercicio:\n ");

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
                        case 9:
                            ContadorInfinito();
                            Console.ReadLine();
                            Console.Clear();
                            menu();
                            break;
                        case 10:
                            Exercicio10();
                            Console.ReadLine();
                            Console.Clear();
                            menu();
                            break;
                        case 11:
                            Exercicio11();
                            Console.ReadLine();
                            Console.Clear();
                            menu();
                            break; 
                        case 12:
                            Exercicio12();
                            Console.ReadLine();
                            Console.Clear();
                            menu();
                            break; 
                        case 13:
                            ExercicioExtraFor();
                            Console.ReadLine();
                            Console.Clear();
                            menu();
                            break;
                        case 14:
                            ExercicioDeFuncoes1();
                            Console.ReadLine();
                            Console.Clear();
                            menu();
                            break;
                        case 15:
                            ExercicioDeFuncoes2();
                            Console.ReadLine();
                            Console.Clear();
                            menu();
                            break;
                        case 16:
                            ExerciciodeFuncoes3();
                            Console.ReadLine();
                            Console.Clear();
                            menu();
                            break; 
                        case 17:
                            ExercicioString();
                            Console.ReadLine();
                            Console.Clear();
                            menu();
                            break; 
                        case 18:
                            ExercicioString2();
                            Console.ReadLine();
                            Console.Clear();
                            menu();
                            break; 
                        case 19:
                            ExercicioString3();
                            Console.ReadLine();
                            Console.Clear();
                            menu();
                            break;
                        case 20:
                            ExercicioString4();
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
