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
    public partial class GestaoUtilizadoresForm : Form
    {
        public GestaoUtilizadoresForm()
        {
            InitializeComponent();
        }

        private void button_adicionarUtilizador_Click(object sender, EventArgs e)
        {
            AdicionarUtilizadorForm form = new AdicionarUtilizadorForm();
            form.ShowDialog();
        }

        private void button_editarUtilizador_Click(object sender, EventArgs e)
        {
            EditarUtilizadorForm form = new EditarUtilizadorForm();
            form.ShowDialog();
        }
    }
}
