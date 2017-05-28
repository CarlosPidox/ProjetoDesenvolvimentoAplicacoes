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
        private List<Carta> listaDeck;

        Carta cartaSelecionadaBaralho;
        Carta cartaSelecionada;

        public AdicionarBaralhoForm()
        {
            InitializeComponent();
            container = new DataModeloContainer();
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
            cartaSelecionadaBaralho = (Carta)listbox_baralho.SelectedItem;
        }

        private void button_adicionarCarta_Click(object sender, EventArgs e)
        {
            const int limite = 1;

            if (cartaSelecionada != null)
            {
                if (listaDeck.Count < 45)
                {
                    int cont = 0;
                    Carta novaCarta = cartaSelecionada;
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
        }

        private void button_eliminarCarta_Click(object sender, EventArgs e)
        {
            listaDeck.Remove(cartaSelecionadaBaralho);
            RefreshListaDeck();

            if (listbox_baralho.Items.Count == 0)
                cartaSelecionadaBaralho = null;
        }

        private void button_adicionar_Click(object sender, EventArgs e)
        {
            if(textBox_nomeBaralho.Text != "" || listbox_baralho.Items.Count != 0)
            { 
                if (listaDeck.Count() != 0)
                {
                    novoDeck = new Deck()
                    {
                        Nome = textBox_nomeBaralho.Text,
                        Carta = listaDeck
                    };

                    container.DeckSet.Add(novoDeck);
                    container.SaveChanges();
                }

                DialogResult = DialogResult.OK;
            }
            else
            {   //Melhorar isto
                string erro = "O baralho";

                if (textBox_nomeBaralho.Text == "")
                    erro = string.Concat(erro, " não tem nome");
                if(listaDeck.Count() == 0)
                    erro = string.Concat(erro, " não tem cartas selecionadas");

                DialogResult dialogResult = MessageBox.Show(erro + ". Quer cancelar a criação do baralho?", "Baralho Inválido", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void listbox_cartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartaSelecionada = (Carta)listbox_cartas.SelectedItem;
        }

        private void AdicionarBaralhoForm_Load(object sender, EventArgs e)
        {
            if(container.CartaSet.Count() == 0)
            {
                MessageBox.Show("Não existem cartas guardadas!");
                DialogResult = DialogResult.OK;
            }
        }
    }
}
