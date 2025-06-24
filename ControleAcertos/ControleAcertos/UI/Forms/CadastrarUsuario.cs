using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcertos.UI.Forms
{
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
        }

        private void CadastrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastroRetornar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            Close(); //cadastro
            login.Close();//login
        }
    }
}
