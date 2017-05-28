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
            novoJogador = new Jogador
            {
                Nickname = textBox_nickname.Text,
                Idade = (int)numericUpDown_idade.Value,
                Nome = textBox_nomeJogador.Text,
                Email = textBox_emailJogador.Text
            };
        }

        private void pictureBox_avatar_Click(object sender, EventArgs e)
        {
            if (openImagemDialog.ShowDialog() == DialogResult.OK)
            {
                if (openImagemDialog.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.  
                    System.IO.FileStream fs =
                       (System.IO.FileStream)openImagemDialog.OpenFile();
                    //fs.

                    //fs.Close();
                }
            }

           // MessageBox.Show(textoMsgBox, tituloMsgBox, MessageBoxButtons.OK);
        }

        private void openImagemDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
