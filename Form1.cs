using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        Database1Entities dbe = new Database1Entities();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsernameLogin.Text == "" || txtPasswordLogin.Text == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            tblLogin l = new tblLogin();

            foreach (var p in dbe.tblLogin)
            {
                if (p.Username == txtUsernameLogin.Text && p.Password == txtPasswordLogin.Text)
                {
                    MessageBox.Show("Successfully Logged In.");

                    ContentForm c = new ContentForm();

                    var query = from g in dbe.tblLogin select g;

                    var queryList = query.ToList();

                    c.dataGridView1.DataSource = queryList;

                    c.Show();

                    return;
                }
            }
            foreach (var p in dbe.tblLogin)
            {
                if (p.Username != txtUsernameLogin.Text || p.Password != txtPasswordLogin.Text)
                {
                    MessageBox.Show("Wrong Username and/or Password.");
                    return;
                }
            }
        }

        private void linkToRegisterForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm r = new RegisterForm();
            if (r.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var query = from g in dbe.tblLogin select g;
            var queryList = query.ToList();
            dataGridView1.DataSource = queryList;
        }
        
        


    }
}
