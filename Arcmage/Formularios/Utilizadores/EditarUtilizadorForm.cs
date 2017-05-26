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
    public partial class EditarUtilizadorForm : Form
    {


        public EditarUtilizadorForm()
        {
            InitializeComponent();

            bool admin = true;

            if (admin)
            {
                pictureBox_avatar.Visible = false;
                button_removerAvatar.Visible = false;
                textBox_username.Size = new Size(222, 20);
                textBox_password.Size = new Size(222, 20);
                label_nomeEmail.Text = "Email";
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

        private void EditarUtilizadorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
