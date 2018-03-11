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
    public partial class RegistrForm : Form
    {
        public RegistrForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = name_regist.Text;
            string email = email_regist.Text;
            string username = username_regist.Text;
            string password = password_regist.Text;
            string conf_pass = conf_pass_regist.Text;
            User users = new User(name, email, username, password);

            if (name == String.Empty && email == String.Empty && username == String.Empty && password == String.Empty && conf_pass == String.Empty)
            {
                MessageBox.Show("Butun xanalari doldurun!");
                }
             else   if (password == conf_pass && name != String.Empty && email != String.Empty && username != String.Empty && password != String.Empty && conf_pass != String.Empty)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else if (password != conf_pass)
            {
                MessageBox.Show("Sifreler ust uste dushmur");

            }
        }

        private void RegistrForm_Load(object sender, EventArgs e)
        {
            password_regist.PasswordChar = '*';
            conf_pass_regist.PasswordChar = '*';
        }
    }
    class User
    {
        public static List<User> users_list = new List<User>();
        public string Name;
        public string Email;
        public string Username;
        public string Password;
        public User(string _name, string _email, string _username, string _pass)
        {
            Name = _name;
            Email = _email;
            Username = _username;
            Password = _pass;
            users_list.Add(this);
        }
    }
}

