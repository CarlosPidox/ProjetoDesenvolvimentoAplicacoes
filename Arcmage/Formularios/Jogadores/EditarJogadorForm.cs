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
    public partial class EditarJogadorForm : Form
    {

        public Jogador jogador;

        public EditarJogadorForm()
        {
            InitializeComponent();
        }

        private void EditarJogadorForm_Load(object sender, EventArgs e)
        {
            textBox_nickname.Text = jogador.Nickname;
            textBox_nomeJogador.Text = jogador.Nome;
            textBox_emailJogador.Text = jogador.Email;
            pictureBox_avatar.ImageLocation = jogador.Avatar;
            numericUpDown_idade.Value = jogador.Idade;
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

        private void button_cancelarJogador_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_editarJogador_Click(object sender, EventArgs e)
        {
            label_nickname.ForeColor = Color.Black;
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
            //var teste = email.IndexOf("@");
            if (email.Length == 0)
            {
                erro = true;
                label_email.ForeColor = Color.Red;
            }
            if (!erro)
            {
                jogador.Nickname = textBox_nickname.Text;
                jogador.Nome = textBox_nomeJogador.Text;
                jogador.Email = textBox_emailJogador.Text;
                jogador.Avatar = pictureBox_avatar.ImageLocation;
                jogador.Idade = (int)numericUpDown_idade.Value;
                DialogResult = DialogResult.OK;
            }
        }

        private void button_removerAvatar_Click(object sender, EventArgs e)
        {
            pictureBox_avatar.ImageLocation = @"Imagens\AddAvatar.png";
        }
    }
}
