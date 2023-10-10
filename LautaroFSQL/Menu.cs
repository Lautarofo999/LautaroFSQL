namespace LautaroFSQL
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tarjeta_de_Credito tarjeta_De_Credito = new Tarjeta_de_Credito();
            tarjeta_De_Credito.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cuenta_Bancaria cuenta_Bancaria = new Cuenta_Bancaria();
            cuenta_Bancaria.Show();
            this.Hide();
        }
    }
}