using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace CadastroDeAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IList<aluno> alunos = new List<aluno>();
           
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Adicionar alunos\n2. Remover aluno\n3. Listar alunos\n4. Sair");
                string opcaoMenu = Console.ReadLine();
                if (opcaoMenu == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Encerrando programa...");
                    break;
                }
                if (opcaoMenu == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Nome do aluno: ");               
                    string NomeAluno = Console.ReadLine();
                    if (string.IsNullOrEmpty(NomeAluno) || NomeAluno.Any(char.IsDigit)){
                        Console.WriteLine("Nome invalido.");
                        Console.WriteLine("Enter para voltar...");
                        Console.ReadLine();
                        continue;
                    }
                    
                    
                    Console.WriteLine("Data de nascimento do aluno(dd/MM/yyyy): ");
                    DateTime DataNascimento = DateTime.MinValue;
                   
                    try
                    {
                        DataNascimento = DateTime.Parse(Console.ReadLine());

                    }
                    catch (Exception e) {
                        Console.WriteLine("Data de nascimento invalida.");
                        Console.WriteLine("Enter para voltar...");
                        Console.ReadLine();
                        continue;
                    }
                    Console.WriteLine("Cpf do aluno: ");                
                    string CpfAluno = Console.ReadLine();

                    if (CpfAluno.Length != 11)
                    {
                        Console.WriteLine("CPF invalido.");
                        Console.WriteLine("Enter para voltar...");
                        Console.ReadLine();
                        continue;   
                    }

                    if(alunos.Any(a => a.Cpf == CpfAluno))
                    {
                        Console.WriteLine("Já existe um aluno cadastrado com esse CPF.");
                        Console.WriteLine("Enter para voltar...");
                        Console.ReadLine();
                        continue;
                    }
                    alunos.Add(new aluno(
                         $"{NomeAluno}",
                         DataNascimento,
                         $"{CpfAluno}"
                     )
                  );
                } //Exibir alunos
                if (opcaoMenu == "3") {
                    Console.Clear();
                    Console.WriteLine("1- Todos alunos");
                    Console.WriteLine("2- Ordenado");
                    string opcaoMenuExibir = Console.ReadLine();
                    if (opcaoMenuExibir == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Alunos:");
                        foreach (aluno aluno in alunos)
                        {

                            Console.WriteLine($"{aluno.ExibirAlunos()}");

                        }
                        Console.WriteLine("\nEnter para voltar...");
                        Console.ReadLine();
                    }
                    if (opcaoMenuExibir == "2"){
                        Console.Clear();
                        Console.WriteLine("1- Por nome\n2- Por idade\n3- Por CPF");
                       string opcaoMenuOrdem= Console.ReadLine();
                        if (opcaoMenuOrdem == "1")
                        {
                            Console.Clear();
                            foreach (aluno aluno in alunos.OrderBy(a => a.Nome))
                            {
                                Console.WriteLine($"{aluno.ExibirAlunos()}");
                            }
                            Console.ReadLine() ;
                        }
                        if (opcaoMenuOrdem == "2") 
                        {
                            Console.Clear();
                            foreach (aluno aluno in alunos.OrderByDescending(a => a.DataNascimento))

                            {
                                Console.WriteLine($"{aluno.ExibirAlunos()}");
                            }
                            Console.ReadLine();
                        }
                        if (opcaoMenuOrdem == "3")
                        {
                            Console.Clear() ;
                            Console.WriteLine("Digite o CPF do aluno: ");
                            string cpfAluno = Console.ReadLine();
                            aluno alunoEncontrado = alunos.FirstOrDefault(a => a.Cpf == cpfAluno);

                            if (alunoEncontrado != null)
                            {
                                Console.WriteLine(alunoEncontrado.ExibirAlunos());
                            }
                            else
                            {
                                Console.WriteLine("Aluno não encontrado. ");
                            }
                           
                            Console.WriteLine("Enter para continuar...");
                            Console.ReadLine();
                        }
                        }
                  
                }
                if (opcaoMenu == "2") {
                    Console.Clear();
                    Console.WriteLine("Qual aluno remover(CPF)?");
                    foreach (aluno aluno in alunos)
                    {
                        Console.WriteLine($"{aluno.ExibirAlunos()}");
                    }
                    string removerAluno = Console.ReadLine();
                    bool encontrado = false;
                    for (int i = alunos.Count - 1; i >= 0; i--)
                    {
                        if (alunos[i].Cpf.Equals(removerAluno))
                        {
                            alunos.RemoveAt(i);
                            encontrado = true;
                            Console.WriteLine("Aluno removido.");
                            Console.WriteLine("Enter para continuar...");
                            Console.ReadLine();
                            break;
                        }                   
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("Aluno não encontrado\n");
                        Console.WriteLine("Enter para continuar...");
                        Console.ReadLine();
                    }

                }


            }
        }
    }
}
