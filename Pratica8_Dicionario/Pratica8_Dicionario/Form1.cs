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

            labelDescricaoStatus.Text = "Aguardando inicio...";
            labelPesquisaDescricao.Text = "";
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            bool bContemPersonagem;

            bContemPersonagem = personagem.ContainsKey(textBoxCadastroNick.Text);

            if (bContemPersonagem == true)
            {
                labelDescricaoStatus.Text = "O personagem informando j� foi cadastrado.";

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
                MessageBox.Show("O personagem informado n�o foi cadastrado.", "ATENC�O", MessageBoxButtons.OK);
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
                DialogResult resultado = MessageBox.Show("O personagem informado n�o foi encotrado.\nDeseja cadastra-lo?", "ATEN��O", MessageBoxButtons.YesNo);
                labelDescricaoStatus.Text = "O personagem informado n�o foi encontrado.";

                if (resultado == DialogResult.Yes)
                {
                    textBoxCadastroNick.Text = textBoxPesquisaNick.Text;
                }
                else
                {
                    MessageBox.Show("Ok, retorne a tela primcipal", "ATEN��O", MessageBoxButtons.OK);
                    labelDescricaoStatus.Text = "Aguardando cadastro...";
                }
            }
        }
    }
}
