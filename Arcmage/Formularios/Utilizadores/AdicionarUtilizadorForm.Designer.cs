namespace Arcmage
{
    partial class AdicionarUtilizadorForm
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
            this.pictureBox_avatar = new System.Windows.Forms.PictureBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_nomeEmail = new System.Windows.Forms.Label();
            this.textBox_nomeEmail = new System.Windows.Forms.TextBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.button_removerAvatar = new System.Windows.Forms.Button();
            this.comboBox_tipoUtilizador = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_avatar
            // 
            this.pictureBox_avatar.Image = global::Arcmage.Properties.Resources.AddAvatar;
            this.pictureBox_avatar.Location = new System.Drawing.Point(199, 12);
            this.pictureBox_avatar.Name = "pictureBox_avatar";
            this.pictureBox_avatar.Size = new System.Drawing.Size(99, 84);
            this.pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_avatar.TabIndex = 1;
            this.pictureBox_avatar.TabStop = false;
            this.pictureBox_avatar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(76, 54);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(117, 20);
            this.textBox_username.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(76, 80);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(117, 20);
            this.textBox_password.TabIndex = 4;
            // 
            // label_nomeEmail
            // 
            this.label_nomeEmail.AutoSize = true;
            this.label_nomeEmail.Location = new System.Drawing.Point(20, 109);
            this.label_nomeEmail.Name = "label_nomeEmail";
            this.label_nomeEmail.Size = new System.Drawing.Size(32, 13);
            this.label_nomeEmail.TabIndex = 7;
            this.label_nomeEmail.Text = "Email";
            // 
            // textBox_nomeEmail
            // 
            this.textBox_nomeEmail.Location = new System.Drawing.Point(76, 106);
            this.textBox_nomeEmail.Name = "textBox_nomeEmail";
            this.textBox_nomeEmail.Size = new System.Drawing.Size(222, 20);
            this.textBox_nomeEmail.TabIndex = 6;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(223, 141);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 8;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_adicionar
            // 
            this.button_adicionar.Location = new System.Drawing.Point(142, 141);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(75, 23);
            this.button_adicionar.TabIndex = 9;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
            // 
            // button_removerAvatar
            // 
            this.button_removerAvatar.Location = new System.Drawing.Point(171, 12);
            this.button_removerAvatar.Name = "button_removerAvatar";
            this.button_removerAvatar.Size = new System.Drawing.Size(22, 23);
            this.button_removerAvatar.TabIndex = 10;
            this.button_removerAvatar.Text = "x";
            this.button_removerAvatar.UseVisualStyleBackColor = true;
            // 
            // comboBox_tipoUtilizador
            // 
            this.comboBox_tipoUtilizador.FormattingEnabled = true;
            this.comboBox_tipoUtilizador.Items.AddRange(new object[] {
            "Administrador",
            "Árbitro"});
            this.comboBox_tipoUtilizador.Location = new System.Drawing.Point(23, 12);
            this.comboBox_tipoUtilizador.Name = "comboBox_tipoUtilizador";
            this.comboBox_tipoUtilizador.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tipoUtilizador.TabIndex = 0;
            this.comboBox_tipoUtilizador.Text = "Administrador";
            this.comboBox_tipoUtilizador.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipoUtilizador_SelectedIndexChanged);
            // 
            // AdicionarUtilizadorForm
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
            this.Controls.Add(this.comboBox_tipoUtilizador);
            this.Name = "AdicionarUtilizadorForm";
            this.Text = "AdicionarUtilizador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_avatar;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_nomeEmail;
        private System.Windows.Forms.TextBox textBox_nomeEmail;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.Button button_removerAvatar;
        private System.Windows.Forms.ComboBox comboBox_tipoUtilizador;
    }
}