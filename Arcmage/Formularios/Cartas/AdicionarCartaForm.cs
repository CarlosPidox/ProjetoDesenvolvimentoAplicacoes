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
    public partial class AdicionarCartaForm : Form
    {
        public Carta novaCarta { get; private set; }

        public AdicionarCartaForm()
        {
            InitializeComponent();
        }


        private void label_tipo_Click(object sender, EventArgs e)
        {
        }

        private void button_adicionar_Click(object sender, EventArgs e)
        {
            label_nome.ForeColor = Color.Black;
            label_custo.ForeColor = Color.Black;
            label_regras.ForeColor = Color.Black;
            
            bool erro = false;
            if (textBox_nome.TextLength == 0)
            {
                erro = true;
                label_nome.ForeColor = Color.Red;
            }

            if (textBox_custo.TextLength == 0)
            {
                erro = true;
                label_custo.ForeColor = Color.Red;
            }

            if (textBox_textoRegras.TextLength == 0)
            {
                erro = true;
                label_regras.ForeColor = Color.Red;
            }
            if (!erro)                        
            {
                novaCarta = new Carta
                {
                    Nome = textBox_nome.Text,
                    Facao = comboBox_facao.SelectedItem.ToString(),
                    Tipo = comboBox_tipo.SelectedItem.ToString(),
                    Custo = textBox_custo.Text,
                    Lealdade = (int)numericUpDown_lealdade.Value,
                    Texto = textBox_textoRegras.Text,
                    Ataque = (int)numericUpDown_ataque.Value,
                    Defesa = (int)numericUpDown_defesa.Value

                };

                DialogResult = DialogResult.OK;
            }
        }

        private void AdicionarCartaForm_Load(object sender, EventArgs e)
        {

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
