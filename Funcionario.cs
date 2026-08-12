using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDeFuncionarios.Modelos
{
    public class Funcionario
    {
        public Funcionario(
            
            string senha,
            string nome,        
            string email,
            char sexo,
            string tipoDeContrato,
            decimal salario,
            DateTime dataDeCadastro)
        {
            Senha = senha;
            Nome = nome;
            Email = email;
            Sexo = sexo;
            TipoDeContrato = tipoDeContrato;
            Salario = salario;
            DataDeCadastro = dataDeCadastro;
        }


        public Funcionario(int id, string senha, string nome, string email, char sexo, string tipoDeContrato, decimal salario, DateTime dataDeCadastro, DateTime? dataDeAtualizacao)
        {
            
            Id = id;
            Senha = senha;
            Nome = nome;
            Email = email;
            Sexo = sexo;
            TipoDeContrato = tipoDeContrato;
            Salario = salario;
            DataDeCadastro = dataDeCadastro;
            DataDeAtualizacao = dataDeAtualizacao;
        }

        public Funcionario(int id, string nome, string email, char sexo, string tipoDeContrato, decimal salario, DateTime dataDeCadastro, DateTime? dataDeAtualizacao)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Sexo = sexo;
            TipoDeContrato = tipoDeContrato;
            Salario = salario;
            DataDeCadastro = dataDeCadastro;
            DataDeAtualizacao = dataDeAtualizacao;
        }

        public int Id { get; set; }

        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O campo 'Nome' deve ter entre 3 e 255 caracteres")]
        public string Nome { get; private set; }

        [Required(ErrorMessage = "O campo 'Email' é obrigatório")]
        [EmailAddress(ErrorMessage = "O 'Email' é inválido")]
        public string Email { get; private set; }
        public char Sexo { get; private  set; }
        public string TipoDeContrato { get; private set; }
        public decimal Salario { get; private  set; }
        public DateTime DataDeCadastro { get; private  set; }
        public DateTime? DataDeAtualizacao { get; set; }

     

        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public void SetSexo(char sexo)
        {
            Sexo = sexo;
        }
        public void SetTipoDeContrato(string tipoDeContrato)
        {
            TipoDeContrato = tipoDeContrato;
        }
        public void SetSalario(decimal salario)
        {
            Salario = salario;
        }
        public bool SenhaCorreta(string senhaDigitada)
        {
            return BCrypt.Net.BCrypt.Verify(senhaDigitada, this.Senha);
        }
    }

    public class Dependente(string nomeParentesco, DateTime dataDeNascimento, string parentesco)
    {
        public string NomeParentesco { get; set; } = nomeParentesco;
        public DateTime DataDeNascimento { get; set; } = dataDeNascimento;
        public string Parentesco { get; set; } = parentesco;

    }
}
