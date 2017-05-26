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
    public partial class GestaoJogadoresForm : Form
    {
        public GestaoJogadoresForm()
        {
            InitializeComponent();
        }

        private void button_adicionarJogador_Click(object sender, EventArgs e)
        {
            AdicionarJogadorForm form = new AdicionarJogadorForm();
            form.ShowDialog();
        }

        private void button_editarJogador_Click(object sender, EventArgs e)
        {
            EditarJogadorForm form = new EditarJogadorForm();
            form.ShowDialog();
        }
    }
    
}
