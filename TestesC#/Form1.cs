namespace TestesC_
{
    public partial class Form1 : Form
    {
        int cliques = 0;
        int valorPorClique = 1;
        public Form1()
        {
            InitializeComponent();
            btnX2.Hide();
          
        } 

        
        private void btnCookie_Click(object sender, EventArgs e)
        {
            cliques += valorPorClique;
            label1.Text = cliques.ToString();

            if (cliques == 50)
            {
                btnX2.Show();
            }
        }
        private void btnX2_Click(object sender, EventArgs e)
        {
            valorPorClique = 2;
        }

        private void btnX1_Click(object sender, EventArgs e)
        {
            valorPorClique = 1;
        }

        private void btnRedefenir_Click(object sender, EventArgs e)
        {
            cliques = 0;
            label1.Text = cliques.ToString();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            label3.Text += cliques.ToString() + Environment.NewLine;
        }

        private void btnResetSave_Click(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }

}
