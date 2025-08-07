namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {


            //Validação de Campos 
            // Verifica se os campos estão vazios
            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                MessageBox.Show("O campo Número 1 está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero1.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("O campo Número 1 deve conter apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("O campo Número 2 está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("O campo Número 2 deve conter apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero2.Focus();
                return;
            }

          


            // Realiiza a soma dos números e exibe o resultado
            lblResultado.Text = (numero1 + numero2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 - numero2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 * numero2).ToString();

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 / numero2).ToString();
        }
    }
}
