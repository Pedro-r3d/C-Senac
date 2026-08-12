using BCrypt;
using BCrypt.Net;
using GerenciamentoDeFuncionarios.Banco.Repositories;
using GerenciamentoDeFuncionarios.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeFuncionarios.Frms
{
    public partial class frmLoginFuncionario : Form
    {
        private int idFuncionario;
        private string Senha;

        public frmLoginFuncionario()
        {
            InitializeComponent();
            Load += frmLoginFuncionario_Load;
            idFuncionario += idFuncionario;
        }

        public async void btnEntrar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtFuncionario.Text, out idFuncionario))//confirma se oque escrevi é inteiro e retorna para idfuncionario
            {
                MessageBox.Show("Por favor, digite um ID numérico válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
                var funcionario = await FuncionarioRepository.ObterPorId(idFuncionario);
            if (funcionario == null)
            {
                MessageBox.Show("Usúario não encontrado.", "Não encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                if (funcionario.SenhaCorreta(txtSenhaLogin.Text)) {              
             
                    this.Hide();
                    new FrmTelaPrincipal(ehAdm: false, funcionarioLogado: idFuncionario).ShowDialog();//ehAdm define se é um funcionario ou admin na tela principal
                    this.Show();
                
                    }
            else
            {
                MessageBox.Show("Senha ou matricula incorreta.", "Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
         
        

        public async void frmLoginFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
