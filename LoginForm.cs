using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ase77146774_2
{
    public partial class LoginForm : Form
    {
        DbEntities db;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            db = new DbEntities();
            userstblBindingSource.DataSource = db.Users_tbl.ToList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter your username or password.","Message",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            if (string.IsNullOrEmpty(selectRole.Text))
            {
                MessageBox.Show("Please select your role.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                selectRole.Focus();
            }
            try
            {
                using(db = new DbEntities())
                {
                    var query = from o in db.Users_tbl where o.username == txtUsername.Text && 
                                o.password == txtPassword.Text && o.role == selectRole.Text
                                select o;
                    if(query.SingleOrDefault() != null)
                    {
                        if(selectRole.Text == "Admin" || selectRole.Text == "admin")
                        {
                            AdminForm AdminForm = new AdminForm();
                            AdminForm.Show();
                            this.Hide();
                        }else if(selectRole.Text == "Tester" || selectRole.Text == "tester")
                        {
                            TesterForm TesterForm = new TesterForm();
                            TesterForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            Session.user = txtUsername.Text;
                            DeveloperForm DeveloperForm = new DeveloperForm();
                            DeveloperForm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password. Also be sure to check your correct role.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                selectRole.Focus();
        }
    }
}
