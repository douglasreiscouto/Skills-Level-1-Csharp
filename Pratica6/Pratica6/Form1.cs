namespace Pratica6
{
    public partial class Form1 : Form
    {
        //contrutor da classe
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        //evento de click do botao calcular
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            float[] notas = new float[8];
            notas[0] = float.Parse(textBoxNota1.Text);
            notas[1] = float.Parse(textBoxNota2.Text);
            notas[2] = float.Parse(textBoxNota3.Text);
            notas[3] = float.Parse(textBoxNota4.Text);
            notas[4] = float.Parse(textBoxNota5.Text);
            notas[5] = float.Parse(textBoxNota6.Text);
            notas[6] = float.Parse(textBoxNota7.Text);
            notas[7] = float.Parse(textBoxNota8.Text);

            float resultado = notas[0] + notas[1] + notas[2] + notas[3] + notas[4] + notas[5] + notas[6] + notas[7];
            resultado = resultado / 8.0f;

            labelResultado.Text = resultado.ToString();

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }
}
