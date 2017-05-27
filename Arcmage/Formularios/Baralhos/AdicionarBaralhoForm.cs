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
    public partial class AdicionarBaralhoForm : Form
    {
        public Deck novoDeck { get; private set; }
        private DataModeloContainer container;

        private List<Carta> listaCartas;
        private List<Carta> listaDeck;

        public AdicionarBaralhoForm()
        {
            InitializeComponent();
            container = new DataModeloContainer();
            listaCartas = new List<Carta>();
            listaDeck = new List<Carta>();
            listbox_cartas.Items.AddRange(container.CartaSet.ToArray());
        }

        private void RefreshListaDeck()
        {
           
            listbox_baralho.Items.Clear();

            if (listaDeck.Count() > 0)
                listbox_baralho.Items.AddRange(listaDeck.ToArray());

            label_numCartas.Text = listaDeck.Count() + "/45";
        }

        private void listBox_baralho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_adicionarCarta_Click(object sender, EventArgs e)
        {
            const int limite = 1;

            if (listaDeck.Count < 45)
            {
                int cont = 0;
                Carta novaCarta = (Carta)listbox_cartas.SelectedItem;
                foreach (Carta carta in listaDeck)
                {
                    if (carta.Equals(novaCarta))
                        cont++;
                }
                if (cont < limite)
                {
                    listaDeck.Add(novaCarta);
                    RefreshListaDeck();
                }
                else
                    MessageBox.Show("Nao pode adicionar " + limite.ToString() + " cartas iguais");
            }
            else
                MessageBox.Show("Só pode adicionar 45 cartas");
        }

        private void button_eliminarCarta_Click(object sender, EventArgs e)
        {
            Carta cartaSelecionada = (Carta)listbox_baralho.SelectedItem;
            listaDeck.Remove(cartaSelecionada);
            RefreshListaDeck();
        }

        private void button_adicionar_Click(object sender, EventArgs e)
        {
            if(listaDeck.Count() != 0)
            {     
                novoDeck = new Deck()
                {
                    Nome = textBox_nomeBaralho.Text,
                    Carta = listaDeck
                };
            }

            DialogResult = DialogResult.OK;
        }
    }
}
