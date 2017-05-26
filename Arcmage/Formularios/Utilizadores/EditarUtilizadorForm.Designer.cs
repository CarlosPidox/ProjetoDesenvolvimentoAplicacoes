namespace Arcmage
{
    partial class EditarUtilizadorForm
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
            this.button_removerAvatar = new System.Windows.Forms.Button();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.label_nomeEmail = new System.Windows.Forms.Label();
            this.textBox_nomeEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.pictureBox_avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // button_removerAvatar
            // 
            this.button_removerAvatar.Location = new System.Drawing.Point(167, 12);
            this.button_removerAvatar.Name = "button_removerAvatar";
            this.button_removerAvatar.Size = new System.Drawing.Size(22, 23);
            this.button_removerAvatar.TabIndex = 21;
            this.button_removerAvatar.Text = "x";
            this.button_removerAvatar.UseVisualStyleBackColor = true;
            // 
            // button_adicionar
            // 
            this.button_adicionar.Location = new System.Drawing.Point(138, 141);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(75, 23);
            this.button_adicionar.TabIndex = 20;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.UseVisualStyleBackColor = true;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(219, 141);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 19;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // label_nomeEmail
            // 
            this.label_nomeEmail.AutoSize = true;
            this.label_nomeEmail.Location = new System.Drawing.Point(16, 109);
            this.label_nomeEmail.Name = "label_nomeEmail";
            this.label_nomeEmail.Size = new System.Drawing.Size(32, 13);
            this.label_nomeEmail.TabIndex = 18;
            this.label_nomeEmail.Text = "Email";
            // 
            // textBox_nomeEmail
            // 
            this.textBox_nomeEmail.Location = new System.Drawing.Point(72, 106);
            this.textBox_nomeEmail.Name = "textBox_nomeEmail";
            this.textBox_nomeEmail.Size = new System.Drawing.Size(222, 20);
            this.textBox_nomeEmail.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(72, 80);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(117, 20);
            this.textBox_password.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(72, 54);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(117, 20);
            this.textBox_username.TabIndex = 13;
            // 
            // pictureBox_avatar
            // 
            this.pictureBox_avatar.Image = global::Arcmage.Properties.Resources.AddAvatar;
            this.pictureBox_avatar.Location = new System.Drawing.Point(195, 12);
            this.pictureBox_avatar.Name = "pictureBox_avatar";
            this.pictureBox_avatar.Size = new System.Drawing.Size(99, 84);
            this.pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_avatar.TabIndex = 12;
            this.pictureBox_avatar.TabStop = false;
            // 
            // EditarUtilizadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 176);
            this.Controls.Add(this.button_removerAvatar);
            this.Controls.Add(this.button_adicionar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.label_nomeEmail);
            this.Controls.Add(this.textBox_nomeEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.pictureBox_avatar);
            this.Name = "EditarUtilizadorForm";
            this.Text = "EditarUtilizadorForm";
            this.Load += new System.EventHandler(this.EditarUtilizadorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_removerAvatar;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Label label_nomeEmail;
        private System.Windows.Forms.TextBox textBox_nomeEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.PictureBox pictureBox_avatar;
    }
}