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
        }


        private void button_entrar_Click(object sender, EventArgs e)
        {

            PrincipalAdministradorForm form = new PrincipalAdministradorForm();
            DialogResult resultado = form.ShowDialog();
            /* foreach(Utilizador u in container.UtilizadorSet)
             {
                 if (textBox_utilizador.Text == u.Username)
                 {
                     if (textBox_password.Text == u.Password)
                     {
                         MessageBox.Show("Nice entrou");
                     }
                     else if (textBox_password.Text != u.Password)
                     {
                         MessageBox.Show("Password Errada");
                     }
                 }
                 else
                 {
                     MessageBox.Show("Não existe um utilizador com esse nome");
                 }
             }*/
        }
    }
}
