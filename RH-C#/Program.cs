using System.Reflection.Metadata.Ecma335;

namespace RH_C_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            while (true)
            {
                Console.WriteLine("---- MENU FUNCIONARIOS ----\n1- Cadastrar funcionário\n2- Listar funcionários\n3- Sair\n");
                string OpcaoMenu = Console.ReadLine();
               
                if (OpcaoMenu == "1")
                {
                    Console.Clear();

                    Console.WriteLine("\n(1) CLT\n(2) Estagiario\n(3) Terceirizado ");
                   string NumeroInput = Console.ReadLine();

                    if (NumeroInput == "1")
                    {
                        try
                        {
                            Console.WriteLine("Nome do funcionário: ");
                            string inputNome = Console.ReadLine();
                            Console.WriteLine("Cpf do funcionário: ");
                            string inputCpf = Console.ReadLine();
                            Console.WriteLine("Salario do base funcionário");
                            double inputSalario = double.Parse(Console.ReadLine());




                            funcionarios.Add(new FuncionarioClt(
                                $"{inputNome}",
                                $"{inputCpf}",
                                inputSalario
                                )
                            );
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro em alguma das informações, Funcionário não adicionado. Tente novamente.");
                            continue;
                        }
                    }
                    if (NumeroInput == "2")
                    {
                        try
                        {
                            Console.WriteLine("Nome do funcionário: ");
                            string inputNome = Console.ReadLine();
                            Console.WriteLine("Cpf do funcionário: ");
                            string inputCpf = Console.ReadLine();
                            Console.WriteLine("Valor da bolsa auxilio do funcionário");
                            double inputBolsa = double.Parse(Console.ReadLine());
                            Console.WriteLine("Valor do vale de transporte do funcionário");
                            double inputVale = double.Parse(Console.ReadLine());
                            funcionarios.Add(new FuncionarioEstagiario(
                                  $"{inputNome}",
                                  $"{inputCpf}",
                                  inputBolsa,
                                  inputVale
                                  ));
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro em alguma das informações, Funcionário não adicionado. Tente novamente.");
                            continue;
                        }

                    }
                    if (NumeroInput == "3")
                    {
                        try
                        {
                            Console.WriteLine("Nome do funcionário: ");
                            string inputNome = Console.ReadLine();
                            Console.WriteLine("Cpf do funcionário: ");
                            string inputCpf = Console.ReadLine();
                            Console.WriteLine("Horas trabalhadas do funcionário");
                            double inputHoras = double.Parse(Console.ReadLine());
                            Console.WriteLine("Valor das horas trabalhadas do funcionário");
                            double inputValorHora = double.Parse(Console.ReadLine());
                            funcionarios.Add(new FuncionarioTerceirizado(
                                 $"{inputNome}",
                                 $"{inputCpf}",
                                 inputHoras,
                                 inputValorHora
                                 ));
                        }
                        catch(Exception e) {
                            Console.WriteLine("Erro em alguma das informações, Funcionário não adicionado. Tente novamente.");
                            continue;
                        }
                    }
                }
                Console.Clear();
                if (OpcaoMenu == "2")
                {
                    Console.Clear();
                    
                    foreach (Funcionario funcionario in funcionarios)
                    { Console.WriteLine($"{funcionario.ExibirDados()}\n"); }
                    
                }
               

                if (OpcaoMenu == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Encerrando programa...");

                    break;
                }
            }

        }
    }
    }

