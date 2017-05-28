namespace Arcmage
{
    partial class GestaoCartasForm
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
            this.button_eliminarCarta = new System.Windows.Forms.Button();
            this.button_editarCarta = new System.Windows.Forms.Button();
            this.button_adicionarCartas = new System.Windows.Forms.Button();
            this.listbox_cartas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_eliminarCarta
            // 
            this.button_eliminarCarta.Location = new System.Drawing.Point(151, 77);
            this.button_eliminarCarta.Name = "button_eliminarCarta";
            this.button_eliminarCarta.Size = new System.Drawing.Size(121, 23);
            this.button_eliminarCarta.TabIndex = 7;
            this.button_eliminarCarta.Text = "Eliminar Selecionado";
            this.button_eliminarCarta.UseVisualStyleBackColor = true;
            this.button_eliminarCarta.Click += new System.EventHandler(this.EventoEliminarCarta);
            // 
            // button_editarCarta
            // 
            this.button_editarCarta.Location = new System.Drawing.Point(151, 48);
            this.button_editarCarta.Name = "button_editarCarta";
            this.button_editarCarta.Size = new System.Drawing.Size(121, 23);
            this.button_editarCarta.TabIndex = 6;
            this.button_editarCarta.Text = "Editar Selecionado";
            this.button_editarCarta.UseVisualStyleBackColor = true;
            this.button_editarCarta.Click += new System.EventHandler(this.EventoEditarCarta);
            // 
            // button_adicionarCartas
            // 
            this.button_adicionarCartas.Location = new System.Drawing.Point(151, 19);
            this.button_adicionarCartas.Name = "button_adicionarCartas";
            this.button_adicionarCartas.Size = new System.Drawing.Size(121, 23);
            this.button_adicionarCartas.TabIndex = 5;
            this.button_adicionarCartas.Text = "Adicionar ";
            this.button_adicionarCartas.UseVisualStyleBackColor = true;
            this.button_adicionarCartas.Click += new System.EventHandler(this.EventoAdicionarCarta);
            // 
            // listbox_cartas
            // 
            this.listbox_cartas.FormattingEnabled = true;
            this.listbox_cartas.Location = new System.Drawing.Point(12, 19);
            this.listbox_cartas.Name = "listbox_cartas";
            this.listbox_cartas.Size = new System.Drawing.Size(120, 225);
            this.listbox_cartas.TabIndex = 4;
            this.listbox_cartas.SelectedIndexChanged += new System.EventHandler(this.listbox_cartas_SelectedIndexChanged);
            this.listbox_cartas.DoubleClick += new System.EventHandler(this.EventoEditarCarta);
            // 
            // GestaoCartasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_eliminarCarta);
            this.Controls.Add(this.button_editarCarta);
            this.Controls.Add(this.button_adicionarCartas);
            this.Controls.Add(this.listbox_cartas);
            this.Name = "GestaoCartasForm";
            this.Text = "GestaoCartasForm";
            this.Load += new System.EventHandler(this.GestaoCartasForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_eliminarCarta;
        private System.Windows.Forms.Button button_editarCarta;
        private System.Windows.Forms.Button button_adicionarCartas;
        private System.Windows.Forms.ListBox listbox_cartas;
    }
}