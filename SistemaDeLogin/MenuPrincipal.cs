using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeLogin
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(string nomeUsuario)
        {
            InitializeComponent();
            lblNomeUsuario.Text = $"Bem vindo {nomeUsuario}";            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
