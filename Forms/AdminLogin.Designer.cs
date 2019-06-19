namespace CustomerProductApp.Forms
{
    partial class AdminLogin
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
            this.AdminBackBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newUserAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.txtAdminUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AdminBackBtn
            // 
            this.AdminBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AdminBackBtn.Location = new System.Drawing.Point(158, 289);
            this.AdminBackBtn.Name = "AdminBackBtn";
            this.AdminBackBtn.Size = new System.Drawing.Size(205, 61);
            this.AdminBackBtn.TabIndex = 25;
            this.AdminBackBtn.Text = "Back";
            this.AdminBackBtn.UseVisualStyleBackColor = true;
            this.AdminBackBtn.Click += new System.EventHandler(this.AdminBackBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(279, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Admin Login";
            // 
            // newUserAdd
            // 
            this.newUserAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.newUserAdd.Location = new System.Drawing.Point(445, 289);
            this.newUserAdd.Name = "newUserAdd";
            this.newUserAdd.Size = new System.Drawing.Size(205, 61);
            this.newUserAdd.TabIndex = 23;
            this.newUserAdd.Text = "Login";
            this.newUserAdd.UseVisualStyleBackColor = true;
            this.newUserAdd.Click += new System.EventHandler(this.NewUserAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(174, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Admin Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(174, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Admin Username";
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtAdminPass.Location = new System.Drawing.Point(393, 205);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.Size = new System.Drawing.Size(235, 27);
            this.txtAdminPass.TabIndex = 20;
            this.txtAdminPass.UseSystemPasswordChar = true;
            // 
            // txtAdminUser
            // 
            this.txtAdminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtAdminUser.Location = new System.Drawing.Point(393, 145);
            this.txtAdminUser.Name = "txtAdminUser";
            this.txtAdminUser.Size = new System.Drawing.Size(235, 27);
            this.txtAdminUser.TabIndex = 19;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminBackBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newUserAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdminPass);
            this.Controls.Add(this.txtAdminUser);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminBackBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newUserAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdminPass;
        private System.Windows.Forms.TextBox txtAdminUser;
    }
}