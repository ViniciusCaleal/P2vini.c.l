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
            txtusuario = new TextBox();
            txtsenha = new TextBox();
            btncad = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // txtusuario
            // 
            txtusuario.Location = new Point(12, 46);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(254, 23);
            txtusuario.TabIndex = 1;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(12, 87);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(254, 23);
            txtsenha.TabIndex = 2;
            // 
            // btncad
            // 
            btncad.Location = new Point(97, 137);
            btncad.Name = "btncad";
            btncad.Size = new Size(84, 28);
            btncad.TabIndex = 3;
            btncad.Text = "Cadastrar";
            btncad.UseVisualStyleBackColor = true;
            btncad.Click += btncad_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 25);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 25);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // button1
            // 
            button1.Location = new Point(388, 196);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(506, 196);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(389, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(229, 134);
            dataGridView1.TabIndex = 9;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 300);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btncad);
            Controls.Add(txtsenha);
            Controls.Add(txtusuario);
            Controls.Add(label1);
            Name = "FormUsuario";
            Text = "FormUsuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtusuario;
        private TextBox txtsenha;
        private Button btncad;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
    }
}