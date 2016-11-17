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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        Database1Entities dbe = new Database1Entities();

        private void btnOkRegister_Click(object sender, EventArgs e)
        {
                if (txtUsernameRegister.Text == "" || txtPasswordRegister.Text == "")
            {
                MessageBox.Show("Username and password must be filled out.");
                return;
            }
            tblLogin l = new tblLogin();
            foreach (var p in dbe.tblLogin)
            {
                if (p.Username == txtUsernameRegister.Text)
                {
                    MessageBox.Show("Username already exists, please pick another one.");
                    return;
                }
                else
                {
                    l.Username = txtUsernameRegister.Text;
                    l.Password = txtPasswordRegister.Text;
                    l.Name = txtNameRegister.Text;
                    l.Surname = txtSurnameRegister.Text;
                    l.Email = txtEmailRegister.Text;

                    dbe.tblLogin.Add(l);

                    dbe.SaveChanges();

                    MessageBox.Show("Successfully registered.");
                    break;
                }
            }
            ContentForm c = new ContentForm();

            var query = from g in dbe.tblLogin select g;

            var queryList = query.ToList();

            c.dataGridView1.DataSource = queryList;

            c.Show();
            
            
          }
       }


}

