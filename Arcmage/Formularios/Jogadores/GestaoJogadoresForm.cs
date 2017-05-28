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
        }

        public void RefreshListaJogadores()
        {
            listbox_jogadores.Items.Clear();
            listbox_jogadores.Items.AddRange(container.CartaSet.ToArray());
        }

        private void EventoAdicionarJogador(object sender, EventArgs e)
        {
            AdicionarJogadorForm form = new AdicionarJogadorForm();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //if (form.novaCarta != null)
                    //AdicionarJogador(form.novaCarta);
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
            EditarJogadorForm form = new EditarJogadorForm();
            form.ShowDialog();
        }
    }
    
}
