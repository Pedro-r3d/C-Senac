using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;

namespace SistemaDeLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Pedro" && txtSenha.Text == "1234")
            {
                this.Hide(); 
                string nome = txtNome.Text;
                new MenuPrincipal(nome).ShowDialog();
                this.Show();
            }

            else
            {
                MessageBox.Show("Login incorreto", "Login não realizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
