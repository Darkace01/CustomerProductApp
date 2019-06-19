namespace CustomerProductApp.Forms
{
    partial class UserLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.labelAlert = new System.Windows.Forms.Label();
            this.labelValid = new System.Windows.Forms.Label();
            this.newUserBtn = new System.Windows.Forms.Button();
            this.userLoginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(336, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 39);
            this.label3.TabIndex = 25;
            this.label3.Text = "Login";
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.ForeColor = System.Drawing.Color.Red;
            this.labelAlert.Location = new System.Drawing.Point(316, 284);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(0, 13);
            this.labelAlert.TabIndex = 24;
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.ForeColor = System.Drawing.Color.Red;
            this.labelValid.Location = new System.Drawing.Point(298, 284);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(0, 13);
            this.labelValid.TabIndex = 23;
            // 
            // newUserBtn
            // 
            this.newUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.newUserBtn.Location = new System.Drawing.Point(398, 324);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(133, 39);
            this.newUserBtn.TabIndex = 22;
            this.newUserBtn.Text = "New User";
            this.newUserBtn.UseVisualStyleBackColor = true;
            this.newUserBtn.Click += new System.EventHandler(this.NewUserBtn_Click);
            // 
            // userLoginBtn
            // 
            this.userLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.userLoginBtn.Location = new System.Drawing.Point(235, 324);
            this.userLoginBtn.Name = "userLoginBtn";
            this.userLoginBtn.Size = new System.Drawing.Size(133, 39);
            this.userLoginBtn.TabIndex = 21;
            this.userLoginBtn.Text = "Login";
            this.userLoginBtn.UseVisualStyleBackColor = true;
            this.userLoginBtn.Click += new System.EventHandler(this.UserLoginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(229, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(229, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPassword.Location = new System.Drawing.Point(398, 215);
            this.txtPassword.MaxLength = 16;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(174, 30);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtUserName.Location = new System.Drawing.Point(398, 155);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(174, 30);
            this.txtUserName.TabIndex = 17;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.labelValid);
            this.Controls.Add(this.newUserBtn);
            this.Controls.Add(this.userLoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAlert;
        private System.Windows.Forms.Label labelValid;
        private System.Windows.Forms.Button newUserBtn;
        private System.Windows.Forms.Button userLoginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
    }
}