namespace TestesC_
{
    partial class Form1
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
            btnCookie = new Button();
            label1 = new Label();
            btnX2 = new Button();
            btnX1 = new Button();
            btnRedefenir = new Button();
            btnSalvar = new Button();
            label2 = new Label();
            label3 = new Label();
            btnResetSave = new Button();
            SuspendLayout();
            // 
            // btnCookie
            // 
            btnCookie.Font = new Font("Microsoft Sans Serif", 15F);
            btnCookie.Location = new Point(308, 241);
            btnCookie.Margin = new Padding(3, 2, 3, 2);
            btnCookie.Name = "btnCookie";
            btnCookie.Size = new Size(213, 68);
            btnCookie.TabIndex = 0;
            btnCookie.Text = "CliqueAqui";
            btnCookie.UseVisualStyleBackColor = true;
            btnCookie.Click += btnCookie_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 191);
            label1.Name = "label1";
            label1.Size = new Size(22, 25);
            label1.TabIndex = 1;
            label1.Text = "0";
            // 
            // btnX2
            // 
            btnX2.Location = new Point(552, 241);
            btnX2.Name = "btnX2";
            btnX2.Size = new Size(160, 59);
            btnX2.TabIndex = 2;
            btnX2.Text = "X2";
            btnX2.UseVisualStyleBackColor = true;
            btnX2.Click += btnX2_Click;
            // 
            // btnX1
            // 
            btnX1.Location = new Point(552, 306);
            btnX1.Name = "btnX1";
            btnX1.Size = new Size(160, 64);
            btnX1.TabIndex = 3;
            btnX1.Text = "Multiplicador padrão";
            btnX1.UseVisualStyleBackColor = true;
            btnX1.Click += btnX1_Click;
            // 
            // btnRedefenir
            // 
            btnRedefenir.Location = new Point(354, 361);
            btnRedefenir.Name = "btnRedefenir";
            btnRedefenir.Size = new Size(112, 34);
            btnRedefenir.TabIndex = 4;
            btnRedefenir.Text = "Redefenir";
            btnRedefenir.UseVisualStyleBackColor = true;
            btnRedefenir.Click += btnRedefenir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(354, 321);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 207);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 6;
            label2.Text = "Salvos";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 241);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 7;
            // 
            // btnResetSave
            // 
            btnResetSave.Location = new Point(42, 170);
            btnResetSave.Name = "btnResetSave";
            btnResetSave.Size = new Size(131, 34);
            btnResetSave.TabIndex = 8;
            btnResetSave.Text = "ResetarSalvos";
            btnResetSave.UseVisualStyleBackColor = true;
            btnResetSave.Click += btnResetSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnResetSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSalvar);
            Controls.Add(btnRedefenir);
            Controls.Add(btnX1);
            Controls.Add(btnX2);
            Controls.Add(label1);
            Controls.Add(btnCookie);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCookie;
        private Label label1;
        private Button btnX2;
        private Button btnX1;
        private Button btnRedefenir;
        private Button btnSalvar;
        private Label label2;
        private Label label3;
        private Button btnResetSave;
    }
}
