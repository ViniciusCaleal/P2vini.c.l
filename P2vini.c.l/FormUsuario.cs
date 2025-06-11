using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2vini.c.l
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncad_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string senha = txtsenha.Text;
            if (usuario == "ADMIN" && senha == "123")
            {

               FormADM TelaADM = new FormADM();
                TelaADM.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show("erro! acesso negado");
            }
        }
    }
}
        
    

