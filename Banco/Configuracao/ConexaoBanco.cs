using Npgsql;
using System.Data;

namespace GerenciamentoDeFuncionarios.Banco.Configuracao
{
    public class ConexaoBanco
    {
        public IDbConnection CriarConexao()
        {
            return new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=admin; Trust Server Certificate=true");
        }


    }
}
