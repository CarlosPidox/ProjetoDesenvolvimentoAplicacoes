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
    public partial class GestaoTorneiosForm : Form
    {
        public GestaoTorneiosForm()
        {
            InitializeComponent();
        }

        private void button_adicionarTorneio_Click(object sender, EventArgs e)
        {
            AdicionarTorneioForm form = new AdicionarTorneioForm();
            form.ShowDialog();
        }

        private void button_editarTorneio_Click(object sender, EventArgs e)
        {
            EditarTorneioForm form = new EditarTorneioForm();
            form.ShowDialog();
        }
    }
}
