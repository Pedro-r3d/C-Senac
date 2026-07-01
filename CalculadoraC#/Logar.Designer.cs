namespace CalculadoraC_
{
    partial class Logar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtSenha = new TextBox();
            btnLogar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(132, 41);
            label1.TabIndex = 0;
            label1.Text = "Ususário";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 64);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(99, 41);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 153);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(150, 31);
            txtSenha.TabIndex = 3;
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(12, 213);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(112, 34);
            btnLogar.TabIndex = 4;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(12, 262);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(112, 34);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += this.btnSair_Click;
            // 
            // Logar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnLogar);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "Logar";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtSenha;
        private Button btnLogar;
        private Button btnSair;
    }
}
