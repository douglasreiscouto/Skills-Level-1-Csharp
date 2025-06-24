namespace Projeto01
{
    public partial class FormFilaAtendimento : Form
    {
        Queue<String> filaAtendimento;

        public FormFilaAtendimento()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            labelProximoFilaNome.Text = "";
            labelEmAtendimentoNome.Text = "";

            filaAtendimento = new Queue<String>();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            filaAtendimento.Enqueue(textBoxNome.Text);

            labelStatusDescricao.Text = "Cadastro realizado com sucesso.";
            labelContadorFila.Text = filaAtendimento.Count.ToString();
        }

        private void buttonChamarProximo_Click(object sender, EventArgs e)
        {
            labelEmAtendimentoNome.Text = filaAtendimento.Dequeue();

            labelStatusDescricao.Text = "Chamada realizada com sucesso.";
        }

        private void buttonVerProximo_Click(object sender, EventArgs e)
        {
            labelProximoFilaNome.Text = filaAtendimento.Peek();

            labelStatusDescricao.Text = "Consulta a fila realizada com sucesso.";
        }
    }
}
