using GerenciamentoDeFuncionarios.Banco.Configuracao;
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
    public partial class FrmTelaPrincipal : Form
    {
        public bool ehAdmin;
        public int _funcionarioLogado;
        public FrmTelaPrincipal(bool ehAdm = true, int funcionarioLogado = 0) //recebe o parametro do loginFuncionario
        {
            InitializeComponent();

            Load += FrmTelaPrincipal_Load;
            ehAdmin = ehAdm; //sei la
            _funcionarioLogado = funcionarioLogado;




        }
        private async void FrmTelaPrincipal_Load(object? sender, EventArgs e)
        {
            //login funcionario, ehAdmin = false, logo não mostra os botões
            btnNovo.Visible = ehAdmin;
            btnExcluir.Visible = ehAdmin;
            await AtualizarTabela();


            if (ehAdmin == false)
            {


                dgvFuncionarios.ClearSelection();

                foreach (DataGridViewRow row in dgvFuncionarios.Rows)
                {
                    if (row.Cells["Id"].Value?.ToString() == _funcionarioLogado.ToString())
                    {
                        row.Selected = true;
                        dgvFuncionarios.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }

            }

        }
        private async void btnNovo_Click(object sender, EventArgs e)
        {
            new FrmCadastroFuncionario().ShowDialog();

            await AtualizarTabela();
        }

        public async Task AtualizarTabela()
        {
            var funcionarios = await FuncionarioRepository.ObterTodos();

            dgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionarios.ToList());


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            string nomeFuncionario = dgvFuncionarios.SelectedRows[0].Cells[0].Value.ToString();

            var retorno = MessageBox.Show($"Tem certeza que deseja excluir o funcionario {nomeFuncionario}?",
                "Exclusão de funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );

            if (retorno == DialogResult.Yes)
            {
                int idFuncionario = (int)dgvFuncionarios.SelectedRows[0].Cells[0].Value;

                await FuncionarioRepository.DeletarPorId(idFuncionario);


                MessageBox.Show($"Funcionário {nomeFuncionario} excluido com sucesso", "Exclusão de funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await AtualizarTabela();
            }

        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            int idFuncionario;

            idFuncionario = _funcionarioLogado;

            if (ehAdmin == false)
            {
                idFuncionario = _funcionarioLogado;
                new FrmAtualizacaoFuncionario(_funcionarioLogado).ShowDialog();
            }
            else
            {
                idFuncionario = (int)dgvFuncionarios.SelectedRows[0].Cells[0].Value;
                new FrmAtualizacaoFuncionario(idFuncionario).ShowDialog();

            }
            await AtualizarTabela();

        }

        private void FrmTelaPrincipal_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvFuncionarios_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dgvFuncionarios_SelectionChanged(object sender, EventArgs e)
        {
            if (!ehAdmin && dgvFuncionarios.Rows.Count > 0)
            {
                dgvFuncionarios.SelectionChanged -= dgvFuncionarios_SelectionChanged;

                foreach (DataGridViewRow row in dgvFuncionarios.Rows)
                {
                    if (row.Cells["Id"].Value?.ToString() == _funcionarioLogado.ToString())
                    {
                        row.Selected = true;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }

                dgvFuncionarios.SelectionChanged += dgvFuncionarios_SelectionChanged;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome;
            string tipoDeContrato = rbCLT.Checked ? "CLT" : rbPJ.Checked ? "PJ" : "Autonomo";


            nome = txtPesquisar.Text.Trim();
            var funcionarios = await FuncionarioRepository.ObterPorNome(nome, tipoDeContrato);

            if(txtPesquisar.Text == "" && !rbPJ.Checked && !rbCLT.Checked && !rbAutonomo.Checked)
            {
                MessageBox.Show("Digite algo para pesquisar");
                return;
            }
            if (funcionarios.Any())
            {
                dgvFuncionarios.DataSource = funcionarios;

            }
            else if (!funcionarios.Any())
            {
                MessageBox.Show("Funcionário não encontrado", "Funcionário não existe", MessageBoxButtons.OK);
                
            }
        }

        private async void btnLimpar_Click(object sender, EventArgs e)
        {
            await AtualizarTabela();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
