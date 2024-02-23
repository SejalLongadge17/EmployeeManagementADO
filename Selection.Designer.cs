namespace LoginFormado
{
    partial class Selection
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
            btnempdetails = new Button();
            btnemppayroll = new Button();
            btnbackk = new Button();
            SuspendLayout();
            // 
            // btnempdetails
            // 
            btnempdetails.BackColor = SystemColors.ActiveCaption;
            btnempdetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnempdetails.Location = new Point(68, 70);
            btnempdetails.Name = "btnempdetails";
            btnempdetails.Size = new Size(253, 62);
            btnempdetails.TabIndex = 0;
            btnempdetails.Text = "Employee Details";
            btnempdetails.UseVisualStyleBackColor = false;
            btnempdetails.Click += btnempdetails_Click;
            // 
            // btnemppayroll
            // 
            btnemppayroll.BackColor = SystemColors.ActiveCaption;
            btnemppayroll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnemppayroll.Location = new Point(68, 190);
            btnemppayroll.Name = "btnemppayroll";
            btnemppayroll.Size = new Size(253, 62);
            btnemppayroll.TabIndex = 2;
            btnemppayroll.Text = "Employee Payroll";
            btnemppayroll.UseVisualStyleBackColor = false;
            btnemppayroll.Click += btnemppayroll_Click;
            // 
            // btnbackk
            // 
            btnbackk.BackColor = SystemColors.ActiveCaption;
            btnbackk.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnbackk.ForeColor = SystemColors.ActiveCaptionText;
            btnbackk.Location = new Point(136, 333);
            btnbackk.Name = "btnbackk";
            btnbackk.Size = new Size(94, 46);
            btnbackk.TabIndex = 3;
            btnbackk.Text = "Back";
            btnbackk.UseVisualStyleBackColor = false;
            btnbackk.Click += btnbackk_Click;
            // 
            // Selection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(391, 450);
            Controls.Add(btnbackk);
            Controls.Add(btnemppayroll);
            Controls.Add(btnempdetails);
            Name = "Selection";
            Text = "Selection";
            ResumeLayout(false);
        }

        #endregion

        private Button btnempdetails;
        private Button btnemppayroll;
        private Button btnbackk;
    }
}