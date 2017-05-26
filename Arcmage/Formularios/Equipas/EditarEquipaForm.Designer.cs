namespace Arcmage
{
    partial class EditarEquipaForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listbox_jogadoresEquipa = new System.Windows.Forms.ListBox();
            this.listbox_jogadores = new System.Windows.Forms.ListBox();
            this.button_removerAvatar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.pictureBox_avatar = new System.Windows.Forms.PictureBox();
            this.button_equipa = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listbox_jogadoresEquipa
            // 
            this.listbox_jogadoresEquipa.FormattingEnabled = true;
            this.listbox_jogadoresEquipa.Location = new System.Drawing.Point(219, 124);
            this.listbox_jogadoresEquipa.Name = "listbox_jogadoresEquipa";
            this.listbox_jogadoresEquipa.Size = new System.Drawing.Size(120, 199);
            this.listbox_jogadoresEquipa.TabIndex = 24;
            // 
            // listbox_jogadores
            // 
            this.listbox_jogadores.FormattingEnabled = true;
            this.listbox_jogadores.Location = new System.Drawing.Point(12, 124);
            this.listbox_jogadores.Name = "listbox_jogadores";
            this.listbox_jogadores.Size = new System.Drawing.Size(120, 199);
            this.listbox_jogadores.TabIndex = 23;
            // 
            // button_removerAvatar
            // 
            this.button_removerAvatar.Location = new System.Drawing.Point(212, 15);
            this.button_removerAvatar.Name = "button_removerAvatar";
            this.button_removerAvatar.Size = new System.Drawing.Size(22, 23);
            this.button_removerAvatar.TabIndex = 22;
            this.button_removerAvatar.Text = "x";
            this.button_removerAvatar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(44, 12);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(86, 20);
            this.textBox_username.TabIndex = 20;
            // 
            // pictureBox_avatar
            // 
            this.pictureBox_avatar.Image = global::Arcmage.Properties.Resources.AddAvatar;
            this.pictureBox_avatar.Location = new System.Drawing.Point(240, 15);
            this.pictureBox_avatar.Name = "pictureBox_avatar";
            this.pictureBox_avatar.Size = new System.Drawing.Size(99, 84);
            this.pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_avatar.TabIndex = 19;
            this.pictureBox_avatar.TabStop = false;
            // 
            // button_equipa
            // 
            this.button_equipa.Location = new System.Drawing.Point(183, 333);
            this.button_equipa.Name = "button_equipa";
            this.button_equipa.Size = new System.Drawing.Size(75, 23);
            this.button_equipa.TabIndex = 28;
            this.button_equipa.Text = "Adicionar";
            this.button_equipa.UseVisualStyleBackColor = true;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(264, 333);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 27;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // EditarEquipaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 359);
            this.Controls.Add(this.button_equipa);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listbox_jogadoresEquipa);
            this.Controls.Add(this.listbox_jogadores);
            this.Controls.Add(this.button_removerAvatar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.pictureBox_avatar);
            this.Name = "EditarEquipaForm";
            this.Text = "EditarEquipaForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listbox_jogadoresEquipa;
        private System.Windows.Forms.ListBox listbox_jogadores;
        private System.Windows.Forms.Button button_removerAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.PictureBox pictureBox_avatar;
        private System.Windows.Forms.Button button_equipa;
        private System.Windows.Forms.Button button_cancelar;
    }
}