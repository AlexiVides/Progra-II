namespace FechaHora
{
    public partial class Fechora : Form
    {
        public Fechora()
        {
            InitializeComponent();
        }

        private void Fechora_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();

            lblHora.Text = DateTime.Now.ToLongTimeString(); 
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();

            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}