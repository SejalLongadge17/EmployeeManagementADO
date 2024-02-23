namespace LoginFormado
{
    partial class Payroll
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
            label1 = new Label();
            lblempid = new Label();
            lblempname = new Label();
            lbldepart = new Label();
            lbldesgin = new Label();
            lblmonsal = new Label();
            lblmon = new Label();
            lbltwd = new Label();
            lblpaidholi = new Label();
            lblunpaid = new Label();
            lbltotalattend = new Label();
            lblcurmon = new Label();
            txtempid = new TextBox();
            txtempname = new TextBox();
            txtdepart = new TextBox();
            txtdesign = new TextBox();
            txtmonsal = new TextBox();
            cmbmonth = new ComboBox();
            txttwd = new TextBox();
            txtpaidholi = new TextBox();
            txtunpaidholi = new TextBox();
            txttotalattend = new TextBox();
            txtcurrsal = new TextBox();
            btnsave = new Button();
            btncancel = new Button();
            btnback = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(171, 42);
            label1.Name = "label1";
            label1.Size = new Size(198, 31);
            label1.TabIndex = 0;
            label1.Text = "Employee Payroll";
            // 
            // lblempid
            // 
            lblempid.AutoSize = true;
            lblempid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblempid.Location = new Point(79, 113);
            lblempid.Name = "lblempid";
            lblempid.Size = new Size(131, 28);
            lblempid.TabIndex = 1;
            lblempid.Text = "Employee ID";
            // 
            // lblempname
            // 
            lblempname.AutoSize = true;
            lblempname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblempname.Location = new Point(79, 166);
            lblempname.Name = "lblempname";
            lblempname.Size = new Size(166, 28);
            lblempname.TabIndex = 2;
            lblempname.Text = "Employee Name";
            // 
            // lbldepart
            // 
            lbldepart.AutoSize = true;
            lbldepart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldepart.Location = new Point(79, 213);
            lbldepart.Name = "lbldepart";
            lbldepart.Size = new Size(127, 28);
            lbldepart.TabIndex = 3;
            lbldepart.Text = "Department";
            // 
            // lbldesgin
            // 
            lbldesgin.AutoSize = true;
            lbldesgin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldesgin.Location = new Point(79, 263);
            lbldesgin.Name = "lbldesgin";
            lbldesgin.Size = new Size(126, 28);
            lbldesgin.TabIndex = 4;
            lbldesgin.Text = "Designation";
            // 
            // lblmonsal
            // 
            lblmonsal.AutoSize = true;
            lblmonsal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblmonsal.Location = new Point(79, 319);
            lblmonsal.Name = "lblmonsal";
            lblmonsal.Size = new Size(157, 28);
            lblmonsal.TabIndex = 5;
            lblmonsal.Text = "Monthly Salary";
            // 
            // lblmon
            // 
            lblmon.AutoSize = true;
            lblmon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblmon.Location = new Point(79, 372);
            lblmon.Name = "lblmon";
            lblmon.Size = new Size(75, 28);
            lblmon.TabIndex = 6;
            lblmon.Text = "Month";
            // 
            // lbltwd
            // 
            lbltwd.AutoSize = true;
            lbltwd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltwd.Location = new Point(79, 421);
            lbltwd.Name = "lbltwd";
            lbltwd.Size = new Size(197, 28);
            lbltwd.TabIndex = 7;
            lbltwd.Text = "Total Working Days";
            // 
            // lblpaidholi
            // 
            lblpaidholi.AutoSize = true;
            lblpaidholi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblpaidholi.Location = new Point(79, 471);
            lblpaidholi.Name = "lblpaidholi";
            lblpaidholi.Size = new Size(141, 28);
            lblpaidholi.TabIndex = 8;
            lblpaidholi.Text = "Paid Holidays";
            // 
            // lblunpaid
            // 
            lblunpaid.AutoSize = true;
            lblunpaid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblunpaid.Location = new Point(79, 526);
            lblunpaid.Name = "lblunpaid";
            lblunpaid.Size = new Size(167, 28);
            lblunpaid.TabIndex = 9;
            lblunpaid.Text = "Unpaid Holidays";
            // 
            // lbltotalattend
            // 
            lbltotalattend.AutoSize = true;
            lbltotalattend.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotalattend.Location = new Point(79, 579);
            lbltotalattend.Name = "lbltotalattend";
            lbltotalattend.Size = new Size(174, 28);
            lbltotalattend.TabIndex = 10;
            lbltotalattend.Text = "Total Attendance";
            // 
            // lblcurmon
            // 
            lblcurmon.AutoSize = true;
            lblcurmon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblcurmon.Location = new Point(79, 631);
            lblcurmon.Name = "lblcurmon";
            lblcurmon.Size = new Size(234, 28);
            lblcurmon.TabIndex = 11;
            lblcurmon.Text = "Current Monthly Salary";
            // 
            // txtempid
            // 
            txtempid.Location = new Point(336, 113);
            txtempid.Name = "txtempid";
            txtempid.Size = new Size(180, 27);
            txtempid.TabIndex = 1;
            txtempid.Tag = "int";
            txtempid.Validating += txtempid_Validating;
            txtempid.Enter += Control_Enter;
            txtempid.Leave += Control_Leave;
            // 
            // txtempname
            // 
            txtempname.Location = new Point(336, 166);
            txtempname.Name = "txtempname";
            txtempname.ReadOnly = true;
            txtempname.Size = new Size(180, 27);
            txtempname.TabIndex = 2;
            txtempname.Tag = "string";
            txtempname.Enter += Control_Enter;
            txtempname.Leave += Control_Leave;
            // 
            // txtdepart
            // 
            txtdepart.Location = new Point(336, 213);
            txtdepart.Name = "txtdepart";
            txtdepart.ReadOnly = true;
            txtdepart.Size = new Size(180, 27);
            txtdepart.TabIndex = 3;
            txtdepart.Tag = "string";
            txtdepart.Enter += Control_Enter;
            txtdepart.Leave += Control_Leave;
            // 
            // txtdesign
            // 
            txtdesign.Location = new Point(336, 263);
            txtdesign.Name = "txtdesign";
            txtdesign.ReadOnly = true;
            txtdesign.Size = new Size(180, 27);
            txtdesign.TabIndex = 4;
            txtdesign.Tag = "string";
            txtdesign.Enter += Control_Enter;
            txtdesign.Leave += Control_Leave;
            // 
            // txtmonsal
            // 
            txtmonsal.Location = new Point(336, 319);
            txtmonsal.Name = "txtmonsal";
            txtmonsal.ReadOnly = true;
            txtmonsal.Size = new Size(180, 27);
            txtmonsal.TabIndex = 5;
            txtmonsal.Tag = "int";
            txtmonsal.Enter += Control_Enter;
            txtmonsal.Leave += Control_Leave;
            // 
            // cmbmonth
            // 
            cmbmonth.FormattingEnabled = true;
            cmbmonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cmbmonth.Location = new Point(336, 372);
            cmbmonth.Name = "cmbmonth";
            cmbmonth.Size = new Size(180, 28);
            cmbmonth.TabIndex = 6;
            cmbmonth.Enter += Control_Enter;
            cmbmonth.KeyPress += Control_KeyPress;
            cmbmonth.Leave += Control_Leave;
            // 
            // txttwd
            // 
            txttwd.Location = new Point(336, 421);
            txttwd.Name = "txttwd";
            txttwd.Size = new Size(180, 27);
            txttwd.TabIndex = 7;
            txttwd.Tag = "int";
            txttwd.Enter += Control_Enter;
            txttwd.KeyPress += Control_KeyPress;
            txttwd.Leave += Control_Leave;
            // 
            // txtpaidholi
            // 
            txtpaidholi.Location = new Point(336, 471);
            txtpaidholi.Name = "txtpaidholi";
            txtpaidholi.Size = new Size(180, 27);
            txtpaidholi.TabIndex = 8;
            txtpaidholi.Tag = "int";
            txtpaidholi.KeyPress += Control_KeyPress;
            txtpaidholi.Enter += Control_Enter;
            txtpaidholi.Leave += Control_Leave;
            // 
            // txtunpaidholi
            // 
            txtunpaidholi.Location = new Point(336, 526);
            txtunpaidholi.Name = "txtunpaidholi";
            txtunpaidholi.Size = new Size(180, 27);
            txtunpaidholi.TabIndex = 9;
            txtunpaidholi.Tag = "int";
            txtunpaidholi.Validating += txtunpaidholi_Validating;
            txtunpaidholi.Enter += Control_Enter;
            txtunpaidholi.KeyPress += Control_KeyPress;
            txtunpaidholi.Leave += Control_Leave;
            // 
            // txttotalattend
            // 
            txttotalattend.Location = new Point(336, 579);
            txttotalattend.Name = "txttotalattend";
            txttotalattend.ReadOnly = true;
            txttotalattend.Size = new Size(180, 27);
            txttotalattend.TabIndex = 10;
            txttotalattend.Tag = "int";
            txttotalattend.Validating += txttotalattend_Validating;
            // 
            // txtcurrsal
            // 
            txtcurrsal.Location = new Point(336, 631);
            txtcurrsal.Name = "txtcurrsal";
            txtcurrsal.ReadOnly = true;
            txtcurrsal.Size = new Size(180, 27);
            txtcurrsal.TabIndex = 11;
            txtcurrsal.Tag = "int";
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.ActiveCaption;
            btnsave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnsave.Location = new Point(121, 711);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(84, 48);
            btnsave.TabIndex = 12;
            btnsave.Text = "SAVE";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btncancel
            // 
            btncancel.BackColor = SystemColors.ActiveCaption;
            btncancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btncancel.Location = new Point(255, 711);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(90, 48);
            btncancel.TabIndex = 13;
            btncancel.Text = "CANCEL";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.ActiveCaption;
            btnback.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnback.Location = new Point(401, 711);
            btnback.Name = "btnback";
            btnback.Size = new Size(84, 48);
            btnback.TabIndex = 14;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // Payroll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(601, 793);
            Controls.Add(btnback);
            Controls.Add(btncancel);
            Controls.Add(btnsave);
            Controls.Add(txtcurrsal);
            Controls.Add(txttotalattend);
            Controls.Add(txtunpaidholi);
            Controls.Add(txtpaidholi);
            Controls.Add(txttwd);
            Controls.Add(cmbmonth);
            Controls.Add(txtmonsal);
            Controls.Add(txtdesign);
            Controls.Add(txtdepart);
            Controls.Add(txtempname);
            Controls.Add(txtempid);
            Controls.Add(lblcurmon);
            Controls.Add(lbltotalattend);
            Controls.Add(lblunpaid);
            Controls.Add(lblpaidholi);
            Controls.Add(lbltwd);
            Controls.Add(lblmon);
            Controls.Add(lblmonsal);
            Controls.Add(lbldesgin);
            Controls.Add(lbldepart);
            Controls.Add(lblempname);
            Controls.Add(lblempid);
            Controls.Add(label1);
            Name = "Payroll";
            Text = "Payroll";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblempid;
        private Label lblempname;
        private Label lbldepart;
        private Label lbldesgin;
        private Label lblmonsal;
        private Label lblmon;
        private Label lbltwd;
        private Label lblpaidholi;
        private Label lblunpaid;
        private Label lbltotalattend;
        private Label lblcurmon;
        private TextBox txtempid;
        private TextBox txtempname;
        private TextBox txtdepart;
        private TextBox txtdesign;
        private TextBox txtmonsal;
        private ComboBox cmbmonth;
        private TextBox txttwd;
        private TextBox txtpaidholi;
        private TextBox txtunpaidholi;
        private TextBox txttotalattend;
        private TextBox txtcurrsal;
        private Button btnsave;
        private Button btncancel;
        private Button btnback;
    }
}