using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NailBar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            var login = log_user.Text;
            var password = log_pass.Text;
            if (login=="admin"&&password=="12345")
            {
                var adminpanel_form = new AdminPanel();
                adminpanel_form.Show();
                this.Hide();
            }
           
            foreach (var item in User.users_list)
            {
                if (login == item.Username && password == item.Password && login != null &&password != null)
                {
                    client_form clin_form = new client_form();
                    clin_form.Show();
                    this.Hide();
                }
                else
                {
                    error_label.Text = "*Enter correct username or password";
                }
            }
        }

        private void registr_btn_Click(object sender, EventArgs e)
        {
            RegistrForm reg_form = new RegistrForm();
            reg_form.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            log_pass.PasswordChar = '*';
        }
    }
}
