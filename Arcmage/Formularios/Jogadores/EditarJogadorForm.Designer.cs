namespace Arcmage
{
    partial class EditarJogadorForm
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
            this.numericUpDown_idade = new System.Windows.Forms.NumericUpDown();
            this.textBox_nickname = new System.Windows.Forms.TextBox();
            this.label_idade = new System.Windows.Forms.Label();
            this.button_removerAvatar = new System.Windows.Forms.Button();
            this.button_editarJogador = new System.Windows.Forms.Button();
            this.button_cancelarJogador = new System.Windows.Forms.Button();
            this.label_nickname = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_emailJogador = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nomeJogador = new System.Windows.Forms.TextBox();
            this.pictureBox_avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_idade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_idade
            // 
            this.numericUpDown_idade.Location = new System.Drawing.Point(70, 33);
            this.numericUpDown_idade.Name = "numericUpDown_idade";
            this.numericUpDown_idade.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_idade.TabIndex = 36;
            // 
            // textBox_nickname
            // 
            this.textBox_nickname.Location = new System.Drawing.Point(70, 6);
            this.textBox_nickname.Name = "textBox_nickname";
            this.textBox_nickname.Size = new System.Drawing.Size(75, 20);
            this.textBox_nickname.TabIndex = 35;
            // 
            // label_idade
            // 
            this.label_idade.AutoSize = true;
            this.label_idade.Location = new System.Drawing.Point(12, 31);
            this.label_idade.Name = "label_idade";
            this.label_idade.Size = new System.Drawing.Size(34, 13);
            this.label_idade.TabIndex = 34;
            this.label_idade.Text = "Idade";
            // 
            // button_removerAvatar
            // 
            this.button_removerAvatar.Location = new System.Drawing.Point(215, 12);
            this.button_removerAvatar.Name = "button_removerAvatar";
            this.button_removerAvatar.Size = new System.Drawing.Size(22, 23);
            this.button_removerAvatar.TabIndex = 33;
            this.button_removerAvatar.Text = "x";
            this.button_removerAvatar.UseVisualStyleBackColor = true;
            this.button_removerAvatar.Click += new System.EventHandler(this.button_removerAvatar_Click);
            // 
            // button_editarJogador
            // 
            this.button_editarJogador.Location = new System.Drawing.Point(186, 115);
            this.button_editarJogador.Name = "button_editarJogador";
            this.button_editarJogador.Size = new System.Drawing.Size(75, 23);
            this.button_editarJogador.TabIndex = 32;
            this.button_editarJogador.Text = "Editar";
            this.button_editarJogador.UseVisualStyleBackColor = true;
            this.button_editarJogador.Click += new System.EventHandler(this.button_editarJogador_Click);
            // 
            // button_cancelarJogador
            // 
            this.button_cancelarJogador.Location = new System.Drawing.Point(267, 115);
            this.button_cancelarJogador.Name = "button_cancelarJogador";
            this.button_cancelarJogador.Size = new System.Drawing.Size(75, 23);
            this.button_cancelarJogador.TabIndex = 31;
            this.button_cancelarJogador.Text = "Cancelar";
            this.button_cancelarJogador.UseVisualStyleBackColor = true;
            this.button_cancelarJogador.Click += new System.EventHandler(this.button_cancelarJogador_Click);
            // 
            // label_nickname
            // 
            this.label_nickname.AutoSize = true;
            this.label_nickname.Location = new System.Drawing.Point(12, 9);
            this.label_nickname.Name = "label_nickname";
            this.label_nickname.Size = new System.Drawing.Size(55, 13);
            this.label_nickname.TabIndex = 30;
            this.label_nickname.Text = "Nickname";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(11, 88);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(32, 13);
            this.label_email.TabIndex = 29;
            this.label_email.Text = "Email";
            // 
            // textBox_emailJogador
            // 
            this.textBox_emailJogador.Location = new System.Drawing.Point(52, 88);
            this.textBox_emailJogador.Name = "textBox_emailJogador";
            this.textBox_emailJogador.Size = new System.Drawing.Size(185, 20);
            this.textBox_emailJogador.TabIndex = 28;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(11, 62);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(35, 13);
            this.label_nome.TabIndex = 27;
            this.label_nome.Text = "Nome";
            // 
            // textBox_nomeJogador
            // 
            this.textBox_nomeJogador.Location = new System.Drawing.Point(52, 59);
            this.textBox_nomeJogador.Name = "textBox_nomeJogador";
            this.textBox_nomeJogador.Size = new System.Drawing.Size(185, 20);
            this.textBox_nomeJogador.TabIndex = 26;
            // 
            // pictureBox_avatar
            // 
            this.pictureBox_avatar.Image = global::Arcmage.Properties.Resources.AddAvatar;
            this.pictureBox_avatar.Location = new System.Drawing.Point(243, 12);
            this.pictureBox_avatar.Name = "pictureBox_avatar";
            this.pictureBox_avatar.Size = new System.Drawing.Size(99, 84);
            this.pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_avatar.TabIndex = 25;
            this.pictureBox_avatar.TabStop = false;
            this.pictureBox_avatar.Click += new System.EventHandler(this.pictureBox_avatar_Click);
            // 
            // EditarJogadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 146);
            this.Controls.Add(this.numericUpDown_idade);
            this.Controls.Add(this.textBox_nickname);
            this.Controls.Add(this.label_idade);
            this.Controls.Add(this.button_removerAvatar);
            this.Controls.Add(this.button_editarJogador);
            this.Controls.Add(this.button_cancelarJogador);
            this.Controls.Add(this.label_nickname);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_emailJogador);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.textBox_nomeJogador);
            this.Controls.Add(this.pictureBox_avatar);
            this.Name = "EditarJogadorForm";
            this.Text = "EditarJogadorForm";
            this.Load += new System.EventHandler(this.EditarJogadorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_idade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_idade;
        private System.Windows.Forms.TextBox textBox_nickname;
        private System.Windows.Forms.Label label_idade;
        private System.Windows.Forms.Button button_removerAvatar;
        private System.Windows.Forms.Button button_editarJogador;
        private System.Windows.Forms.Button button_cancelarJogador;
        private System.Windows.Forms.Label label_nickname;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_emailJogador;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nomeJogador;
        private System.Windows.Forms.PictureBox pictureBox_avatar;
    }
}