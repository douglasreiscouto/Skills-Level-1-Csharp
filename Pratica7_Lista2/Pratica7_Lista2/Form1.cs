using Microsoft.VisualBasic;

namespace Pratica7_Lista2
{
    public partial class FormList : Form
    {
        List<Personagem> listaPersonagem = new List<Personagem>();

        public FormList()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Personagem personagem = new Personagem(textBoxNome.Text, (int)numericUpDownLevel.Value);
            listaPersonagem.Add(personagem);

            labelRetorno.Text = textBoxNome.Text + " adicionado(a)!";
            labelContador.Text = listaPersonagem.Count.ToString();
            textBoxNome.Text = "";
            numericUpDownLevel.Value = 10;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            string toda_lista = string.Join(", ", listaPersonagem.Select(a => a.sNomeobj + " Lvl" + a.iLevelobj));
            MessageBox.Show(toda_lista);
        }

        private void buttonLimpa_Click(object sender, EventArgs e)
        {
            listaPersonagem.Clear();

            labelRetorno.Text = "Lista apagada!";
            labelContador.Text = "0";
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            bool bAchouPersonagem; 

            Personagem pesquisa = new Personagem(textBoxNomeResultado.Text, (int) numericUpDownLevelResultado.Value);
            bAchouPersonagem = listaPersonagem.Any(b => b.sNomeobj == pesquisa.sNomeobj && b.iLevelobj == pesquisa.iLevelobj);
            if (bAchouPersonagem == true)
            {
                MessageBox.Show("O personagem já foi cadastrado!");
            }
            else
            {
                MessageBox.Show("O personagem não foi cadastrado");
            }

        }
    }

    public class Personagem
    {
        public string sNomeobj;
        public int iLevelobj;

        public Personagem(string sNomeParamentro, int iLevelParametro)
        {
            sNomeobj = sNomeParamentro;
            iLevelobj = iLevelParametro;
        }
    }
}