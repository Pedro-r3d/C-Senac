using GerenciamentoDeFuncionarios.Banco.Repositories;
using GerenciamentoDeFuncionarios.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt;

namespace GerenciamentoDeFuncionarios.Frms
{
    public partial class FrmCadastroFuncionario : Form
    {

        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private async void btnSalva_Click_1(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;
            string senhaCriptografada = BCrypt.Net.BCrypt.HashPassword(senha, workFactor: 12);
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            char sexo = rbMasculino.Checked ? 'M' : 'F';
            string tipoContrato = rbCLT.Checked ? "CLT" : rbPj.Checked ? "PJ" : "Autonomo";

     
            
            if (rbSimDependente.Checked)
            {
                string nomeDependente = txtNomeDependent.Text;
                DateTime dataDeNascimento = DateTime.Parse(txtNascimento.ToString());
                string parentesco = txtParentesco.Text;
                var dependente = new Dependente(nomeDependente, dataDeNascimento, parentesco);

            }
            else
            {
                return;
            }

            decimal salario = decimal.Parse(txtSalario.Text);

            var dataCadastro = DateTime.Now;


            var funcionario = new Funcionario(senhaCriptografada, nome, email, sexo, tipoContrato, salario, dataCadastro);

            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();


            var contexto = new ValidationContext(funcionario);
            Validator.TryValidateObject(funcionario, contexto, listaDeErros, true);

            if (listaDeErros.Count > 0)
            {
                // adiciona os erros no stringBuilder e exibe na tela
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                }

                lblErros.Text = stringBuilder.ToString();
            }
            else
            {
                await FuncionarioRepository.Adicionar(funcionario);
                this.Close();
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && ((TextBox)sender).Text == string.Empty)
            {
                e.Handled = true;
            }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbCLT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNaoDependente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}