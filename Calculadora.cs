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


            //Valida��o de Campos 
            // Verifica se os campos est�o vazios
            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                MessageBox.Show("O campo N�mero 1 est� vazio!", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("O campo N�mero 2 est� vazio!", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero2.Focus();
                return;
            }

            // Tenta converter os textos para n�meros (evita letras)
            double num1, num2;

            bool conversao1 = double.TryParse(txtNumero1.Text, out num1);
            bool conversao2 = double.TryParse(txtNumero2.Text, out num2);

            if (!conversao1)
            {
                MessageBox.Show("O campo N�mero 1 deve conter apenas n�meros!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero1.Focus();
                return;
            }

            if (!conversao2)
            {
                MessageBox.Show("O campo N�mero 2 deve conter apenas n�meros!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero2.Focus();
                return;
            }





            // Verifica se os campos de entrada est�o preenchidos
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            // Realiiza a soma dos n�meros e exibe o resultado
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
