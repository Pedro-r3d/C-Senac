using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraC_
{
    public partial class Calculadora : Form
    {
        
        double valor1 = 0;
        double valor2 = 0;
        string sinal = "";
        bool segundoValor = false;
        bool primeiroValor = false;
        public Calculadora()
        {
            InitializeComponent();
            btnN0.Click += numero_click;
            btnN1.Click += numero_click;
            btnN2.Click += numero_click;
            btnN3.Click += numero_click;
            btnN4.Click += numero_click;
            btnN5.Click += numero_click;
            btnN6.Click += numero_click;
            btnN7.Click += numero_click;
            btnN8.Click += numero_click;
            btnN9.Click += numero_click;
        }
        private void numero_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (segundoValor == false)
            {
                lblValor1.Text += btn.Text;
            }
            if (segundoValor == true)
            {
                lblValor2.Text += btn.Text;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "+";


            sinal = "+";
            segundoValor = true;
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnResultao_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(lblValor2.Text))
            {
                return;
            }

            if (lblValor1.Text.Length == 0)
            {
                lblValor1.Text = "0";
            }
            valor1 = double.Parse(lblValor1.Text);

            valor2 = double.Parse(lblValor2.Text);

            if (sinal == "+")
            {
                lblValor1.Text = (valor1 + valor2).ToString();
            }
            else if (sinal == "-")
            {
                lblValor1.Text = (valor1 - valor2).ToString();
            }
            else if (sinal == "*")
            {
                lblValor1.Text = (valor1 * valor2).ToString();
            }
            else if (sinal == "/")
            {
                lblValor1.Text = (valor1 / valor2).ToString();
              
            }
            

            valor2 = 0;
            lblValor2.Text = "";
            lblSinal.Text = "";
            segundoValor = false;
            
        }

        private void lblSinal_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "-";

            sinal = "-";
            segundoValor = true;

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "*";

            sinal = "*";

            segundoValor = true;

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "/";

            sinal = "/";
            segundoValor = true;

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!segundoValor)
            {
                if (!lblValor1.Text.Contains(","))
                {
                    lblValor1.Text += ",";
                }
            }
            else
            {
                if (!lblValor2.Text.Contains(","))
                {
                    lblValor2.Text += ",";
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            

            if (!segundoValor)
                {
                    if (lblValor1.Text.Length > 0)
                    {
                        lblValor1.Text = lblValor1.Text.Substring(0, lblValor1.Text.Length - 1);
                    }
                }
                else
                {
                    if (lblValor2.Text.Length > 0)
                    {
                        lblValor2.Text = lblValor2.Text.Substring(0, lblValor2.Text.Length - 1);

                    }
                }
            
        }
    }
}
