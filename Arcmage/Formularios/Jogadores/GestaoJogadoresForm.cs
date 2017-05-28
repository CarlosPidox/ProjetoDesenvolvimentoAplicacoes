using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcmage
{
    public partial class GestaoJogadoresForm : Form
    {

        private DataModeloContainer container;

        public GestaoJogadoresForm()
        {
            InitializeComponent();
            container = new DataModeloContainer();
            RefreshListaJogadores();
        }

        public void RefreshListaJogadores()
        {
            listbox_jogadores.Items.Clear();
            listbox_jogadores.Items.AddRange(container.JogadorSet.ToArray());
        }

        private void EventoAdicionarJogador(object sender, EventArgs e)
        {
            AdicionarJogadorForm form = new AdicionarJogadorForm();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (form.novoJogador != null)
                    AdicionarJogador(form.novoJogador);
            }
        }

        private void AdicionarJogador(Jogador novoJogador)
        {
            container.JogadorSet.Add(novoJogador);
            container.SaveChanges();
            RefreshListaJogadores();
        }

        private void button_editarJogador_Click(object sender, EventArgs e)
        {
            var jogador = (Jogador)listbox_jogadores.SelectedItem;

            if (jogador != null)
            {
                EditarJogadorForm form = new EditarJogadorForm();
                form.jogador = jogador;
                DialogResult resultado = form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    RefreshListaJogadores();
                    container.SaveChanges();
                }
            }
            else
                MessageBox.Show("Por favor selecione um jogador");
        }

        private void button_eliminarJogador_Click(object sender, EventArgs e)
        {
            var jogador = (Jogador)listbox_jogadores.SelectedItem;

            if (jogador != null)
            {
                container.JogadorSet.Remove(jogador);
                container.SaveChanges();
                RefreshListaJogadores();
            }
        }

        private void GestaoJogadoresForm_Load(object sender, EventArgs e)
        {

        }
    }

}
