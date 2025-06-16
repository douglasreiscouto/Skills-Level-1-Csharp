namespace Pratica8_Dicionario
{
    public partial class FormDicionario : Form
    {
        Dictionary<string, string> personagem;

        public FormDicionario()
        {
            InitializeComponent();

            personagem = new Dictionary<string, string>();

            labelDescricaoStatus.Text = "Aguardando inicio...";
            labelPesquisaDescricao.Text = "";
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            bool bContemPersonagem;

            bContemPersonagem = personagem.ContainsKey(textBoxCadastroNick.Text);

            if (bContemPersonagem == true)
            {
                labelDescricaoStatus.Text = "O personagem informando já foi cadastrado!";

                textBoxPesquisaNick = textBoxCadastroNick;
            }
            else
            {
                personagem.Add(textBoxCadastroNick.Text, textBoxCadastroDescricao.Text);
                labelDescricaoStatus.Text = "Personagem " + textBoxCadastroNick.Text + " foi cadastrado com sucesso!";

                textBoxCadastroNick.Text = "";
                textBoxCadastroDescricao.Text = "";
            }

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
