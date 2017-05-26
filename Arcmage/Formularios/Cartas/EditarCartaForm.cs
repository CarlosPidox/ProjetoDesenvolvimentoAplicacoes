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
    public partial class EditarCartaForm : Form
    {
        public Carta carta;

        public EditarCartaForm()
        {
            InitializeComponent();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EventoCarregarCarta(object sender, EventArgs e)
        {
            if (carta != null)
            { 
                textBox_nome.Text = carta.Nome;
                comboBox_facao.Text = carta.Facao;
                textBox_custo.Text = carta.Custo;
                textBox_textoRegras.Text = carta.Texto;
                comboBox_tipo.Text = carta.Tipo;
                numericUpDown_ataque.Value = (int)carta.Ataque;
                numericUpDown_lealdade.Value = (int)carta.Lealdade;
                numericUpDown_defesa.Value = (int)carta.Defesa;
            }
            else
            {
                MessageBox.Show("Erro! Carta não encontrada!");
                Close();
            }
        }

        private void button_confirmar_Click(object sender, EventArgs e)
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
                carta.Nome = textBox_nome.Text;
                carta.Facao = comboBox_facao.SelectedItem.ToString();
                carta.Custo = textBox_custo.Text;
                carta.Texto = textBox_textoRegras.Text;
                carta.Tipo = comboBox_tipo.SelectedItem.ToString();
                carta.Ataque = (int)numericUpDown_ataque.Value;
                carta.Lealdade = (int)numericUpDown_lealdade.Value;
                carta.Defesa = (int)numericUpDown_defesa.Value;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
