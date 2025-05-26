namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        Boolean bButtonAdicao = false, bButtonMultiplicacao = false,
                bButtonDivisao = false, bButtonSubtracao = false;

        List<float> valores = new List<float>();

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void buttonSete_Click(object sender, EventArgs e)
        {
            valores.Add(float.Parse(buttonSete.Text));
            textBoxResultado.Text += buttonSete.Text;
        }

        private void buttonOito_Click(object sender, EventArgs e)
        {
            valores.Add(float.Parse(buttonOito.Text));
            textBoxResultado.Text += buttonOito.Text;
        }

        private void buttonNove_Click(object sender, EventArgs e)
        {
            valores.Add(float.Parse(buttonNove.Text));
            textBoxResultado.Text += buttonNove.Text;
        }

        private void buttonQuatro_Click(object sender, EventArgs e)
        {
            valores.Add(float.Parse(buttonQuatro.Text));
            textBoxResultado.Text += buttonQuatro.Text;
        }

        private void buttonCinco_Click(object sender, EventArgs e)
        {
            valores.Add(float.Parse(buttonCinco.Text));
            textBoxResultado.Text += buttonCinco.Text;
        }

        private void buttonSeis_Click(object sender, EventArgs e)
        {
            valores.Add(float.Parse(buttonSeis.Text));
            textBoxResultado.Text += buttonSeis.Text;
        }

        private void buttonUm_Click(object sender, EventArgs e)
        {
            valores.Add(float.Parse(buttonUm.Text));
            textBoxResultado.Text += buttonUm.Text;
        }

        private void buttonDois_Click(object sender, EventArgs e)
        {
            valores.Add(float.Parse(buttonDois.Text));
            textBoxResultado.Text += buttonDois.Text;
        }

        private void buttonTres_Click(object sender, EventArgs e)
        {
            valores.Add(float.Parse(buttonTres.Text));
            textBoxResultado.Text += buttonTres.Text;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            valores.Add(float.Parse(buttonZero.Text));
            textBoxResultado.Text += buttonZero.Text;
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += buttonDivisao.Text;
            bButtonDivisao = true;
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += buttonMultiplicacao.Text;
            bButtonMultiplicacao = true;
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += buttonSubtracao.Text;
            bButtonSubtracao = true;
        }

        private void buttonAdicao_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += buttonAdicao.Text;
            bButtonAdicao = true;
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            if (bButtonAdicao == true)
            {
                textBoxResultado.Text = valores.Sum().ToString();
                bButtonAdicao = false;
            }
            else
            {
                bButtonAdicao = false;
            }

            if (bButtonSubtracao == true)
            {
                textBoxResultado.Text = valores.
            }
        }
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = string.Empty;
        }
    }
}
