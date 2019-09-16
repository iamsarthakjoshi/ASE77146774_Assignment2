namespace ase77146774_2
{
    partial class AdminForm
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
            this.dataGridView_bug_list = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assign = new System.Windows.Forms.DataGridViewLinkColumn();
            this.bugstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelAssignBug = new System.Windows.Forms.Panel();
            this.btnSubmitChanges = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.combStoreUsername = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnEditBugInfo = new System.Windows.Forms.Button();
            this.panelEditBugInfo = new System.Windows.Forms.Panel();
            this.richTxtBugDesc = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBugName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.selectAssignTo = new System.Windows.Forms.ComboBox();
            this.userstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblBugId = new System.Windows.Forms.Label();
            this.btnAssignBug = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelUserList = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView_user_list = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syntaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedBugstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bug_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugstblBindingSource)).BeginInit();
            this.panelAssignBug.SuspendLayout();
            this.panelEditBugInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userstblBindingSource)).BeginInit();
            this.panelUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedBugstblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of added bugs:";
            // 
            // dataGridView_bug_list
            // 
            this.dataGridView_bug_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_bug_list.AutoGenerateColumns = false;
            this.dataGridView_bug_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bug_list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_bug_list.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_bug_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bug_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.statusDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.Assign});
            this.dataGridView_bug_list.DataSource = this.bugstblBindingSource;
            this.dataGridView_bug_list.Location = new System.Drawing.Point(45, 83);
            this.dataGridView_bug_list.Name = "dataGridView_bug_list";
            this.dataGridView_bug_list.RowTemplate.Height = 33;
            this.dataGridView_bug_list.Size = new System.Drawing.Size(1373, 240);
            this.dataGridView_bug_list.TabIndex = 1;
            this.dataGridView_bug_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_bug_list_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Bug ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "prod_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "bug_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Bug Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "bug_desc";
            this.dataGridViewTextBoxColumn4.HeaderText = "Bug Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "syntax";
            this.dataGridViewTextBoxColumn5.HeaderText = "Syntax";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date-Time";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // Assign
            // 
            this.Assign.HeaderText = "Assign ";
            this.Assign.Name = "Assign";
            this.Assign.Text = "Assign this bug";
            this.Assign.UseColumnTextForLinkValue = true;
            // 
            // bugstblBindingSource
            // 
            this.bugstblBindingSource.DataSource = typeof(ase77146774_2.Bugs_tbl);
            // 
            // panelAssignBug
            // 
            this.panelAssignBug.Controls.Add(this.btnSubmitChanges);
            this.panelAssignBug.Controls.Add(this.txtUsername);
            this.panelAssignBug.Controls.Add(this.combStoreUsername);
            this.panelAssignBug.Controls.Add(this.lblUsername);
            this.panelAssignBug.Controls.Add(this.btnEditBugInfo);
            this.panelAssignBug.Controls.Add(this.panelEditBugInfo);
            this.panelAssignBug.Controls.Add(this.selectAssignTo);
            this.panelAssignBug.Controls.Add(this.lblBugId);
            this.panelAssignBug.Controls.Add(this.btnAssignBug);
            this.panelAssignBug.Controls.Add(this.label6);
            this.panelAssignBug.Controls.Add(this.label4);
            this.panelAssignBug.Controls.Add(this.label2);
            this.panelAssignBug.Location = new System.Drawing.Point(45, 337);
            this.panelAssignBug.Name = "panelAssignBug";
            this.panelAssignBug.Size = new System.Drawing.Size(1373, 455);
            this.panelAssignBug.TabIndex = 2;
            // 
            // btnSubmitChanges
            // 
            this.btnSubmitChanges.Location = new System.Drawing.Point(1114, 399);
            this.btnSubmitChanges.Name = "btnSubmitChanges";
            this.btnSubmitChanges.Size = new System.Drawing.Size(236, 49);
            this.btnSubmitChanges.TabIndex = 14;
            this.btnSubmitChanges.Text = "Submit Changes";
            this.btnSubmitChanges.UseVisualStyleBackColor = true;
            this.btnSubmitChanges.Click += new System.EventHandler(this.btnSubmitChanges_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(727, 97);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(314, 31);
            this.txtUsername.TabIndex = 18;
            this.txtUsername.Text = "Username";
            // 
            // combStoreUsername
            // 
            this.combStoreUsername.FormattingEnabled = true;
            this.combStoreUsername.Location = new System.Drawing.Point(1047, 95);
            this.combStoreUsername.Name = "combStoreUsername";
            this.combStoreUsername.Size = new System.Drawing.Size(295, 33);
            this.combStoreUsername.TabIndex = 17;
            this.combStoreUsername.Text = "For storing fullname";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsername.Location = new System.Drawing.Point(605, 101);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(116, 25);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "Username:";
            // 
            // btnEditBugInfo
            // 
            this.btnEditBugInfo.Location = new System.Drawing.Point(872, 399);
            this.btnEditBugInfo.Name = "btnEditBugInfo";
            this.btnEditBugInfo.Size = new System.Drawing.Size(236, 49);
            this.btnEditBugInfo.TabIndex = 15;
            this.btnEditBugInfo.Text = "Edit Bug Info";
            this.btnEditBugInfo.UseVisualStyleBackColor = true;
            this.btnEditBugInfo.Click += new System.EventHandler(this.btnEditBugInfo_Click);
            // 
            // panelEditBugInfo
            // 
            this.panelEditBugInfo.Controls.Add(this.richTxtBugDesc);
            this.panelEditBugInfo.Controls.Add(this.label3);
            this.panelEditBugInfo.Controls.Add(this.label5);
            this.panelEditBugInfo.Controls.Add(this.txtBugName);
            this.panelEditBugInfo.Controls.Add(this.label7);
            this.panelEditBugInfo.Controls.Add(this.txtProdName);
            this.panelEditBugInfo.Location = new System.Drawing.Point(3, 136);
            this.panelEditBugInfo.Name = "panelEditBugInfo";
            this.panelEditBugInfo.Size = new System.Drawing.Size(1347, 257);
            this.panelEditBugInfo.TabIndex = 14;
            // 
            // richTxtBugDesc
            // 
            this.richTxtBugDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bugstblBindingSource, "bug_desc", true));
            this.richTxtBugDesc.Location = new System.Drawing.Point(181, 92);
            this.richTxtBugDesc.Name = "richTxtBugDesc";
            this.richTxtBugDesc.Size = new System.Drawing.Size(1166, 150);
            this.richTxtBugDesc.TabIndex = 10;
            this.richTxtBugDesc.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bug name:";
            // 
            // txtBugName
            // 
            this.txtBugName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bugstblBindingSource, "bug_name", true));
            this.txtBugName.Location = new System.Drawing.Point(181, 50);
            this.txtBugName.Name = "txtBugName";
            this.txtBugName.Size = new System.Drawing.Size(390, 31);
            this.txtBugName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(3, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bug description:";
            // 
            // txtProdName
            // 
            this.txtProdName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bugstblBindingSource, "prod_name", true));
            this.txtProdName.Location = new System.Drawing.Point(181, 7);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(390, 31);
            this.txtProdName.TabIndex = 7;
            // 
            // selectAssignTo
            // 
            this.selectAssignTo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userstblBindingSource, "username", true));
            this.selectAssignTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectAssignTo.FormattingEnabled = true;
            this.selectAssignTo.Location = new System.Drawing.Point(184, 95);
            this.selectAssignTo.Name = "selectAssignTo";
            this.selectAssignTo.Size = new System.Drawing.Size(390, 33);
            this.selectAssignTo.TabIndex = 12;
            this.selectAssignTo.SelectedIndexChanged += new System.EventHandler(this.selectAssignTo_SelectedIndexChanged);
            // 
            // userstblBindingSource
            // 
            this.userstblBindingSource.DataSource = typeof(ase77146774_2.Users_tbl);
            // 
            // lblBugId
            // 
            this.lblBugId.AutoSize = true;
            this.lblBugId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bugstblBindingSource, "id", true));
            this.lblBugId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBugId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBugId.Location = new System.Drawing.Point(181, 60);
            this.lblBugId.Name = "lblBugId";
            this.lblBugId.Size = new System.Drawing.Size(79, 25);
            this.lblBugId.TabIndex = 11;
            this.lblBugId.Text = "Bug Id";
            // 
            // btnAssignBug
            // 
            this.btnAssignBug.Location = new System.Drawing.Point(1114, 399);
            this.btnAssignBug.Name = "btnAssignBug";
            this.btnAssignBug.Size = new System.Drawing.Size(236, 49);
            this.btnAssignBug.TabIndex = 5;
            this.btnAssignBug.Text = "Assign Bug";
            this.btnAssignBug.UseVisualStyleBackColor = true;
            this.btnAssignBug.Click += new System.EventHandler(this.btnAssignBug_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(9, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Assign to:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(10, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bug Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Assign Bug";
            // 
            // panelUserList
            // 
            this.panelUserList.Controls.Add(this.label8);
            this.panelUserList.Controls.Add(this.dataGridView_user_list);
            this.panelUserList.Location = new System.Drawing.Point(45, 1189);
            this.panelUserList.Name = "panelUserList";
            this.panelUserList.Size = new System.Drawing.Size(1373, 237);
            this.panelUserList.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(3, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "User List";
            // 
            // dataGridView_user_list
            // 
            this.dataGridView_user_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_user_list.AutoGenerateColumns = false;
            this.dataGridView_user_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_user_list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_user_list.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_user_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.role,
            this.dataGridViewTextBoxColumn6,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn});
            this.dataGridView_user_list.DataSource = this.userstblBindingSource;
            this.dataGridView_user_list.Location = new System.Drawing.Point(0, 41);
            this.dataGridView_user_list.Name = "dataGridView_user_list";
            this.dataGridView_user_list.RowTemplate.Height = 33;
            this.dataGridView_user_list.Size = new System.Drawing.Size(1373, 196);
            this.dataGridView_user_list.TabIndex = 14;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            // 
            // role
            // 
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn6.HeaderText = "id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ToolTipText = "o";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(40, 805);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(292, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "List of assigned bugs history:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.bugnameDataGridViewTextBoxColumn,
            this.bugdescDataGridViewTextBoxColumn,
            this.syntaxDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn1,
            this.bugidDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn1,
            this.fullnameDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.assignedBugstblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 845);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1373, 333);
            this.dataGridView1.TabIndex = 15;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            // 
            // bugnameDataGridViewTextBoxColumn
            // 
            this.bugnameDataGridViewTextBoxColumn.DataPropertyName = "bug_name";
            this.bugnameDataGridViewTextBoxColumn.HeaderText = "Bug Name";
            this.bugnameDataGridViewTextBoxColumn.Name = "bugnameDataGridViewTextBoxColumn";
            // 
            // bugdescDataGridViewTextBoxColumn
            // 
            this.bugdescDataGridViewTextBoxColumn.DataPropertyName = "bug_desc";
            this.bugdescDataGridViewTextBoxColumn.HeaderText = "Bug Description";
            this.bugdescDataGridViewTextBoxColumn.Name = "bugdescDataGridViewTextBoxColumn";
            // 
            // syntaxDataGridViewTextBoxColumn
            // 
            this.syntaxDataGridViewTextBoxColumn.DataPropertyName = "syntax";
            this.syntaxDataGridViewTextBoxColumn.HeaderText = "Syntax";
            this.syntaxDataGridViewTextBoxColumn.Name = "syntaxDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            // 
            // bugidDataGridViewTextBoxColumn
            // 
            this.bugidDataGridViewTextBoxColumn.DataPropertyName = "bug_id";
            this.bugidDataGridViewTextBoxColumn.HeaderText = "Bug ID";
            this.bugidDataGridViewTextBoxColumn.Name = "bugidDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            // 
            // fullnameDataGridViewTextBoxColumn1
            // 
            this.fullnameDataGridViewTextBoxColumn1.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn1.HeaderText = "Full Name";
            this.fullnameDataGridViewTextBoxColumn1.Name = "fullnameDataGridViewTextBoxColumn1";
            // 
            // assignedBugstblBindingSource
            // 
            this.assignedBugstblBindingSource.DataSource = typeof(ase77146774_2.AssignedBugs_tbl);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1454, 1462);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panelUserList);
            this.Controls.Add(this.panelAssignBug);
            this.Controls.Add(this.dataGridView_bug_list);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "Admin Panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bug_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugstblBindingSource)).EndInit();
            this.panelAssignBug.ResumeLayout(false);
            this.panelAssignBug.PerformLayout();
            this.panelEditBugInfo.ResumeLayout(false);
            this.panelEditBugInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userstblBindingSource)).EndInit();
            this.panelUserList.ResumeLayout(false);
            this.panelUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedBugstblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_bug_list;
        private System.Windows.Forms.BindingSource bugstblBindingSource;
        private System.Windows.Forms.Panel panelAssignBug;
        private System.Windows.Forms.Button btnAssignBug;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectAssignTo;
        private System.Windows.Forms.Label lblBugId;
        private System.Windows.Forms.RichTextBox richTxtBugDesc;
        private System.Windows.Forms.TextBox txtBugName;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelUserList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView_user_list;
        private System.Windows.Forms.BindingSource userstblBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn syntaxDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn bugdescDataGridViewTextBoxColumn;
        ///private System.Windows.Forms.DataGridViewTextBoxColumn bugnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelEditBugInfo;
        private System.Windows.Forms.Button btnEditBugInfo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox combStoreUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSubmitChanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewLinkColumn Assign;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource assignedBugstblBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bugidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn syntaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bugdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bugnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}