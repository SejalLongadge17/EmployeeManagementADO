namespace LoginFormado
{
    partial class Employeedetails
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
            lblempd = new Label();
            lblempid = new Label();
            lblempname = new Label();
            lblgen = new Label();
            lbldob = new Label();
            lbladd = new Label();
            lbldepart = new Label();
            lbldesign = new Label();
            txtempid = new TextBox();
            txtempname = new TextBox();
            rtxtadd = new RichTextBox();
            dtdob = new DateTimePicker();
            cmbdepart = new ComboBox();
            cmbdesign = new ComboBox();
            lblmonsal = new Label();
            txtmonsal = new TextBox();
            btnsave = new Button();
            btncanc = new Button();
            btndelete = new Button();
            btnback = new Button();
            cmbgen = new ComboBox();
            SuspendLayout();
            // 
            // lblempd
            // 
            lblempd.AutoSize = true;
            lblempd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblempd.Location = new Point(179, 42);
            lblempd.Name = "lblempd";
            lblempd.Size = new Size(198, 31);
            lblempd.TabIndex = 0;
            lblempd.Text = "Employee Details";
            // 
            // lblempid
            // 
            lblempid.AutoSize = true;
            lblempid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblempid.Location = new Point(52, 114);
            lblempid.Name = "lblempid";
            lblempid.Size = new Size(131, 28);
            lblempid.TabIndex = 1;
            lblempid.Text = "Employee ID";
            // 
            // lblempname
            // 
            lblempname.AutoSize = true;
            lblempname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblempname.Location = new Point(52, 171);
            lblempname.Name = "lblempname";
            lblempname.Size = new Size(166, 28);
            lblempname.TabIndex = 2;
            lblempname.Text = "Employee Name";
            // 
            // lblgen
            // 
            lblgen.AutoSize = true;
            lblgen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblgen.Location = new Point(52, 235);
            lblgen.Name = "lblgen";
            lblgen.Size = new Size(80, 28);
            lblgen.TabIndex = 3;
            lblgen.Text = "Gender";
            // 
            // lbldob
            // 
            lbldob.AutoSize = true;
            lbldob.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldob.Location = new Point(52, 292);
            lbldob.Name = "lbldob";
            lbldob.Size = new Size(55, 28);
            lbldob.TabIndex = 4;
            lbldob.Text = "DOB";
            // 
            // lbladd
            // 
            lbladd.AutoSize = true;
            lbladd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbladd.Location = new Point(52, 357);
            lbladd.Name = "lbladd";
            lbladd.Size = new Size(87, 28);
            lbladd.TabIndex = 5;
            lbladd.Text = "Address";
            // 
            // lbldepart
            // 
            lbldepart.AutoSize = true;
            lbldepart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldepart.Location = new Point(52, 449);
            lbldepart.Name = "lbldepart";
            lbldepart.Size = new Size(127, 28);
            lbldepart.TabIndex = 6;
            lbldepart.Text = "Department";
            // 
            // lbldesign
            // 
            lbldesign.AutoSize = true;
            lbldesign.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldesign.Location = new Point(52, 524);
            lbldesign.Name = "lbldesign";
            lbldesign.Size = new Size(126, 28);
            lbldesign.TabIndex = 7;
            lbldesign.Text = "Designation";
            // 
            // txtempid
            // 
            txtempid.Location = new Point(281, 114);
            txtempid.Name = "txtempid";
            txtempid.Size = new Size(197, 27);
            txtempid.TabIndex = 1;
            txtempid.Tag = "int";
            txtempid.Validating += txtempid_Validating;
            txtempid.Enter += Control_Enter;
            txtempid.KeyPress += Control_KeyPress;
            txtempid.Leave += Control_Leave;
            // 
            // txtempname
            // 
            txtempname.Location = new Point(281, 175);
            txtempname.Name = "txtempname";
            txtempname.Size = new Size(197, 27);
            txtempname.TabIndex = 2;
            txtempname.Tag = "string";
            txtempname.Enter += Control_Enter;
            txtempname.KeyPress += Control_KeyPress;
            txtempname.Leave += Control_Leave;
            // 
            // rtxtadd
            // 
            rtxtadd.Location = new Point(281, 357);
            rtxtadd.Name = "rtxtadd";
            rtxtadd.Size = new Size(197, 71);
            rtxtadd.TabIndex = 5;
            rtxtadd.Tag = "string";
            rtxtadd.Enter += Control_Enter;
            rtxtadd.KeyPress += Control_KeyPress;
            rtxtadd.Leave += Control_Leave;
            // rtxtadd.Text = "";
            // 
            // dtdob
            // 
            dtdob.Location = new Point(281, 292);
            dtdob.Name = "dtdob";
            dtdob.Size = new Size(197, 27);
            dtdob.TabIndex = 4;
            dtdob.Enter += Control_Enter;
            dtdob.KeyPress += Control_KeyPress;
            dtdob.Leave += Control_Leave;
            // 
            // cmbdepart
            // 
            cmbdepart.FormattingEnabled = true;
            cmbdepart.Items.AddRange(new object[] { "Marketing", "Sales", "HR", "Finance", "Operations" });
            cmbdepart.Location = new Point(281, 456);
            cmbdepart.Name = "cmbdepart";
            cmbdepart.Size = new Size(197, 28);
            cmbdepart.TabIndex = 6;
            cmbdepart.Tag = "string";
            cmbdepart.Enter += Control_Enter;
            cmbdepart.KeyPress += Control_KeyPress;
            cmbdepart.Leave += Control_Leave;
            // 
            // cmbdesign
            // 
            cmbdesign.FormattingEnabled = true;
            cmbdesign.Items.AddRange(new object[] { "Manager", "Developer", "Team Lead", "Analyst", "Assistant" });
            cmbdesign.Location = new Point(281, 524);
            cmbdesign.Name = "cmbdesign";
            cmbdesign.Size = new Size(197, 28);
            cmbdesign.TabIndex = 7;
            cmbdesign.Tag = "string";
            cmbdesign.Enter += Control_Enter;
            cmbdesign.KeyPress += Control_KeyPress;
            cmbdesign.Leave += Control_Leave;
            // 
            // lblmonsal
            // 
            lblmonsal.AutoSize = true;
            lblmonsal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblmonsal.Location = new Point(52, 594);
            lblmonsal.Name = "lblmonsal";
            lblmonsal.Size = new Size(157, 28);
            lblmonsal.TabIndex = 18;
            lblmonsal.Text = "Monthly Salary";
            // 
            // txtmonsal
            // 
            txtmonsal.Location = new Point(281, 594);
            txtmonsal.Name = "txtmonsal";
            txtmonsal.Size = new Size(197, 27);
            txtmonsal.TabIndex = 8;
            txtmonsal.Tag = "int";
            txtmonsal.Enter += Control_Enter;
            txtmonsal.KeyPress += Control_KeyPress;
            txtmonsal.Leave += Control_Leave;
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.ActiveCaption;
            btnsave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnsave.Location = new Point(51, 695);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 46);
            btnsave.TabIndex = 9;
            btnsave.Text = "SAVE";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btncanc
            // 
            btncanc.BackColor = SystemColors.ActiveCaption;
            btncanc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btncanc.Location = new Point(177, 695);
            btncanc.Name = "btncanc";
            btncanc.Size = new Size(94, 46);
            btncanc.TabIndex = 10;
            btncanc.Text = "CANCEL";
            btncanc.UseVisualStyleBackColor = false;
            btncanc.Click += btncanc_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = SystemColors.ActiveCaption;
            btndelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.Location = new Point(303, 695);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 46);
            btndelete.TabIndex = 11;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.ActiveCaption;
            btnback.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnback.Location = new Point(429, 695);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 46);
            btnback.TabIndex = 12;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // cmbgen
            // 
            cmbgen.FormattingEnabled = true;
            cmbgen.Items.AddRange(new object[] { "Male", "Female" });
            cmbgen.Location = new Point(281, 241);
            cmbgen.Name = "cmbgen";
            cmbgen.Size = new Size(197, 28);
            cmbgen.TabIndex = 3;
            cmbgen.Enter += Control_Enter;
            cmbgen.KeyPress += Control_KeyPress;
            cmbgen.Leave += Control_Leave;
            // 
            // Employeedetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(621, 787);
            Controls.Add(cmbgen);
            Controls.Add(btnback);
            Controls.Add(btndelete);
            Controls.Add(btncanc);
            Controls.Add(btnsave);
            Controls.Add(txtmonsal);
            Controls.Add(lblmonsal);
            Controls.Add(cmbdesign);
            Controls.Add(cmbdepart);
            Controls.Add(dtdob);
            Controls.Add(rtxtadd);
            Controls.Add(txtempname);
            Controls.Add(txtempid);
            Controls.Add(lbldesign);
            Controls.Add(lbldepart);
            Controls.Add(lbladd);
            Controls.Add(lbldob);
            Controls.Add(lblgen);
            Controls.Add(lblempname);
            Controls.Add(lblempid);
            Controls.Add(lblempd);
            Name = "Employeedetails";
            Text = "Employeedetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblempd;
        private Label lblempid;
        private Label lblempname;
        private Label lblgen;
        private Label lbldob;
        private Label lbladd;
        private Label lbldepart;
        private Label lbldesign;
        private TextBox txtempid;
        private TextBox txtempname;
        private RichTextBox rtxtadd;
        private DateTimePicker dtdob;
        private ComboBox cmbdepart;
        private ComboBox cmbdesign;
        private Label lblmonsal;
        private TextBox txtmonsal;
        private Button btnsave;
        private Button btncanc;
        private Button btndelete;
        private Button btnback;
        private ComboBox cmbgen;
    }
}