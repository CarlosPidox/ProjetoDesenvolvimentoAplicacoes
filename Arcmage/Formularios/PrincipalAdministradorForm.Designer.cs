namespace Arcmage
{
    partial class PrincipalAdministradorForm
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
            this.button_gestaoUtilizadores = new System.Windows.Forms.Button();
            this.button_gestaoEquipas = new System.Windows.Forms.Button();
            this.button_gestaoJogadores = new System.Windows.Forms.Button();
            this.button_gestaoTorneios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_gestaoUtilizadores
            // 
            this.button_gestaoUtilizadores.Location = new System.Drawing.Point(12, 12);
            this.button_gestaoUtilizadores.Name = "button_gestaoUtilizadores";
            this.button_gestaoUtilizadores.Size = new System.Drawing.Size(129, 23);
            this.button_gestaoUtilizadores.TabIndex = 0;
            this.button_gestaoUtilizadores.Text = "Gestão de Utilizadores";
            this.button_gestaoUtilizadores.UseVisualStyleBackColor = true;
            this.button_gestaoUtilizadores.Click += new System.EventHandler(this.button_gestaoUtilizadores_Click);
            // 
            // button_gestaoEquipas
            // 
            this.button_gestaoEquipas.Location = new System.Drawing.Point(178, 12);
            this.button_gestaoEquipas.Name = "button_gestaoEquipas";
            this.button_gestaoEquipas.Size = new System.Drawing.Size(129, 23);
            this.button_gestaoEquipas.TabIndex = 1;
            this.button_gestaoEquipas.Text = "Gestão de Equipas";
            this.button_gestaoEquipas.UseVisualStyleBackColor = true;
            this.button_gestaoEquipas.Click += new System.EventHandler(this.button_gestaoEquipas_Click);
            // 
            // button_gestaoJogadores
            // 
            this.button_gestaoJogadores.Location = new System.Drawing.Point(12, 55);
            this.button_gestaoJogadores.Name = "button_gestaoJogadores";
            this.button_gestaoJogadores.Size = new System.Drawing.Size(129, 23);
            this.button_gestaoJogadores.TabIndex = 2;
            this.button_gestaoJogadores.Text = "Gestão de Jogadores";
            this.button_gestaoJogadores.UseVisualStyleBackColor = true;
            this.button_gestaoJogadores.Click += new System.EventHandler(this.button_gestaoJogadores_Click);
            // 
            // button_gestaoTorneios
            // 
            this.button_gestaoTorneios.Location = new System.Drawing.Point(178, 55);
            this.button_gestaoTorneios.Name = "button_gestaoTorneios";
            this.button_gestaoTorneios.Size = new System.Drawing.Size(129, 23);
            this.button_gestaoTorneios.TabIndex = 3;
            this.button_gestaoTorneios.Text = "Gestão de Torneios";
            this.button_gestaoTorneios.UseVisualStyleBackColor = true;
            this.button_gestaoTorneios.Click += new System.EventHandler(this.button_gestaoTorneios_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gestão de Cartas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EventoGestaoCarta);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Gestão de Baralhos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PrincipalAdministradorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 139);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_gestaoTorneios);
            this.Controls.Add(this.button_gestaoJogadores);
            this.Controls.Add(this.button_gestaoEquipas);
            this.Controls.Add(this.button_gestaoUtilizadores);
            this.Name = "PrincipalAdministradorForm";
            this.Text = "PrincipalAdministradorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_gestaoUtilizadores;
        private System.Windows.Forms.Button button_gestaoEquipas;
        private System.Windows.Forms.Button button_gestaoJogadores;
        private System.Windows.Forms.Button button_gestaoTorneios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}