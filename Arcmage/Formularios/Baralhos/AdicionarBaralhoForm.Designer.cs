namespace Arcmage
{
    partial class AdicionarBaralhoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listbox_cartas = new System.Windows.Forms.ListBox();
            this.listbox_baralho = new System.Windows.Forms.ListBox();
            this.button_adicionarCarta = new System.Windows.Forms.Button();
            this.button_eliminarCarta = new System.Windows.Forms.Button();
            this.label_numCartas = new System.Windows.Forms.Label();
            this.label_nomeBaralho = new System.Windows.Forms.Label();
            this.textBox_nomeBaralho = new System.Windows.Forms.TextBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbox_cartas
            // 
            this.listbox_cartas.FormattingEnabled = true;
            this.listbox_cartas.Location = new System.Drawing.Point(12, 31);
            this.listbox_cartas.Name = "listbox_cartas";
            this.listbox_cartas.Size = new System.Drawing.Size(120, 199);
            this.listbox_cartas.TabIndex = 0;
            this.listbox_cartas.SelectedIndexChanged += new System.EventHandler(this.listbox_cartas_SelectedIndexChanged);
            // 
            // listbox_baralho
            // 
            this.listbox_baralho.FormattingEnabled = true;
            this.listbox_baralho.Location = new System.Drawing.Point(219, 31);
            this.listbox_baralho.Name = "listbox_baralho";
            this.listbox_baralho.Size = new System.Drawing.Size(120, 199);
            this.listbox_baralho.TabIndex = 1;
            this.listbox_baralho.SelectedIndexChanged += new System.EventHandler(this.listBox_baralho_SelectedIndexChanged);
            // 
            // button_adicionarCarta
            // 
            this.button_adicionarCarta.Location = new System.Drawing.Point(138, 94);
            this.button_adicionarCarta.Name = "button_adicionarCarta";
            this.button_adicionarCarta.Size = new System.Drawing.Size(75, 23);
            this.button_adicionarCarta.TabIndex = 2;
            this.button_adicionarCarta.Text = ">";
            this.button_adicionarCarta.UseVisualStyleBackColor = true;
            this.button_adicionarCarta.Click += new System.EventHandler(this.button_adicionarCarta_Click);
            // 
            // button_eliminarCarta
            // 
            this.button_eliminarCarta.Location = new System.Drawing.Point(138, 133);
            this.button_eliminarCarta.Name = "button_eliminarCarta";
            this.button_eliminarCarta.Size = new System.Drawing.Size(75, 23);
            this.button_eliminarCarta.TabIndex = 3;
            this.button_eliminarCarta.Text = "<";
            this.button_eliminarCarta.UseVisualStyleBackColor = true;
            this.button_eliminarCarta.Click += new System.EventHandler(this.button_eliminarCarta_Click);
            // 
            // label_numCartas
            // 
            this.label_numCartas.AutoSize = true;
            this.label_numCartas.Location = new System.Drawing.Point(303, 233);
            this.label_numCartas.Name = "label_numCartas";
            this.label_numCartas.Size = new System.Drawing.Size(30, 13);
            this.label_numCartas.TabIndex = 4;
            this.label_numCartas.Text = "0/45";
            // 
            // label_nomeBaralho
            // 
            this.label_nomeBaralho.AutoSize = true;
            this.label_nomeBaralho.Location = new System.Drawing.Point(9, 261);
            this.label_nomeBaralho.Name = "label_nomeBaralho";
            this.label_nomeBaralho.Size = new System.Drawing.Size(89, 13);
            this.label_nomeBaralho.TabIndex = 5;
            this.label_nomeBaralho.Text = "Nome do Baralho";
            // 
            // textBox_nomeBaralho
            // 
            this.textBox_nomeBaralho.Location = new System.Drawing.Point(107, 258);
            this.textBox_nomeBaralho.Name = "textBox_nomeBaralho";
            this.textBox_nomeBaralho.Size = new System.Drawing.Size(232, 20);
            this.textBox_nomeBaralho.TabIndex = 6;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(265, 286);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 7;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // button_adicionar
            // 
            this.button_adicionar.Location = new System.Drawing.Point(184, 286);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(75, 23);
            this.button_adicionar.TabIndex = 8;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
            // 
            // AdicionarBaralhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 317);
            this.Controls.Add(this.button_adicionar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.textBox_nomeBaralho);
            this.Controls.Add(this.label_nomeBaralho);
            this.Controls.Add(this.label_numCartas);
            this.Controls.Add(this.button_eliminarCarta);
            this.Controls.Add(this.button_adicionarCarta);
            this.Controls.Add(this.listbox_baralho);
            this.Controls.Add(this.listbox_cartas);
            this.Name = "AdicionarBaralhoForm";
            this.Text = "AdicionarBaralhoForm";
            this.Load += new System.EventHandler(this.AdicionarBaralhoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_cartas;
        private System.Windows.Forms.ListBox listbox_baralho;
        private System.Windows.Forms.Button button_adicionarCarta;
        private System.Windows.Forms.Button button_eliminarCarta;
        private System.Windows.Forms.Label label_numCartas;
        private System.Windows.Forms.Label label_nomeBaralho;
        private System.Windows.Forms.TextBox textBox_nomeBaralho;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_adicionar;
    }
}