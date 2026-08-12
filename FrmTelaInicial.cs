using GerenciamentoDeFuncionarios.Frms;
using GerenciamentoDeFuncionarios.Modelos;

namespace GerenciamentoDeFuncionarios
{
    public partial class FrmTelaInicial : Form
    {

        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        private void FrmTelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnSouAdministrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLoginAdministrador().ShowDialog();

            this.Show();
        }

        private void btnSouFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLoginFuncionario().ShowDialog();
            this.Show();
        }
    }
}
