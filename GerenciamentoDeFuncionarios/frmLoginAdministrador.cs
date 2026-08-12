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
    public partial class frmLoginAdministrador : Form
    {
        public frmLoginAdministrador()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtSenha.Text == "1234")
            {
                this.Hide();
                new FrmTelaPrincipal().ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos",
                    "Erro ao fazer login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void frmLoginAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
