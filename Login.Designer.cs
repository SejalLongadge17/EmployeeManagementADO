namespace LoginFormado
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnlogin = new Button();
            btncancel = new Button();
            lbluser = new Label();
            lblpass = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.ActiveCaption;
            btnlogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogin.Location = new Point(193, 239);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 46);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btncancel
            // 
            btncancel.BackColor = SystemColors.ActiveCaption;
            btncancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btncancel.Location = new Point(363, 239);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(94, 46);
            btncancel.TabIndex = 4;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbluser.Location = new Point(146, 79);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(81, 28);
            lbluser.TabIndex = 2;
            lbluser.Text = "User ID";
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblpass.Location = new Point(146, 152);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(101, 28);
            lblpass.TabIndex = 3;
            lblpass.Text = "Password";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(288, 82);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(152, 27);
            txtuser.TabIndex = 1;
           
            // 
            // txtpass
            // 
            txtpass.Location = new Point(288, 154);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(152, 27);
            txtpass.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(658, 329);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(lblpass);
            Controls.Add(lbluser);
            Controls.Add(btncancel);
            Controls.Add(btnlogin);
            Name = "Login";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private Button btncancel;
        private Label lbluser;
        private Label lblpass;
        private TextBox txtuser;
        private TextBox txtpass;
    }
}