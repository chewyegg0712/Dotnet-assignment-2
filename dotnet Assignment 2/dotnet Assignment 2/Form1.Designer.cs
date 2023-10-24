namespace dotnet_Assignment_2
{
    partial class Form1
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
            lblTitle = new Label();
            lblName = new Label();
            label1 = new Label();
            txtName = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(162, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(495, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Library Management System";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblName.Location = new Point(198, 152);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(198, 221);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 2;
            label1.Text = "Password";
            // 
            // txtName
            // 
            txtName.Location = new Point(303, 154);
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 23);
            txtName.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(303, 221);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(280, 23);
            txtPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(324, 298);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 44);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegister.Location = new Point(660, 80);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(105, 35);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label label1;
        private TextBox txtName;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnRegister;
    }
}