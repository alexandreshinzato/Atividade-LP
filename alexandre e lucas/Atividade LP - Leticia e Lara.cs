using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_LP
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double gasolina, etanol, resultado;

            {
                Console.Clear();
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("Exercício - 1");
                Console.WriteLine("Exercício - 2");
                Console.WriteLine("Exercício - 3");
                Console.WriteLine("Exercício - 4");
                Console.WriteLine("Exercício - 5");

                opcao = Convert.ToInt32(Console.ReadLine());


                switch (opcao)

                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("Insira o valor do litro da gasolina");
                        gasolina = Convert.ToDouble(Console.ReadLine());

                        resultado = gasolina * 0.7;

                        Console.WriteLine(resultado);

                        Console.Clear();
                        Console.WriteLine("Insira o valor do litro do etanol");
                        etanol = Convert.ToDouble(Console.ReadLine());

                        if (gasolina <= etanol)

                        {
                            Console.Clear();
                            Console.WriteLine("A gasolina compensa");
                            Console.ReadKey();
                        }

                        else if (gasolina == etanol)
                        {
                            Console.Clear();
                            Console.WriteLine("Ambos compensam");
                            Console.ReadKey();
                        }

                        else if (gasolina >= etanol)
                        {
                            Console.Clear();
                            Console.WriteLine("O etanol compensa");
                            Console.ReadKey();
                        }

                        break;
               

                         case 2:

                        {
                            double valortotal, numero = 0, quantidade = 50;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Digite um número");
                                valortotal = Convert.ToDouble(Console.ReadLine());

                                numero = numero + valortotal;

                                quantidade = quantidade + 1;

                            } while (quantidade < 2);

                            numero = numero / 2;

                            Console.WriteLine(numero);
                            Console.ReadKey();

                            }

                           break;

                       case 3:
                        {
                            double numero1, numero2, resultado;
                            {
                                Console.Clear();
                                Console.WriteLine("insira o valor da altura do triangulo");
                                numero1 = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("insira o valor da base do triangulo");
                                numero2 = Convert.ToDouble(Console.ReadLine());

                                resultado = numero1 * numero2;

                                Console.WriteLine(resultado);
                                break;
                            }
                          

                            }

                        }

            }
        }
    }
}
