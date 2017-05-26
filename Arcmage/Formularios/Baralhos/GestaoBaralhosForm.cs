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
        public GestaoBaralhosForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem acerteza que pretende eliminar o baralho [NOME DO BARALHO]?", "Eliminar Baralho", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void GestaoBaralhosForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarBaralhoForm form = new EditarBaralhoForm();
            form.ShowDialog();
        }

        private void button_adicionarBaralho_Click(object sender, EventArgs e)
        {
            EditarEquipaForm form = new EditarEquipaForm();
            form.ShowDialog();
        }
    }
}
