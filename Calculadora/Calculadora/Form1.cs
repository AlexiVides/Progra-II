namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textb1.Text);
            double b = Convert.ToDouble(textb2.Text);

            double resultado = 0.0;

            if(rdbSumar.Checked == true)
            {
                resultado = a + b;
            }

            if(rdbRestar.Checked == true)
            {
                resultado = b - a;
            }

            if (rdbMultiplicar.Checked == true)
            {
                resultado = b * a;
            }

            if (rdbDividir.Checked == true)
            {
                resultado = b / a;
            }

            lblResulatado.Text = resultado.ToString();

            
            textb1.Clear();
            textb2.Clear();
        }
    }
}