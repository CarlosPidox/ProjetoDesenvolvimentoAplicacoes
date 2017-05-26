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
    public partial class GestaoCartasForm : Form
    {

        private List<Carta> listaCartas;
        private DataModeloContainer container;

        public GestaoCartasForm()
        {
            InitializeComponent();
            container = new DataModeloContainer();
            listaCartas = new List<Carta>();
            RefreshListaCartas();
        }

        public void AdicionarCarta(Carta novaCarta)
        {
            container.CartaSet.Add(novaCarta);
            container.SaveChanges();
            RefreshListaCartas();
        }

        public void EditarCarta(Carta novaCarta)
        {
            container.CartaSet.Add(novaCarta);
            container.SaveChanges();
            RefreshListaCartas();
        }

        public void RefreshListaCartas()
        {
            listbox_cartas.Items.Clear();

            listbox_cartas.Items.AddRange(container.CartaSet.ToArray());
        }

        private Carta cartaQueryNome(string nomeCarta)
        {
            var query = from carta in container.CartaSet
                        where carta.Nome.Equals(nomeCarta)
                        select carta;

            foreach (var carta in query)
            {
                return carta;
            }
            return null;
        }

        private void EventoAdicionarCarta(object sender, EventArgs e)
        {
            AdicionarCartaForm form = new AdicionarCartaForm();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (form.novaCarta != null)
                    AdicionarCarta(form.novaCarta);
            }
        }

        private void EventoEditarCarta(object sender, EventArgs e)
        {
            if (listbox_cartas.SelectedItem != null)
            {
                string nomeCarta = listbox_cartas.GetItemText(listbox_cartas.SelectedItem);
                Carta carta = cartaQueryNome(nomeCarta);

                if (carta != null)
                {
                    EditarCartaForm form = new EditarCartaForm();
                    form.carta = carta;
                    DialogResult resultado = form.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        container.SaveChanges();
                        RefreshListaCartas();
                    }
                }
                else
                    MessageBox.Show("Algo está mal! Carta não encontrada na base de dados!");
            }
            else
            {
                MessageBox.Show("Por favor selecione uma carta");
            }
        }

        private void EventoEliminarCarta(object sender, EventArgs e)
        {
            if (listbox_cartas.SelectedItem != null)
            {
                string nomeCarta = listbox_cartas.GetItemText(listbox_cartas.SelectedItem);

                DialogResult confirmar = MessageBox.Show("Eliminar a carta '" + nomeCarta + "'?", "Eliminar Carta", MessageBoxButtons.YesNo);

                if (confirmar == DialogResult.Yes)
                {
                    Carta carta = cartaQueryNome(nomeCarta);

                    if (carta != null)
                    {
                        container.CartaSet.Remove(carta);
                        container.SaveChanges();
                        RefreshListaCartas();
                    }       
                    else
                        MessageBox.Show("Algo está mal! Carta não encontrada na base de dados!");
                }
            }
            else
                MessageBox.Show("Selecione a carta a eliminar");
        }

        private void GestaoCartasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
