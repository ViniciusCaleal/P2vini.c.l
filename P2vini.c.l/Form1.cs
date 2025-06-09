namespace P2vini.c.l
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string senha = txtsenha.Text;
            if(usuario == "ADMIN" && senha == "123")
            {

                formPRINC principal = new formPRINC();
                principal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("acesso negado");
            }
        }
    }
}
        
    

