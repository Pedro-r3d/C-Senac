using Dapper;
using GerenciamentoDeFuncionarios.Banco.Configuracao;
using GerenciamentoDeFuncionarios.Modelos;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.Banco.Repositories
{
    public class FuncionarioRepository
    {


        private static ConexaoBanco ConexaoBanco = new ConexaoBanco();

        public static async Task Adicionar(Funcionario funcionario) 
        {
            // conectar com o banco e inserir funcionario 

           await ConexaoBanco.CriarConexao().QueryAsync(
                @"
                    INSERT INTO Funcionario (Senha, Nome, Email, Salario, Sexo, TipoDeContrato, DataDeCadastro, DataDeAtualizacao)
                    VALUES (@Senha, @Nome, @Email, @Salario, @Sexo, @TipoDeContrato, @DataDeCadastro, @DataDeAtualizacao)
                ",
                funcionario
                );
        }
        public static async Task<IEnumerable<Funcionario>> ObterTodos()
        {
            var funcionarios = await ConexaoBanco.CriarConexao().QueryAsync<Funcionario>(
                @"
                    SELECT                      
                        Id,            
                        Nome,
                        Email,
                        Sexo,
                        TipoDeContrato,
                        Salario,
                        DataDeCadastro,
                        DataDeAtualizacao
                    FROM 
                        Funcionario
                "
                );

            return funcionarios;
        }
        public static async Task DeletarPorId(int idFuncionario)
        {
            await ConexaoBanco.CriarConexao().QueryAsync(
            @"
                    DELETE  FROM Funcionario        
                    WHERE Id = @IdFuncionario
                ",
                new
                {
                    IdFuncionario = idFuncionario
                }
                 );      
        }

        public static  async Task EditarFuncionario(Funcionario funcionario)
        {

            await ConexaoBanco.CriarConexao().QueryAsync(

   @"
                    UPDATE Funcionario 
                    SET Nome = @Nome,
                        Email = @Email,
                        Salario = @Salario,
                        Sexo = @Sexo,
                        TipoDeContrato = @TipoDeContrato,                     
                        DataDeAtualizacao = @DataDeAtualizacao
                    WHERE Id = @Id
                ",

                    funcionario


               );              
        }

        public static async Task<Funcionario> ObterPorId(int idFuncionario)
        {

            var funcionario = await ConexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<Funcionario>(
               @"
                    SELECT 
                        Id,
                        Senha,
                        Nome,
                        Email,
                        Sexo,
                        TipoDeContrato,
                        Salario,
                        DataDeCadastro,
                        DataDeAtualizacao
                    FROM 
                        Funcionario
                    WHERE Id = @IdFuncionario
                ",

               new
               {
                   IdFuncionario = idFuncionario
               }

               ); return funcionario;
        }

             public static async Task<List<Funcionario>> ObterPorNome(string nomeEmail, string tipoDeContrato)
        {

            var funcionario = await ConexaoBanco.CriarConexao().QueryAsync<Funcionario>(
               @"
                    SELECT 
                        Id,
                        Senha,
                        Nome,
                        Email,
                        Sexo,
                        TipoDeContrato,
                        Salario,
                        DataDeCadastro,
                        DataDeAtualizacao
                    FROM 
                        Funcionario
                    WHERE (Nome LIKE @Nome OR Email LIKE @Email) AND TipoDeContrato = @TipoDeContrato
                ",

               new
               {
                   Nome = "%" + nomeEmail + "%",
                   Email = "%" + nomeEmail + "%",
                   TipoDeContrato = tipoDeContrato
               });
                return funcionario.ToList();

        }

     
    }
}
