namespace P2vini.c.l
{
    partial class FormUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btncad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de usuario ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 23);
            textBox2.TabIndex = 2;
            // 
            // btncad
            // 
            btncad.Location = new Point(97, 137);
            btncad.Name = "btncad";
            btncad.Size = new Size(84, 28);
            btncad.TabIndex = 3;
            btncad.Text = "Cadastrar";
            btncad.UseVisualStyleBackColor = true;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 190);
            Controls.Add(btncad);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormUsuario";
            Text = "FormUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btncad;
    }
}