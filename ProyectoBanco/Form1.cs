namespace ProyectoBanco
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void btnNvaCuenta_Click(object sender, EventArgs e)
        {
            creaCuenta crear = new creaCuenta();
            crear.Show();
        }

        private void btnChequera_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
        }
    }
}