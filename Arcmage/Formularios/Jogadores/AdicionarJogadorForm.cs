using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcmage
{
    public partial class AdicionarJogadorForm : Form
    {

        public Jogador novoJogador;

        public AdicionarJogadorForm()
        {
            InitializeComponent();
        }

        private void button_adicionarJogador_Click(object sender, EventArgs e)
        {
            /*label_nickname.ForeColor = Color.Black;
            label_nome.ForeColor = Color.Black;
            label_email.ForeColor = Color.Black;
            label_idade.ForeColor = Color.Black;

            bool erro = false;
            if (textBox_nickname.TextLength == 0)
            {
                erro = true;
                label_nickname.ForeColor = Color.Red;
            }

            if (textBox_nomeJogador.TextLength == 0)
            {
                erro = true;
                label_nome.ForeColor = Color.Red;
            }

            string email = textBox_emailJogador.Text;
            var teste = email.IndexOf("@");
            if (email.Length == 0 && email.IndexOf("@") != 1)
            {
                erro = true;
                label_email.ForeColor = Color.Red;
            }
            if (!erro)
            {*/
                novoJogador = new Jogador
                {
                    Nickname = textBox_nickname.Text,
                    Idade = (int)numericUpDown_idade.Value,
                    Nome = textBox_nomeJogador.Text,
                    Email = textBox_emailJogador.Text,
                    Avatar = pictureBox_avatar.ImageLocation
                };
            DialogResult = DialogResult.OK;
            /*}*/
        }

        private void pictureBox_avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Imagem JPG|*.jpg|Imagem PNG|*.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox_avatar.ImageLocation = file.FileName;
            }
        }

        private void openImagemDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button_removerAvatar_Click(object sender, EventArgs e)
        {
            pictureBox_avatar.Image = Arcmage.Properties.Resources.AddAvatar;
        }
    }
}
