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
    public partial class GestaoEquipasForm : Form
    {
        public GestaoEquipasForm()
        {
            InitializeComponent();
        }

        private void GestaoEquipasForm_Load(object sender, EventArgs e)
        {

        }

        private void button_adicionarEquipa_Click(object sender, EventArgs e)
        {
            AdicionarEquipaForm form = new AdicionarEquipaForm();
            form.ShowDialog();
        }

        private void button_editarEquipa_Click(object sender, EventArgs e)
        {
            EditarEquipaForm form = new EditarEquipaForm();
            form.ShowDialog();
        }
    }
}
