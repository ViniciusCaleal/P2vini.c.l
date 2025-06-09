namespace P2vini.c.l
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
            btnentrar = new Button();
            txtusuario = new TextBox();
            txtsenha = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnentrar
            // 
            btnentrar.Location = new Point(12, 132);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(223, 38);
            btnentrar.TabIndex = 0;
            btnentrar.Text = "entrar";
            btnentrar.UseVisualStyleBackColor = true;
            btnentrar.Click += btnentrar_Click;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(12, 50);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(223, 23);
            txtusuario.TabIndex = 1;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(12, 91);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(223, 23);
            txtsenha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 19);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 3;
            label1.Text = "TELA DE LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 193);
            Controls.Add(label1);
            Controls.Add(txtsenha);
            Controls.Add(txtusuario);
            Controls.Add(btnentrar);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnentrar;
        private TextBox txtusuario;
        private TextBox txtsenha;
        private Label label1;
    }
}
