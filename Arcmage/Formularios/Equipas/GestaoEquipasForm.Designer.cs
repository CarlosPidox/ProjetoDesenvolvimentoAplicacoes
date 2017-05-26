namespace Arcmage
{
    partial class GestaoEquipasForm
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
            this.button_eliminarEquipa = new System.Windows.Forms.Button();
            this.button_editarEquipa = new System.Windows.Forms.Button();
            this.button_adicionarEquipa = new System.Windows.Forms.Button();
            this.listbox_equipas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_eliminarEquipa
            // 
            this.button_eliminarEquipa.Location = new System.Drawing.Point(151, 77);
            this.button_eliminarEquipa.Name = "button_eliminarEquipa";
            this.button_eliminarEquipa.Size = new System.Drawing.Size(121, 23);
            this.button_eliminarEquipa.TabIndex = 15;
            this.button_eliminarEquipa.Text = "Eliminar Selecionado";
            this.button_eliminarEquipa.UseVisualStyleBackColor = true;
            // 
            // button_editarEquipa
            // 
            this.button_editarEquipa.Location = new System.Drawing.Point(151, 48);
            this.button_editarEquipa.Name = "button_editarEquipa";
            this.button_editarEquipa.Size = new System.Drawing.Size(121, 23);
            this.button_editarEquipa.TabIndex = 14;
            this.button_editarEquipa.Text = "Editar Selecionado";
            this.button_editarEquipa.UseVisualStyleBackColor = true;
            this.button_editarEquipa.Click += new System.EventHandler(this.button_editarEquipa_Click);
            // 
            // button_adicionarEquipa
            // 
            this.button_adicionarEquipa.Location = new System.Drawing.Point(151, 19);
            this.button_adicionarEquipa.Name = "button_adicionarEquipa";
            this.button_adicionarEquipa.Size = new System.Drawing.Size(121, 23);
            this.button_adicionarEquipa.TabIndex = 13;
            this.button_adicionarEquipa.Text = "Adicionar ";
            this.button_adicionarEquipa.UseVisualStyleBackColor = true;
            this.button_adicionarEquipa.Click += new System.EventHandler(this.button_adicionarEquipa_Click);
            // 
            // listbox_equipas
            // 
            this.listbox_equipas.FormattingEnabled = true;
            this.listbox_equipas.Location = new System.Drawing.Point(12, 19);
            this.listbox_equipas.Name = "listbox_equipas";
            this.listbox_equipas.Size = new System.Drawing.Size(120, 225);
            this.listbox_equipas.TabIndex = 12;
            // 
            // GestaoEquipasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 279);
            this.Controls.Add(this.button_eliminarEquipa);
            this.Controls.Add(this.button_editarEquipa);
            this.Controls.Add(this.button_adicionarEquipa);
            this.Controls.Add(this.listbox_equipas);
            this.Name = "GestaoEquipasForm";
            this.Text = "GestaoEquipasForm";
            this.Load += new System.EventHandler(this.GestaoEquipasForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_eliminarEquipa;
        private System.Windows.Forms.Button button_editarEquipa;
        private System.Windows.Forms.Button button_adicionarEquipa;
        private System.Windows.Forms.ListBox listbox_equipas;
    }
}