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
                labelDescricaoStatus.Text = "O personagem informando já foi cadastrado.";

                textBoxPesquisaNick = textBoxCadastroNick;
            }
            else
            {
                personagem.Add(textBoxCadastroNick.Text, textBoxCadastroDescricao.Text);
                labelDescricaoStatus.Text = "Personagem " + textBoxCadastroNick.Text + " foi cadastrado com sucesso.";

                textBoxCadastroNick.Text = "";
                textBoxCadastroDescricao.Text = "";
            }

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            bool bContemPersonagem;

            bContemPersonagem = personagem.ContainsKey(textBoxCadastroNick.Text);

            if (bContemPersonagem == true)
            {
                personagem.Remove(textBoxCadastroNick.Text);

                labelDescricaoStatus.Text = "Personagem removido com sucesso.";
            }
            else
            {
                MessageBox.Show("O personagem informado não foi cadastrado.", "ATENCÃO", MessageBoxButtons.OK);
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            bool bContemPersonagem;


            bContemPersonagem = personagem.ContainsKey(textBoxPesquisaNick.Text);

            if (bContemPersonagem == true)
            {
                labelDescricaoStatus.Text = "Pesquisa realizada com sucesso.";
                //labelPesquisaDescricao.Text = personagem.[];

            }
            else
            {
                MessageBox.Show("O personagem informado não foi cadastrado.\nDeseja cadastra-lo?", "ATENÇÃO", MessageBoxButtons.YesNo);
            }
        }
    }
}
