namespace P2vini.c.l
{
    partial class formPRINC
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
            btncliente = new Button();
            btnproduto = new Button();
            btnpedidos = new Button();
            btnusuario = new Button();
            SuspendLayout();
            // 
            // btncliente
            // 
            btncliente.Location = new Point(6, 10);
            btncliente.Name = "btncliente";
            btncliente.Size = new Size(145, 39);
            btncliente.TabIndex = 0;
            btncliente.Text = "Cadastro de Clientes";
            btncliente.UseVisualStyleBackColor = true;
            btncliente.Click += button1_Click;
            // 
            // btnproduto
            // 
            btnproduto.Location = new Point(171, 10);
            btnproduto.Name = "btnproduto";
            btnproduto.Size = new Size(153, 39);
            btnproduto.TabIndex = 1;
            btnproduto.Text = "Cadastro de Produtos";
            btnproduto.UseVisualStyleBackColor = true;
            btnproduto.Click += btnproduto_Click;
            // 
            // btnpedidos
            // 
            btnpedidos.Location = new Point(171, 66);
            btnpedidos.Name = "btnpedidos";
            btnpedidos.Size = new Size(153, 44);
            btnpedidos.TabIndex = 2;
            btnpedidos.Text = "Cadastro de Pedidos";
            btnpedidos.UseVisualStyleBackColor = true;
            btnpedidos.Click += btnpedidos_Click;
            // 
            // btnusuario
            // 
            btnusuario.Location = new Point(6, 66);
            btnusuario.Name = "btnusuario";
            btnusuario.Size = new Size(145, 44);
            btnusuario.TabIndex = 3;
            btnusuario.Text = "Cadastro de Usuários";
            btnusuario.UseVisualStyleBackColor = true;
            btnusuario.Click += btnusuario_Click;
            // 
            // formPRINC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 133);
            Controls.Add(btnusuario);
            Controls.Add(btnpedidos);
            Controls.Add(btnproduto);
            Controls.Add(btncliente);
            Name = "formPRINC";
            Text = "formPRINC";
            Load += formPRINC_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btncliente;
        private Button btnproduto;
        private Button btnpedidos;
        private Button btnusuario;
    }
}