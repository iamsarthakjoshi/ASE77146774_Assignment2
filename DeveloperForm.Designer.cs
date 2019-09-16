namespace ase77146774_2
{
    partial class DeveloperForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxInProgress = new System.Windows.Forms.CheckBox();
            this.checkBoxUnsolved = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chkboxSolved = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTxtSyntax = new System.Windows.Forms.RichTextBox();
            this.richTxtBugDesc = new System.Windows.Forms.RichTextBox();
            this.txtBugName = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtBugId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridAssignedTask = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.assignedBugstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssignedTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedBugstblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task assigned to you:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxInProgress);
            this.panel1.Controls.Add(this.checkBoxUnsolved);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.chkboxSolved);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.richTxtSyntax);
            this.panel1.Controls.Add(this.richTxtBugDesc);
            this.panel1.Controls.Add(this.txtBugName);
            this.panel1.Controls.Add(this.txtProdName);
            this.panel1.Controls.Add(this.txtBugId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1818, 1022);
            this.panel1.TabIndex = 1;
            // 
            // checkBoxInProgress
            // 
            this.checkBoxInProgress.AutoSize = true;
            this.checkBoxInProgress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxInProgress.Location = new System.Drawing.Point(231, 944);
            this.checkBoxInProgress.Name = "checkBoxInProgress";
            this.checkBoxInProgress.Size = new System.Drawing.Size(153, 29);
            this.checkBoxInProgress.TabIndex = 14;
            this.checkBoxInProgress.Text = "In Progress";
            this.checkBoxInProgress.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnsolved
            // 
            this.checkBoxUnsolved.AutoSize = true;
            this.checkBoxUnsolved.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxUnsolved.Location = new System.Drawing.Point(1142, 944);
            this.checkBoxUnsolved.Name = "checkBoxUnsolved";
            this.checkBoxUnsolved.Size = new System.Drawing.Size(134, 29);
            this.checkBoxUnsolved.TabIndex = 13;
            this.checkBoxUnsolved.Text = "Unsolved";
            this.checkBoxUnsolved.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1460, 944);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(358, 77);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkboxSolved
            // 
            this.chkboxSolved.AutoSize = true;
            this.chkboxSolved.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkboxSolved.Location = new System.Drawing.Point(658, 944);
            this.chkboxSolved.Name = "chkboxSolved";
            this.chkboxSolved.Size = new System.Drawing.Size(110, 29);
            this.chkboxSolved.TabIndex = 11;
            this.chkboxSolved.Text = "Solved";
            this.chkboxSolved.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(36, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Syntax:";
            // 
            // richTxtSyntax
            // 
            this.richTxtSyntax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtSyntax.Location = new System.Drawing.Point(231, 440);
            this.richTxtSyntax.Name = "richTxtSyntax";
            this.richTxtSyntax.Size = new System.Drawing.Size(1587, 481);
            this.richTxtSyntax.TabIndex = 8;
            this.richTxtSyntax.Text = "";
            this.richTxtSyntax.TextChanged += new System.EventHandler(this.richTxtSyntax_TextChanged);
            // 
            // richTxtBugDesc
            // 
            this.richTxtBugDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtBugDesc.Location = new System.Drawing.Point(231, 181);
            this.richTxtBugDesc.Name = "richTxtBugDesc";
            this.richTxtBugDesc.Size = new System.Drawing.Size(1584, 233);
            this.richTxtBugDesc.TabIndex = 7;
            this.richTxtBugDesc.Text = "";
            // 
            // txtBugName
            // 
            this.txtBugName.Location = new System.Drawing.Point(231, 124);
            this.txtBugName.Name = "txtBugName";
            this.txtBugName.Size = new System.Drawing.Size(959, 31);
            this.txtBugName.TabIndex = 6;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(231, 70);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(959, 31);
            this.txtProdName.TabIndex = 5;
            // 
            // txtBugId
            // 
            this.txtBugId.Location = new System.Drawing.Point(231, 20);
            this.txtBugId.Name = "txtBugId";
            this.txtBugId.Size = new System.Drawing.Size(338, 31);
            this.txtBugId.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(36, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bug Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(36, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bug Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(36, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(36, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bug ID:";
            // 
            // dataGridAssignedTask
            // 
            this.dataGridAssignedTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAssignedTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAssignedTask.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAssignedTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAssignedTask.Location = new System.Drawing.Point(12, 58);
            this.dataGridAssignedTask.Name = "dataGridAssignedTask";
            this.dataGridAssignedTask.RowTemplate.Height = 33;
            this.dataGridAssignedTask.Size = new System.Drawing.Size(1818, 228);
            this.dataGridAssignedTask.TabIndex = 4;
            this.dataGridAssignedTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAssignedTask_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(48, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1358, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "The above listed bugs are assigned to you. Please solve the bug and submit it by " +
    "ticking \"Solved Radio Button\" and then click Submit Button.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.YellowGreen;
            this.label8.Location = new System.Drawing.Point(277, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(514, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "(Select the row to display data below for debugging.)";
            // 
            // assignedBugstblBindingSource
            // 
            this.assignedBugstblBindingSource.DataSource = typeof(ase77146774_2.AssignedBugs_tbl);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // DeveloperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1844, 1371);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridAssignedTask);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeveloperForm";
            this.Text = "Developer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeveloperForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssignedTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedBugstblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridAssignedTask;
        private System.Windows.Forms.BindingSource assignedBugstblBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn bugidDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn syntaxDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn bugdescDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn bugnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBugName;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtBugId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTxtSyntax;
        private System.Windows.Forms.RichTextBox richTxtBugDesc;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chkboxSolved;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxUnsolved;
        private System.Windows.Forms.CheckBox checkBoxInProgress;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}