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
    public partial class AdminForm : Form
    {
        DbEntities db;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Admin_panel_Load(object sender, EventArgs e)
        {
            combStoreUsername.Hide();
            panelAssignBug.Show();
            btnSubmitChanges.Hide();
            panelAssignBug.Enabled = false;
            panelEditBugInfo.Enabled = false;
            txtUsername.ReadOnly = true;      
            db = new DbEntities(); // initilize database
            // filling datagridviews with data from database tables
            userstblBindingSource.DataSource = db.Users_tbl.ToList();
            bugstblBindingSource.DataSource = db.Bugs_tbl.ToList();
            assignedBugstblBindingSource.DataSource = db.AssignedBugs_tbl.ToList();
        }

        private void btnAssignBug_Click(object sender, EventArgs e)
        {
            db = new DbEntities();
            var fname = selectAssignTo.Text;
            var uname = combStoreUsername.Text;
            var query = from o in db.AssignedBugs_tbl where o.bug_id == lblBugId.Text && o.fullname == fname select o;
            // check if the bug has already been assigned to the developer
            if (query.SingleOrDefault() != null)
            {
                MessageBox.Show("You have already assigned this bug to developer '" + fname + "'. If you still want to assign same bug, then assign to him/her by clicking Edit.","Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAssignBug.Hide();
            }
            else
            {
                var a = new AssignedBugs_tbl()
                {
                    prod_name = txtProdName.Text,
                    bug_name = txtBugName.Text,
                    bug_desc = richTxtBugDesc.Text,
                    syntax = "Syntax",
                    status = "Assigned",
                    bug_id = lblBugId.Text,
                    username = uname,
                    fullname = fname,
                };
                db.AssignedBugs_tbl.Add(a);
                db.SaveChanges();
                MessageBox.Show("Bug '" + txtBugName.Text + "' has been assigned successfully to developer '" + fname + "' !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_bug_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new DbEntities();
            if (dataGridView_bug_list.Columns[e.ColumnIndex].Name == "Assign")
            {
                panelAssignBug.Show();
                panelAssignBug.Enabled = true;

                // fetch data from datagridview through row and cell's index number
                /* lblBugId.Text = dataGridView_bug_list.Rows[e.RowIndex].Cells["id"].Value.ToString();*/
                int rowindex = dataGridView_bug_list.CurrentCell.RowIndex; //current row
                lblBugId.Text = dataGridView_bug_list.Rows[rowindex].Cells[0].Value.ToString();
                txtProdName.Text = dataGridView_bug_list.Rows[rowindex].Cells[1].Value.ToString();
                txtBugName.Text = dataGridView_bug_list.Rows[rowindex].Cells[2].Value.ToString();
                richTxtBugDesc.Text = dataGridView_bug_list.Rows[rowindex].Cells[3].Value.ToString();
                btnAssignBug.Show();
                // display values in combobox selectAssignTo
                var query = from o in db.Users_tbl where o.role == "Developer" select o;
                selectAssignTo.DataSource = query.ToList();
                selectAssignTo.DisplayMember = "fullname";
                selectAssignTo.ValueMember = "id";             
            }
        }

        private void btnEditBugInfo_Click(object sender, EventArgs e)
        {
            db = new DbEntities();
            panelEditBugInfo.Enabled = true;

            var query = from o in db.AssignedBugs_tbl where o.bug_id == lblBugId.Text select o;

            if(query.FirstOrDefault() != null)
            {
                btnSubmitChanges.Show();
                btnAssignBug.Hide();
            }
            else
            {
                btnSubmitChanges.Hide();
                btnAssignBug.Show();
            }
        }

        private void selectAssignTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new DbEntities();
            var query = from o in db.Users_tbl where o.role == "Developer" && o.fullname == selectAssignTo.Text select o;
            combStoreUsername.DataSource = query.ToList();
            combStoreUsername.DisplayMember = "username";
            combStoreUsername.ValueMember = "id";
            txtUsername.Text = combStoreUsername.Text;
        }

        private void btnSubmitChanges_Click(object sender, EventArgs e)
        {
            db = new DbEntities();
            var fname = selectAssignTo.Text;
            var uname = combStoreUsername.Text;
            var query = from o in db.AssignedBugs_tbl where o.bug_id == lblBugId.Text && 
                        o.username == uname && o.fullname == fname select o;
            // temporarily save changes
            foreach (AssignedBugs_tbl o in query)
            {
                o.prod_name = txtProdName.Text;
                o.bug_name = txtBugName.Text;
                o.bug_desc = richTxtBugDesc.Text;
                o.syntax = "Syntax";
                o.status = "Assigned";
                o.bug_id = lblBugId.Text;
                o.username = uname;
                o.fullname = fname;
            }
            // saving the changes 
            try
            {
                db.SaveChanges();
                btnSubmitChanges.Hide();
                panelEditBugInfo.Enabled = false;
                MessageBox.Show("Your edit has been submitted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                assignedBugstblBindingSource.DataSource = db.AssignedBugs_tbl.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
