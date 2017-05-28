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
    public partial class GestaoBaralhosForm : Form
    {

        private DataModeloContainer container;
        private Deck deckSelecionado;

        public GestaoBaralhosForm()
        {
            InitializeComponent();
            container = new DataModeloContainer();
            RefreshListaBaralhos();
        }

        private void RefreshListaBaralhos()
        {
            listbox_baralho.Items.Clear();
            listbox_baralho.Items.AddRange(container.DeckSet.ToArray());
        }

        
        private void EventoAdicionarBaralho(object sender, EventArgs e)
        {
            AdicionarBaralhoForm form = new AdicionarBaralhoForm();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (form.novoDeck != null)
                    RefreshListaBaralhos();
            }
        }

        private void EventoEditarBaralho(object sender, EventArgs e)
        {
            if (deckSelecionado != null)
            {
                EditarBaralhoForm form = new EditarBaralhoForm();
                form.Deck = deckSelecionado;
                DialogResult resultado = form.ShowDialog();
                RefreshListaBaralhos();
                container.SaveChanges();
            }
            else
                MessageBox.Show("Por favor selecione o baralho a editar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
        }

        private void GestaoBaralhosForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarBaralhoForm form = new AdicionarBaralhoForm();
            form.ShowDialog();
        }

        private void button_adicionarBaralho_Click(object sender, EventArgs e)
        {
            AdicionarBaralhoForm form = new AdicionarBaralhoForm();
            form.ShowDialog();
        }

        private void listbox_baralho_SelectedIndexChanged(object sender, EventArgs e)
        {
            deckSelecionado = (Deck)listbox_baralho.SelectedItem;
        }
    }
}
