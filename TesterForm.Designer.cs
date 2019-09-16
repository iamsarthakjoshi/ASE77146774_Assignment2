namespace ase77146774_2
{
    partial class TesterForm
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
            this.btnSubmitBug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.bugstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBugName = new System.Windows.Forms.TextBox();
            this.richTxtBugDesc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTxtSyntax = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bugstblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmitBug
            // 
            this.btnSubmitBug.Location = new System.Drawing.Point(996, 749);
            this.btnSubmitBug.Name = "btnSubmitBug";
            this.btnSubmitBug.Size = new System.Drawing.Size(159, 45);
            this.btnSubmitBug.TabIndex = 6;
            this.btnSubmitBug.Text = "Submit";
            this.btnSubmitBug.UseVisualStyleBackColor = true;
            this.btnSubmitBug.Click += new System.EventHandler(this.btnSubmitBug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bug Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bug name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bug description:";
            // 
            // txtProdName
            // 
            this.txtProdName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bugstblBindingSource, "prod_name", true));
            this.txtProdName.Location = new System.Drawing.Point(231, 125);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(517, 31);
            this.txtProdName.TabIndex = 1;
            // 
            // bugstblBindingSource
            // 
            this.bugstblBindingSource.DataSource = typeof(ase77146774_2.Bugs_tbl);
            // 
            // txtBugName
            // 
            this.txtBugName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bugstblBindingSource, "bug_name", true));
            this.txtBugName.Location = new System.Drawing.Point(231, 177);
            this.txtBugName.Name = "txtBugName";
            this.txtBugName.Size = new System.Drawing.Size(517, 31);
            this.txtBugName.TabIndex = 2;
            // 
            // richTxtBugDesc
            // 
            this.richTxtBugDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bugstblBindingSource, "bug_desc", true));
            this.richTxtBugDesc.Location = new System.Drawing.Point(231, 233);
            this.richTxtBugDesc.Name = "richTxtBugDesc";
            this.richTxtBugDesc.Size = new System.Drawing.Size(924, 237);
            this.richTxtBugDesc.TabIndex = 5;
            this.richTxtBugDesc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Syntax:";
            // 
            // richTxtSyntax
            // 
            this.richTxtSyntax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bugstblBindingSource, "syntax", true));
            this.richTxtSyntax.Location = new System.Drawing.Point(231, 495);
            this.richTxtSyntax.Name = "richTxtSyntax";
            this.richTxtSyntax.Size = new System.Drawing.Size(924, 238);
            this.richTxtSyntax.TabIndex = 10;
            this.richTxtSyntax.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bugstblBindingSource, "date", true));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bugstblBindingSource, "date", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(231, 754);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(517, 31);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 760);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date/Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Auto Assign";
            // 
            // TesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1212, 817);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.richTxtSyntax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTxtBugDesc);
            this.Controls.Add(this.txtBugName);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmitBug);
            this.Name = "TesterForm";
            this.Text = "Tester Form";
            this.Load += new System.EventHandler(this.Tester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugstblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitBug;
        private System.Windows.Forms.BindingSource bugstblBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtBugName;
        private System.Windows.Forms.RichTextBox richTxtBugDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTxtSyntax;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}