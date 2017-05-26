namespace Arcmage
{
    partial class GestaoUtilizadoresForm
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
            this.button_eliminarUtilizador = new System.Windows.Forms.Button();
            this.button_editarUtilizador = new System.Windows.Forms.Button();
            this.button_adicionarUtilizador = new System.Windows.Forms.Button();
            this.listbox_utilizadores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_eliminarUtilizador
            // 
            this.button_eliminarUtilizador.Location = new System.Drawing.Point(159, 85);
            this.button_eliminarUtilizador.Name = "button_eliminarUtilizador";
            this.button_eliminarUtilizador.Size = new System.Drawing.Size(121, 23);
            this.button_eliminarUtilizador.TabIndex = 11;
            this.button_eliminarUtilizador.Text = "Eliminar Selecionado";
            this.button_eliminarUtilizador.UseVisualStyleBackColor = true;
            // 
            // button_editarUtilizador
            // 
            this.button_editarUtilizador.Location = new System.Drawing.Point(159, 56);
            this.button_editarUtilizador.Name = "button_editarUtilizador";
            this.button_editarUtilizador.Size = new System.Drawing.Size(121, 23);
            this.button_editarUtilizador.TabIndex = 10;
            this.button_editarUtilizador.Text = "Editar Selecionado";
            this.button_editarUtilizador.UseVisualStyleBackColor = true;
            this.button_editarUtilizador.Click += new System.EventHandler(this.button_editarUtilizador_Click);
            // 
            // button_adicionarUtilizador
            // 
            this.button_adicionarUtilizador.Location = new System.Drawing.Point(159, 27);
            this.button_adicionarUtilizador.Name = "button_adicionarUtilizador";
            this.button_adicionarUtilizador.Size = new System.Drawing.Size(121, 23);
            this.button_adicionarUtilizador.TabIndex = 9;
            this.button_adicionarUtilizador.Text = "Adicionar ";
            this.button_adicionarUtilizador.UseVisualStyleBackColor = true;
            this.button_adicionarUtilizador.Click += new System.EventHandler(this.button_adicionarUtilizador_Click);
            // 
            // listbox_utilizadores
            // 
            this.listbox_utilizadores.FormattingEnabled = true;
            this.listbox_utilizadores.Location = new System.Drawing.Point(20, 27);
            this.listbox_utilizadores.Name = "listbox_utilizadores";
            this.listbox_utilizadores.Size = new System.Drawing.Size(120, 225);
            this.listbox_utilizadores.TabIndex = 8;
            // 
            // GestaoUtilizadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 279);
            this.Controls.Add(this.button_eliminarUtilizador);
            this.Controls.Add(this.button_editarUtilizador);
            this.Controls.Add(this.button_adicionarUtilizador);
            this.Controls.Add(this.listbox_utilizadores);
            this.Name = "GestaoUtilizadoresForm";
            this.Text = "GestaoUtilizadoresForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_eliminarUtilizador;
        private System.Windows.Forms.Button button_editarUtilizador;
        private System.Windows.Forms.Button button_adicionarUtilizador;
        private System.Windows.Forms.ListBox listbox_utilizadores;
    }
}