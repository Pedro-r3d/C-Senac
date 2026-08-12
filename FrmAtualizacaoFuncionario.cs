using GerenciamentoDeFuncionarios.Banco.Repositories;
using GerenciamentoDeFuncionarios.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeFuncionarios.Frms
{
    public partial class FrmAtualizacaoFuncionario : Form
    {

        private int idFuncionario;

        public FrmAtualizacaoFuncionario(int idFuncionario)
        {
            InitializeComponent();
            this.idFuncionario = idFuncionario;
            Load += FrmAtualizacaoFuncionario_Load;

        }

        private async void FrmAtualizacaoFuncionario_Load(object? sender, EventArgs e)
        {
            var funcionario = await FuncionarioRepository.ObterPorId(idFuncionario);

            txtNomeEditar.Text = funcionario.Nome;
            txtEmail.Text = funcionario.Email;
            txtSalario.Text = funcionario.Salario.ToString();

            switch (funcionario.Sexo)
            {
                case 'M':
                    rbMasculino.Checked = true;
                    break;
                case 'F':
                    rbFeminino.Checked = true;
                    break;
            }
            switch (funcionario.TipoDeContrato)
            {
                case "CLT":
                    rbCLT.Checked = true;
                    break;
                case "PJ":
                    rbPJ.Checked = true;
                    break;
                case "Autonomo":
                    rbAutonomo.Checked = true;
                    break;
            }
            groupBox2.Text = funcionario.TipoDeContrato;
            funcionario.DataDeAtualizacao = DateTime.Now;
        }

        private async void btnSalvarEditar_Click(object sender, EventArgs e)
        {
           var funcionario = await FuncionarioRepository.ObterPorId(idFuncionario);
;
            funcionario.SetNome(txtNomeEditar.Text);
            funcionario.SetEmail(txtEmail.Text);
            funcionario.SetSalario(decimal.Parse(txtSalario.Text));
            funcionario.SetTipoDeContrato(rbCLT.Checked ? "CLT" : rbPJ.Checked ? "PJ" : "Autonomo");
            funcionario.SetSexo(rbMasculino.Checked ? 'M' : 'F');
                
            funcionario.DataDeAtualizacao = DateTime.Now;

            await FuncionarioRepository.EditarFuncionario(funcionario);

            MessageBox.Show($"Funcionário editado com sucesso", "Funcionário editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
