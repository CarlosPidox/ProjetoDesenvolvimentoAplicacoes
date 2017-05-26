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
    public partial class PrincipalAdministradorForm : Form
    {
        private DataModeloContainer container;

        public PrincipalAdministradorForm()
        {
            InitializeComponent();
            container = new DataModeloContainer();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestaoBaralhosForm form = new GestaoBaralhosForm();
            form.ShowDialog();
        }

        private void button_gestaoUtilizadores_Click(object sender, EventArgs e)
        {
            GestaoUtilizadoresForm form = new GestaoUtilizadoresForm();
            form.ShowDialog();
        }

        private void button_gestaoJogadores_Click(object sender, EventArgs e)
        {
            GestaoJogadoresForm form = new GestaoJogadoresForm();
            form.ShowDialog();
        }

        private void button_gestaoEquipas_Click(object sender, EventArgs e)
        {
            GestaoEquipasForm form = new GestaoEquipasForm();
            form.ShowDialog();
        }

        private void button_gestaoTorneios_Click(object sender, EventArgs e)
        {
            GestaoTorneiosForm form = new GestaoTorneiosForm();
            form.ShowDialog();
        }

        private void EventoGestaoCarta(object sender, EventArgs e)
        {
            GestaoCartasForm form = new GestaoCartasForm();
            form.ShowDialog();
        }

        private void AdicionarCarta(Carta novaCarta)
        {
            container.CartaSet.Add(novaCarta);
            container.SaveChanges();
        }
    }
}
