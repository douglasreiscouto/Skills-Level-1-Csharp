using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;

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
            Personagem adicionaPersonagem = new Personagem(textBoxNome.Text, (int)numericUpDownLevel.Value);
            listaPersonagem.Add(adicionaPersonagem);

            labelRetorno.Text = textBoxNome.Text + " adicionado(a)!";
            labelContador.Text = listaPersonagem.Count.ToString();
            textBoxNome.Text = "";
            numericUpDownLevel.Value = 5;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            string toda_lista;

            toda_lista = string.Join(", ", listaPersonagem.Select(a => a.sNomeobj + " Lvl" + a.iLevelobj));
            MessageBox.Show(toda_lista);
        }

        private void buttonLimpa_Click(object sender, EventArgs e)
        {
            listaPersonagem.Clear();

            labelRetorno.Text = "Lista Apagada!";
            labelContador.Text = "0";
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            bool bAchouPersonagem;

            Personagem pesquisa = new Personagem(textBoxNomeResultado.Text, (int)numericUpDownLevelResultado.Value);
            bAchouPersonagem = listaPersonagem.Any(b => b.sNomeobj == pesquisa.sNomeobj && b.iLevelobj == pesquisa.iLevelobj);

            if (bAchouPersonagem == true)
            {
                MessageBox.Show("Personagem cadastrado!");
            }
            else
            {
                MessageBox.Show("Personagem não cadastrado");
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            string sNomeRemover;
            int iLevelRemover, iRemovido;

            sNomeRemover = textBoxNomeResultado.Text;
            iLevelRemover = (int)numericUpDownLevelResultado.Value;

            iRemovido = listaPersonagem.RemoveAll(d => d.sNomeobj == sNomeRemover && d.iLevelobj == iLevelRemover);

            if (iRemovido == 1)
            {
                labelRetorno.Text = sNomeRemover + " apagado!";
                labelContador.Text = listaPersonagem.Count.ToString();
            }
            else
            {
                labelRetorno.Text = sNomeRemover + " não apagado!";
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
