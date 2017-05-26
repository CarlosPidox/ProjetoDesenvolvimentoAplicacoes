namespace Arcmage
{
    partial class GestaoJogadoresForm
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
            this.button_eliminarJogador = new System.Windows.Forms.Button();
            this.button_editarJogador = new System.Windows.Forms.Button();
            this.button_adicionarJogador = new System.Windows.Forms.Button();
            this.listbox_utilizadores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_eliminarJogador
            // 
            this.button_eliminarJogador.Location = new System.Drawing.Point(151, 77);
            this.button_eliminarJogador.Name = "button_eliminarJogador";
            this.button_eliminarJogador.Size = new System.Drawing.Size(121, 23);
            this.button_eliminarJogador.TabIndex = 15;
            this.button_eliminarJogador.Text = "Eliminar Selecionado";
            this.button_eliminarJogador.UseVisualStyleBackColor = true;
            // 
            // button_editarJogador
            // 
            this.button_editarJogador.Location = new System.Drawing.Point(151, 48);
            this.button_editarJogador.Name = "button_editarJogador";
            this.button_editarJogador.Size = new System.Drawing.Size(121, 23);
            this.button_editarJogador.TabIndex = 14;
            this.button_editarJogador.Text = "Editar Selecionado";
            this.button_editarJogador.UseVisualStyleBackColor = true;
            this.button_editarJogador.Click += new System.EventHandler(this.button_editarJogador_Click);
            // 
            // button_adicionarJogador
            // 
            this.button_adicionarJogador.Location = new System.Drawing.Point(151, 19);
            this.button_adicionarJogador.Name = "button_adicionarJogador";
            this.button_adicionarJogador.Size = new System.Drawing.Size(121, 23);
            this.button_adicionarJogador.TabIndex = 13;
            this.button_adicionarJogador.Text = "Adicionar ";
            this.button_adicionarJogador.UseVisualStyleBackColor = true;
            this.button_adicionarJogador.Click += new System.EventHandler(this.button_adicionarJogador_Click);
            // 
            // listbox_utilizadores
            // 
            this.listbox_utilizadores.FormattingEnabled = true;
            this.listbox_utilizadores.Location = new System.Drawing.Point(12, 19);
            this.listbox_utilizadores.Name = "listbox_utilizadores";
            this.listbox_utilizadores.Size = new System.Drawing.Size(120, 225);
            this.listbox_utilizadores.TabIndex = 12;
            // 
            // GestaoJogadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 279);
            this.Controls.Add(this.button_eliminarJogador);
            this.Controls.Add(this.button_editarJogador);
            this.Controls.Add(this.button_adicionarJogador);
            this.Controls.Add(this.listbox_utilizadores);
            this.Name = "GestaoJogadoresForm";
            this.Text = "GestaoJogadoresForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_eliminarJogador;
        private System.Windows.Forms.Button button_editarJogador;
        private System.Windows.Forms.Button button_adicionarJogador;
        private System.Windows.Forms.ListBox listbox_utilizadores;
    }
}