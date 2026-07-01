using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_C_
{
    internal abstract class Funcionario
    {
       
        public string Nome { get; protected set; }
        public string Cpf { get; protected set; }
        public string Tipo { get; set; }

        protected Funcionario(string nome, string cpf, string tipo)
        {
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
        }

        public abstract string ExibirDados();
      
        public abstract double CalcularSalario();
    }
     
        internal class FuncionarioClt : Funcionario
        {
           public double SalarioBase { get; set;}

            public FuncionarioClt(string nome,string cpf,double salarioBase) : base(nome, cpf, "CLT")
        {
            SalarioBase = salarioBase;
        }


            public override  string ExibirDados()
            {
            return $"Funcionário:{Nome}\n CPF: {Cpf}\n Tipo: {Tipo}\n Salario: {SalarioBase}";
             
            }
        public override double CalcularSalario()
        { 
         return SalarioBase;
        }
        }

        internal class FuncionarioEstagiario : Funcionario
        {
            public double BolsaAuxilio { get; set; }
            public double ValeTransporte { get; set; }

        public FuncionarioEstagiario(string nome, string cpf, double bolsaAuxilio, double valeTransporte) : base(nome, cpf, "Estagiario")
        {
            BolsaAuxilio = bolsaAuxilio;
            ValeTransporte = valeTransporte;
        }

        public override string ExibirDados()
        {
            return $"Funcionário:{Nome}\n CPF: {Cpf}\n Tipo: {Tipo}\n Salario: {CalcularSalario().ToString()}";

        }

        public override double CalcularSalario()
        {
          
            return BolsaAuxilio + ValeTransporte;
        }

        }

        internal class FuncionarioTerceirizado : Funcionario
        {
            public double HorasTrabalhadas {  get; set; }
            public double ValorHora { get; set; }
        public FuncionarioTerceirizado(string nome, string cpf, double horasTrabalhadas, double valorHora) : base(nome,cpf, "Terceirizado")
        {
            HorasTrabalhadas = horasTrabalhadas;
            ValorHora = valorHora;
        }
        public override string ExibirDados()
        {
            return ($"Funcionário:{Nome}\n CPF: {Cpf}\n Tipo: {Tipo}\n Salario: {CalcularSalario().ToString()}");
        }

        public override double CalcularSalario()
        {
            return HorasTrabalhadas * ValorHora;
        }
           
        }
    }

