namespace Pratica7_Lista2
{
    public partial class FormList : Form
    {
        List<string> pessoa = new List<string>();
        
        public FormList()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            string nome;
            pessoa.Add(textBoxNome.Text);
            nome = textBoxNome.Text;

            labelRetorno.Text = nome + " adicionado(a)!";
            labelContador.Text = pessoa.Count.ToString();
            textBoxNome.Text = "";
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            string toda_lista = string.Join(",", pessoa);
            MessageBox.Show(toda_lista);
        }

        private void buttonLimpa_Click(object sender, EventArgs e)
        {
            pessoa.Clear();

            labelRetorno.Text = "Lista apagada!";
            labelContador.Text = "0";
        }
    }

}
