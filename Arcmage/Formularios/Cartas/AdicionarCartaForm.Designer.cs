namespace Arcmage
{
    partial class AdicionarCartaForm
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
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_custo = new System.Windows.Forms.TextBox();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.numericUpDown_lealdade = new System.Windows.Forms.NumericUpDown();
            this.textBox_textoRegras = new System.Windows.Forms.TextBox();
            this.numericUpDown_defesa = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ataque = new System.Windows.Forms.NumericUpDown();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_facao = new System.Windows.Forms.Label();
            this.label_tipo = new System.Windows.Forms.Label();
            this.label_lealdade = new System.Windows.Forms.Label();
            this.label_custo = new System.Windows.Forms.Label();
            this.label_regras = new System.Windows.Forms.Label();
            this.label_ataque = new System.Windows.Forms.Label();
            this.label_defesa = new System.Windows.Forms.Label();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.comboBox_facao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lealdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_defesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ataque)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(65, 12);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(100, 20);
            this.textBox_nome.TabIndex = 0;
            // 
            // textBox_custo
            // 
            this.textBox_custo.Location = new System.Drawing.Point(65, 46);
            this.textBox_custo.Name = "textBox_custo";
            this.textBox_custo.Size = new System.Drawing.Size(100, 20);
            this.textBox_custo.TabIndex = 2;
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Items.AddRange(new object[] {
            "Creature",
            "Event",
            "Equipment",
            "Magic",
            "Enchantment",
            "City"});
            this.comboBox_tipo.Location = new System.Drawing.Point(237, 46);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(112, 21);
            this.comboBox_tipo.TabIndex = 3;
            this.comboBox_tipo.Text = "Creature";
            // 
            // numericUpDown_lealdade
            // 
            this.numericUpDown_lealdade.Location = new System.Drawing.Point(127, 112);
            this.numericUpDown_lealdade.Name = "numericUpDown_lealdade";
            this.numericUpDown_lealdade.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_lealdade.TabIndex = 4;
            // 
            // textBox_textoRegras
            // 
            this.textBox_textoRegras.Location = new System.Drawing.Point(12, 165);
            this.textBox_textoRegras.Multiline = true;
            this.textBox_textoRegras.Name = "textBox_textoRegras";
            this.textBox_textoRegras.Size = new System.Drawing.Size(337, 78);
            this.textBox_textoRegras.TabIndex = 5;
            // 
            // numericUpDown_defesa
            // 
            this.numericUpDown_defesa.Location = new System.Drawing.Point(311, 83);
            this.numericUpDown_defesa.Name = "numericUpDown_defesa";
            this.numericUpDown_defesa.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_defesa.TabIndex = 6;
            // 
            // numericUpDown_ataque
            // 
            this.numericUpDown_ataque.Location = new System.Drawing.Point(127, 81);
            this.numericUpDown_ataque.Name = "numericUpDown_ataque";
            this.numericUpDown_ataque.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_ataque.TabIndex = 7;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(9, 15);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(35, 13);
            this.label_nome.TabIndex = 8;
            this.label_nome.Text = "Nome";
            // 
            // label_facao
            // 
            this.label_facao.AutoSize = true;
            this.label_facao.Location = new System.Drawing.Point(194, 15);
            this.label_facao.Name = "label_facao";
            this.label_facao.Size = new System.Drawing.Size(37, 13);
            this.label_facao.TabIndex = 9;
            this.label_facao.Text = "Fação";
            // 
            // label_tipo
            // 
            this.label_tipo.AutoSize = true;
            this.label_tipo.Location = new System.Drawing.Point(194, 49);
            this.label_tipo.Name = "label_tipo";
            this.label_tipo.Size = new System.Drawing.Size(28, 13);
            this.label_tipo.TabIndex = 10;
            this.label_tipo.Text = "Tipo";
            this.label_tipo.Click += new System.EventHandler(this.label_tipo_Click);
            // 
            // label_lealdade
            // 
            this.label_lealdade.AutoSize = true;
            this.label_lealdade.Location = new System.Drawing.Point(9, 114);
            this.label_lealdade.Name = "label_lealdade";
            this.label_lealdade.Size = new System.Drawing.Size(51, 13);
            this.label_lealdade.TabIndex = 11;
            this.label_lealdade.Text = "Lealdade";
            // 
            // label_custo
            // 
            this.label_custo.AutoSize = true;
            this.label_custo.Location = new System.Drawing.Point(9, 49);
            this.label_custo.Name = "label_custo";
            this.label_custo.Size = new System.Drawing.Size(34, 13);
            this.label_custo.TabIndex = 12;
            this.label_custo.Text = "Custo";
            // 
            // label_regras
            // 
            this.label_regras.AutoSize = true;
            this.label_regras.Location = new System.Drawing.Point(9, 149);
            this.label_regras.Name = "label_regras";
            this.label_regras.Size = new System.Drawing.Size(41, 13);
            this.label_regras.TabIndex = 13;
            this.label_regras.Text = "Regras";
            // 
            // label_ataque
            // 
            this.label_ataque.AutoSize = true;
            this.label_ataque.Location = new System.Drawing.Point(9, 83);
            this.label_ataque.Name = "label_ataque";
            this.label_ataque.Size = new System.Drawing.Size(41, 13);
            this.label_ataque.TabIndex = 14;
            this.label_ataque.Text = "Ataque";
            // 
            // label_defesa
            // 
            this.label_defesa.AutoSize = true;
            this.label_defesa.Location = new System.Drawing.Point(194, 85);
            this.label_defesa.Name = "label_defesa";
            this.label_defesa.Size = new System.Drawing.Size(41, 13);
            this.label_defesa.TabIndex = 15;
            this.label_defesa.Text = "Defesa";
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(274, 249);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 16;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_adicionar
            // 
            this.button_adicionar.Location = new System.Drawing.Point(193, 249);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(75, 23);
            this.button_adicionar.TabIndex = 17;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
            // 
            // comboBox_facao
            // 
            this.comboBox_facao.FormattingEnabled = true;
            this.comboBox_facao.Items.AddRange(new object[] {
            "Gaian Love for Life",
            "Uneasy Alliance"});
            this.comboBox_facao.Location = new System.Drawing.Point(237, 12);
            this.comboBox_facao.Name = "comboBox_facao";
            this.comboBox_facao.Size = new System.Drawing.Size(112, 21);
            this.comboBox_facao.TabIndex = 18;
            this.comboBox_facao.Text = "Gaian Love for Life";
            // 
            // AdicionarCartaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 279);
            this.Controls.Add(this.comboBox_facao);
            this.Controls.Add(this.button_adicionar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.label_defesa);
            this.Controls.Add(this.label_ataque);
            this.Controls.Add(this.label_regras);
            this.Controls.Add(this.label_custo);
            this.Controls.Add(this.label_lealdade);
            this.Controls.Add(this.label_tipo);
            this.Controls.Add(this.label_facao);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.numericUpDown_ataque);
            this.Controls.Add(this.numericUpDown_defesa);
            this.Controls.Add(this.textBox_textoRegras);
            this.Controls.Add(this.numericUpDown_lealdade);
            this.Controls.Add(this.comboBox_tipo);
            this.Controls.Add(this.textBox_custo);
            this.Controls.Add(this.textBox_nome);
            this.Name = "AdicionarCartaForm";
            this.Text = "AdicionarCartaForm";
            this.Load += new System.EventHandler(this.AdicionarCartaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lealdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_defesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ataque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.TextBox textBox_custo;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.NumericUpDown numericUpDown_lealdade;
        private System.Windows.Forms.TextBox textBox_textoRegras;
        private System.Windows.Forms.NumericUpDown numericUpDown_defesa;
        private System.Windows.Forms.NumericUpDown numericUpDown_ataque;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_facao;
        private System.Windows.Forms.Label label_tipo;
        private System.Windows.Forms.Label label_lealdade;
        private System.Windows.Forms.Label label_custo;
        private System.Windows.Forms.Label label_regras;
        private System.Windows.Forms.Label label_ataque;
        private System.Windows.Forms.Label label_defesa;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.ComboBox comboBox_facao;
    }
}