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
    public partial class TesterForm : Form
    {
        DbEntities db;
        public TesterForm()
        {
            InitializeComponent();
        }

        private void btnSubmitBug_Click(object sender, EventArgs e)
        {
            db = new DbEntities();
            if (
                txtProdName.Text == "" ||
                txtBugName.Text == "" ||
                richTxtBugDesc.Text == "" ||
                richTxtSyntax.Text == ""
                )
            {
                MessageBox.Show("Please fill every field to submit the bug.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var a = new Bugs_tbl()
                    {
                        prod_name = txtProdName.Text,
                        bug_name = txtBugName.Text,
                        bug_desc = richTxtBugDesc.Text,
                        syntax = richTxtSyntax.Text,
                        status = "Pending",
                        date = dateTimePicker1.Value,
                    };
                    db.Bugs_tbl.Add(a);
                    db.SaveChanges();
                    MessageBox.Show("Bug has been added successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Tester_Load(object sender, EventArgs e)
        {

        }
    }
}
