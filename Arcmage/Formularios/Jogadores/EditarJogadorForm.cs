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
            jogador.Nickname = textBox_nickname.Text;
            jogador.Nome = textBox_nomeJogador.Text ;
            jogador.Email = textBox_emailJogador.Text;
            jogador.Avatar = pictureBox_avatar.ImageLocation;
            jogador.Idade = (int)numericUpDown_idade.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
