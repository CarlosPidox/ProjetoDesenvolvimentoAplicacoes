using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcmage
{
    public partial class LoginForm : Form
    {

        private DataModeloContainer container;
        public LoginForm()
        {
            InitializeComponent();
            container = new DataModeloContainer();

            /*Administrador admin = new Administrador
            {
                Id = 3,
                Username = "1",
                Password = "1",
                Email = "danielgod@hotmail.com"
            };
            container.UtilizadorSet.Add(admin);
            container.SaveChanges();*/
        }

        //Falta converter para sha512
        private void button_entrar_Click(object sender, EventArgs e)
        {
            bool login = false;

            Arbitro[] ab = container.UtilizadorSet.OfType<Arbitro>().ToArray();
            foreach (Arbitro a in ab)
            {
               if(a.Username == textBox_utilizador.Text)
                {
                    if(a.Password == textBox_password.Text)
                    {
                        login = true;
                        GestaoCartasForm form = new GestaoCartasForm();
                        form.ShowDialog();
                    }
                }
            }

            Administrador[] ad = container.UtilizadorSet.OfType<Administrador>().ToArray();
            foreach (Administrador a in ad)
            {
                if (a.Username == textBox_utilizador.Text)
                {
                    if (a.Password == textBox_password.Text)
                    {
                        login = true;
                        PrincipalAdministradorForm form = new PrincipalAdministradorForm();
                        form.ShowDialog();
                    }
                }
            }

            if(!login)
            {
                MessageBox.Show("Dados de acesso inválidos, por favor tente novamente");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
