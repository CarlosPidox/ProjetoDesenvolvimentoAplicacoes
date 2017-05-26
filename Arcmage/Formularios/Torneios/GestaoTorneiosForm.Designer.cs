namespace Arcmage
{
    partial class GestaoTorneiosForm
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
            this.button_eliminarTorneio = new System.Windows.Forms.Button();
            this.button_editarTorneio = new System.Windows.Forms.Button();
            this.button_adicionarTorneio = new System.Windows.Forms.Button();
            this.listbox_torneios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_eliminarTorneio
            // 
            this.button_eliminarTorneio.Location = new System.Drawing.Point(151, 77);
            this.button_eliminarTorneio.Name = "button_eliminarTorneio";
            this.button_eliminarTorneio.Size = new System.Drawing.Size(121, 23);
            this.button_eliminarTorneio.TabIndex = 19;
            this.button_eliminarTorneio.Text = "Eliminar Selecionado";
            this.button_eliminarTorneio.UseVisualStyleBackColor = true;
            // 
            // button_editarTorneio
            // 
            this.button_editarTorneio.Location = new System.Drawing.Point(151, 48);
            this.button_editarTorneio.Name = "button_editarTorneio";
            this.button_editarTorneio.Size = new System.Drawing.Size(121, 23);
            this.button_editarTorneio.TabIndex = 18;
            this.button_editarTorneio.Text = "Editar Selecionado";
            this.button_editarTorneio.UseVisualStyleBackColor = true;
            this.button_editarTorneio.Click += new System.EventHandler(this.button_editarTorneio_Click);
            // 
            // button_adicionarTorneio
            // 
            this.button_adicionarTorneio.Location = new System.Drawing.Point(151, 19);
            this.button_adicionarTorneio.Name = "button_adicionarTorneio";
            this.button_adicionarTorneio.Size = new System.Drawing.Size(121, 23);
            this.button_adicionarTorneio.TabIndex = 17;
            this.button_adicionarTorneio.Text = "Adicionar ";
            this.button_adicionarTorneio.UseVisualStyleBackColor = true;
            this.button_adicionarTorneio.Click += new System.EventHandler(this.button_adicionarTorneio_Click);
            // 
            // listbox_torneios
            // 
            this.listbox_torneios.FormattingEnabled = true;
            this.listbox_torneios.Location = new System.Drawing.Point(12, 19);
            this.listbox_torneios.Name = "listbox_torneios";
            this.listbox_torneios.Size = new System.Drawing.Size(120, 225);
            this.listbox_torneios.TabIndex = 16;
            // 
            // GestaoTorneiosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_eliminarTorneio);
            this.Controls.Add(this.button_editarTorneio);
            this.Controls.Add(this.button_adicionarTorneio);
            this.Controls.Add(this.listbox_torneios);
            this.Name = "GestaoTorneiosForm";
            this.Text = "GestaoTorneiosForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_eliminarTorneio;
        private System.Windows.Forms.Button button_editarTorneio;
        private System.Windows.Forms.Button button_adicionarTorneio;
        private System.Windows.Forms.ListBox listbox_torneios;
    }
}