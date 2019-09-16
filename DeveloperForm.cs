using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ase77146774_2
{
    public partial class DeveloperForm : Form
    {
        DbEntities db;
        public DeveloperForm()
        {
            InitializeComponent();
        }

        private void DeveloperForm_Load(object sender, EventArgs e)
        {
            db = new DbEntities();
            txtBugId.ReadOnly = true;
            txtProdName.ReadOnly = true;
            txtBugName.ReadOnly = true;
            richTxtBugDesc.ReadOnly = true;
            btnSubmit.Hide();
            // get logged in username, temporarily stored in session class
            var session_user = Session.user;
            assignedBugstblBindingSource.DataSource = db.AssignedBugs_tbl.ToList();
            var query = from o in assignedBugstblBindingSource.DataSource as List<AssignedBugs_tbl>
                        where o.username == session_user
                        select o;
            if(query.FirstOrDefault() != null)
            {
                dataGridAssignedTask.DataSource = query.ToList();
                btnSubmit.Show();
            }
            else
            {
                btnSubmit.Hide();
                MessageBox.Show("Dear, '" + session_user + "', you don't have any assigned task at the moment. Please check in later.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void dataGridAssignedTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridAssignedTask.CurrentCell.RowIndex; //current row
            txtBugId.Text = dataGridAssignedTask.Rows[rowindex].Cells[6].Value.ToString();
            txtProdName.Text = dataGridAssignedTask.Rows[rowindex].Cells[1].Value.ToString();
            txtBugName.Text = dataGridAssignedTask.Rows[rowindex].Cells[2].Value.ToString();
            richTxtBugDesc.Text = dataGridAssignedTask.Rows[rowindex].Cells[3].Value.ToString();
            richTxtSyntax.Text = dataGridAssignedTask.Rows[rowindex].Cells[4].Value.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            db = new DbEntities();
            var session_user = Session.user;
            int rowindex = dataGridAssignedTask.CurrentCell.RowIndex; //current row
            var uname = dataGridAssignedTask.Rows[rowindex].Cells[7].Value.ToString();
            var fname = dataGridAssignedTask.Rows[rowindex].Cells[8].Value.ToString();

            var query = from o in db.AssignedBugs_tbl where o.bug_id == txtBugId.Text &&
                        o.username == uname && o.fullname == fname select o;

            var query2 = from o in db.Bugs_tbl where o.id.ToString() == txtBugId.Text select o;

            //var query3 = from o in assignedBugstblBindingSource.DataSource as List<AssignedBugs_tbl>
             //            where o.username == session_user select o;

            if (
                txtBugId.Text == "" ||
                txtProdName.Text == "" ||
                txtBugName.Text == "" ||
                richTxtBugDesc.Text == "" ||
                richTxtSyntax.Text == ""
                )
            {
                MessageBox.Show("Please select bug in above datagrid to debug.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!chkboxSolved.Checked && !checkBoxUnsolved.Checked && !checkBoxInProgress.Checked)
            {
                MessageBox.Show("Please check either checkboxes as per the bug is solved or not.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(chkboxSolved.Checked && !checkBoxUnsolved.Checked && !checkBoxInProgress.Checked)
            {
               
                // temporarily save changes
                foreach (AssignedBugs_tbl o in query)
                {
                    o.syntax = richTxtSyntax.Text;
                    o.status = "Solved";
                }
                foreach (Bugs_tbl b in query2)
                {
                    b.status = "Closed";
                }
                // saving the changes 
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Your edit has been submitted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (checkBoxInProgress.Checked && !checkBoxUnsolved.Checked && !chkboxSolved.Checked)
            {
                // temporarily save changes
                foreach (AssignedBugs_tbl o in query)
                {
                    o.syntax = richTxtSyntax.Text;
                    o.status = "In Progress";
                }
                foreach (Bugs_tbl b in query2)
                {
                    b.status = "In Progress";
                }
                // saving the changes 
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Your edit has been submitted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (checkBoxUnsolved.Checked && !checkBoxInProgress.Checked && !chkboxSolved.Checked)
            {
                // temporarily save changes
                foreach (AssignedBugs_tbl o in query)
                {
                    o.syntax = richTxtSyntax.Text;
                    o.status = "Unsolved";
                }
                foreach (Bugs_tbl b in query2)
                {
                    b.status = "Unsolved";
                }
                // saving the changes 
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Your edit has been submitted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please check one of the box not more than one to submit your work. Thank you!",
                    "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        
        private void richTxtSyntax_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex("class");
            Regex rxif = new Regex("if");
            Regex rxthen = new Regex("then");
            Regex rxelse = new Regex("else");
            Regex rxprivate = new Regex("private");
            Regex rxpublic = new Regex("public");
            Regex rxvoid = new Regex("void");
            Regex rxobject = new Regex("object");
            Regex rxforeach = new Regex("foreach");
            Regex rxfunction = new Regex("function");
            Regex rxvar = new Regex("var");
            Regex rxint = new Regex("int");
            Regex rxfloat = new Regex("float");
            Regex rxdouble = new Regex("double");
            Regex rxlong = new Regex("long");
            Regex rxstring = new Regex("string");
            Regex rxprint_r = new Regex("print_r");

            int index = richTxtSyntax.SelectionStart;

            foreach (Match m in rx.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxif.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxthen.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxelse.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxprivate.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxpublic.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxvoid.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxobject.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxforeach.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxfunction.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxvar.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxint.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxfloat.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxstring.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxlong.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxdouble.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
            foreach (Match m in rxprint_r.Matches(richTxtSyntax.Text))
            {
                richTxtSyntax.Select(m.Index, m.Value.Length);
                richTxtSyntax.SelectionColor = Color.Blue;
                richTxtSyntax.SelectionStart = index;
                richTxtSyntax.SelectionColor = Color.Gray;
            }
        }
    }
}
