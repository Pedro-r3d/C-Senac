using Microsoft.VisualBasic.Logging;
using System.Drawing.Text;

namespace CalculadoraC_
{
    public partial class Logar : Form
    {
        public Logar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            if (usuario == "Pedro" && senha == "1234")
            {
                this.Hide();
                new Calculadora().ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Senha ou usúario incorreto.", "Login não realizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btnSair_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
