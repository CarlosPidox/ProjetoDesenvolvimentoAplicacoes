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
    public partial class AdicionarUtilizadorForm : Form
    {
        public AdicionarUtilizadorForm()
        {
            InitializeComponent();
            label_nomeEmail.Text = "Email";
            pictureBox_avatar.Visible = false;
            button_removerAvatar.Visible = false;
            textBox_username.Size = new Size(222, 20);
            textBox_password.Size = new Size(222, 20);
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_tipoUtilizador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_tipoUtilizador.SelectedIndex == 0)
            {
                label_nomeEmail.Text = "Email";
                pictureBox_avatar.Visible = false;
                button_removerAvatar.Visible = false;
                textBox_username.Size = new Size(222, 20);
                textBox_password.Size = new Size(222, 20);
            }
            else
            {
                label_nomeEmail.Text = "Nome";
                pictureBox_avatar.Visible = true;
                button_removerAvatar.Visible = true;
                textBox_username.Size = new Size(117, 20);
                textBox_password.Size = new Size(117, 20);
            }
        }

        private void button_adicionar_Click(object sender, EventArgs e)
        {

        }
    }
}
