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

        private Deck baralhoQueryNome(string nomeBaralho)
        {
            var query = from baralho in container.DeckSet
                        where baralho.Nome.Equals(nomeBaralho)
                        select baralho;

            foreach (var baralho in query)
            {
                return baralho;
            }
            return null;
        }

        private void EventoAdicionarBaralho(object sender, EventArgs e)
        {
            AdicionarBaralhoForm form = new AdicionarBaralhoForm();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (form.novoDeck != null)
                    AdicionarBaralho(form.novoDeck);
            }
        }

        private void AdicionarBaralho(Deck novoDeck)
        {
            container.DeckSet.Add(novoDeck);
            container.SaveChanges();
            RefreshListaBaralhos();
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
    }
}
