namespace Pratica7_Lista2
{
    public partial class FormList : Form
    {
        List<Personagem> persongem = new List<Personagem>();

        public FormList()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Personagem personagem = new Personagem(textBoxNome.Text, (int) numericUpDownLevel.Value);
            persongem.Add(personagem);

            labelRetorno.Text = textBoxNome.Text + " adicionado(a)!";
            labelContador.Text = persongem.Count.ToString();
            textBoxNome.Text = "";
            numericUpDownLevel.Value = 10;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            string toda_lista = string.Join(", ", persongem.Select(a=> a.sNomeobj + "Lvl" + a.iLevelobj));
            MessageBox.Show(toda_lista);
        }

        private void buttonLimpa_Click(object sender, EventArgs e)
        {
            persongem.Clear();

            labelRetorno.Text = "Lista apagada!";
            labelContador.Text = "0";
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