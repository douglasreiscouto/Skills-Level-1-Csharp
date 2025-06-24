using ControleAcertos.UI.Forms;

namespace ControleAcertos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
        }

        private void linkLabelCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastrarUsuario cadastrarUsuario = new CadastrarUsuario();
            cadastrarUsuario.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
