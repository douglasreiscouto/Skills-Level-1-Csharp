using System.Diagnostics.SymbolStore;

namespace Pratica8_Dicionario
{
    public partial class FormDicionario : Form
    {
        Dictionary<string, string> personagem;

        public FormDicionario()
        {
            InitializeComponent();

            personagem = new Dictionary<string, string>();

            labelPesquisaDescricao.Text = "";
            labelQuatidadeCadastro.Text = "";
            labelDescricaoStatus.Text = "Aguardando inicio...";
            labelQuatidadeCadastro.Text = personagem.Count.ToString();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            bool bContemPersonagem;

            bContemPersonagem = personagem.ContainsKey(textBoxCadastroNick.Text);

            if (bContemPersonagem == true)
            {
                labelDescricaoStatus.Text = "O personagem informando já foi cadastrado.";

                textBoxPesquisaNick.Text = textBoxCadastroNick.Text;
            }
            else
            {
                if (textBoxCadastroNick.Text == null || textBoxCadastroNick.Text == "")
                {
                    MessageBox.Show("Não é possível cadastra um personagem com nick em branco.", "ATENÇÃO", MessageBoxButtons.OK);
                }
                else
                {
                    personagem.Add(textBoxCadastroNick.Text, textBoxCadastroDescricao.Text);
                    labelDescricaoStatus.Text = "Personagem " + textBoxCadastroNick.Text + " foi cadastrado com sucesso.";

                    textBoxCadastroNick.Text = "";
                    textBoxCadastroDescricao.Text = "";
                    labelQuatidadeCadastro.Text = personagem.Count.ToString();
                }
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            bool bContemPersonagem;
            int iQuantidadeCadastro;

            bContemPersonagem = personagem.ContainsKey(textBoxCadastroNick.Text);

            if (bContemPersonagem == true)
            {
                iQuantidadeCadastro = personagem.Count();
                iQuantidadeCadastro--;
                personagem.Remove(textBoxCadastroNick.Text);

                labelQuatidadeCadastro.Text = iQuantidadeCadastro.ToString();

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
                labelPesquisaDescricao.Text = personagem[textBoxPesquisaNick.Text];

                labelDescricaoStatus.Text = "Pesquisa realizada com sucesso.";
            }
            else
            {
                DialogResult resultado = MessageBox.Show("O personagem informado não foi encotrado.\nDeseja cadastra-lo?", "ATENÇÃO", MessageBoxButtons.YesNo);
                labelDescricaoStatus.Text = "O personagem informado não foi encontrado.";

                if (resultado == DialogResult.Yes)
                {
                    textBoxCadastroNick.Text = textBoxPesquisaNick.Text;
                }
                else
                {
                    MessageBox.Show("Ok, retorne a tela primcipal", "ATENÇÃO", MessageBoxButtons.OK);
                    labelDescricaoStatus.Text = "Aguardando cadastro...";
                }
            }
        }
    }
}
