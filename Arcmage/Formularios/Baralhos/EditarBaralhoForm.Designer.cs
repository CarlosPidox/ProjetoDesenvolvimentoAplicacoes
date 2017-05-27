namespace Arcmage
{
    partial class EditarBaralhoForm
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
            this.button_adicionar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.textBox_nomeBaralho = new System.Windows.Forms.TextBox();
            this.label_nomeBaralho = new System.Windows.Forms.Label();
            this.label_numCartas = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listbox_baralho = new System.Windows.Forms.ListBox();
            this.listbox_cartas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_adicionar
            // 
            this.button_adicionar.Location = new System.Drawing.Point(186, 274);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(75, 23);
            this.button_adicionar.TabIndex = 17;
            this.button_adicionar.Text = "Editar";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(267, 274);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 16;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // textBox_nomeBaralho
            // 
            this.textBox_nomeBaralho.Location = new System.Drawing.Point(109, 246);
            this.textBox_nomeBaralho.Name = "textBox_nomeBaralho";
            this.textBox_nomeBaralho.Size = new System.Drawing.Size(232, 20);
            this.textBox_nomeBaralho.TabIndex = 15;
            // 
            // label_nomeBaralho
            // 
            this.label_nomeBaralho.AutoSize = true;
            this.label_nomeBaralho.Location = new System.Drawing.Point(11, 249);
            this.label_nomeBaralho.Name = "label_nomeBaralho";
            this.label_nomeBaralho.Size = new System.Drawing.Size(89, 13);
            this.label_nomeBaralho.TabIndex = 14;
            this.label_nomeBaralho.Text = "Nome do Baralho";
            // 
            // label_numCartas
            // 
            this.label_numCartas.AutoSize = true;
            this.label_numCartas.Location = new System.Drawing.Point(305, 221);
            this.label_numCartas.Name = "label_numCartas";
            this.label_numCartas.Size = new System.Drawing.Size(36, 13);
            this.label_numCartas.TabIndex = 13;
            this.label_numCartas.Text = "45/45";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listbox_baralho
            // 
            this.listbox_baralho.FormattingEnabled = true;
            this.listbox_baralho.Location = new System.Drawing.Point(221, 19);
            this.listbox_baralho.Name = "listbox_baralho";
            this.listbox_baralho.Size = new System.Drawing.Size(120, 199);
            this.listbox_baralho.TabIndex = 10;
            // 
            // listbox_cartas
            // 
            this.listbox_cartas.FormattingEnabled = true;
            this.listbox_cartas.Location = new System.Drawing.Point(14, 19);
            this.listbox_cartas.Name = "listbox_cartas";
            this.listbox_cartas.Size = new System.Drawing.Size(120, 199);
            this.listbox_cartas.TabIndex = 9;
            // 
            // EditarBaralhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 317);
            this.Controls.Add(this.button_adicionar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.textBox_nomeBaralho);
            this.Controls.Add(this.label_nomeBaralho);
            this.Controls.Add(this.label_numCartas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listbox_baralho);
            this.Controls.Add(this.listbox_cartas);
            this.Name = "EditarBaralhoForm";
            this.Text = "EditarBaralhoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.TextBox textBox_nomeBaralho;
        private System.Windows.Forms.Label label_nomeBaralho;
        private System.Windows.Forms.Label label_numCartas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listbox_baralho;
        private System.Windows.Forms.ListBox listbox_cartas;
    }
}