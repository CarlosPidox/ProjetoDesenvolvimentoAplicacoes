namespace Arcmage
{
    partial class GestaoBaralhosForm
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
            this.listbox_baralho = new System.Windows.Forms.ListBox();
            this.button_adicionarBaralho = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listbox_baralho
            // 
            this.listbox_baralho.FormattingEnabled = true;
            this.listbox_baralho.Items.AddRange(new object[] {
            "Baralho 1",
            "Baralho 2",
            "Baralho 1",
            "Baralho 2",
            "Baralho 1",
            "Baralho 2",
            ""});
            this.listbox_baralho.Location = new System.Drawing.Point(12, 36);
            this.listbox_baralho.Name = "listbox_baralho";
            this.listbox_baralho.Size = new System.Drawing.Size(120, 225);
            this.listbox_baralho.TabIndex = 0;
            // 
            // button_adicionarBaralho
            // 
            this.button_adicionarBaralho.Location = new System.Drawing.Point(151, 36);
            this.button_adicionarBaralho.Name = "button_adicionarBaralho";
            this.button_adicionarBaralho.Size = new System.Drawing.Size(121, 23);
            this.button_adicionarBaralho.TabIndex = 1;
            this.button_adicionarBaralho.Text = "Adicionar ";
            this.button_adicionarBaralho.UseVisualStyleBackColor = true;
            this.button_adicionarBaralho.Click += new System.EventHandler(this.button_adicionarBaralho_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Editar Selecionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Eliminar Selecionado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestão de Baralhos";
            // 
            // GestaoBaralhosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_adicionarBaralho);
            this.Controls.Add(this.listbox_baralho);
            this.Name = "GestaoBaralhosForm";
            this.Text = "GestaoBaralhosForm";
            this.Load += new System.EventHandler(this.GestaoBaralhosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_baralho;
        private System.Windows.Forms.Button button_adicionarBaralho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}