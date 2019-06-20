namespace CustomerProductApp
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUserLog = new System.Windows.Forms.Button();
            this.btnCrtUser = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(103, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 7;
            // 
            // btnUserLog
            // 
            this.btnUserLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnUserLog.Location = new System.Drawing.Point(148, 29);
            this.btnUserLog.Name = "btnUserLog";
            this.btnUserLog.Size = new System.Drawing.Size(191, 78);
            this.btnUserLog.TabIndex = 6;
            this.btnUserLog.Text = "User login";
            this.btnUserLog.UseVisualStyleBackColor = true;
            this.btnUserLog.Click += new System.EventHandler(this.BtnUserLog_Click);
            // 
            // btnCrtUser
            // 
            this.btnCrtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnCrtUser.Location = new System.Drawing.Point(129, 245);
            this.btnCrtUser.Name = "btnCrtUser";
            this.btnCrtUser.Size = new System.Drawing.Size(241, 78);
            this.btnCrtUser.TabIndex = 5;
            this.btnCrtUser.Text = "Create User Account";
            this.btnCrtUser.UseVisualStyleBackColor = true;
            this.btnCrtUser.Click += new System.EventHandler(this.BtnCrtUser_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnAdminLogin.Location = new System.Drawing.Point(148, 136);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(202, 78);
            this.btnAdminLogin.TabIndex = 4;
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUserLog);
            this.groupBox1.Controls.Add(this.btnCrtUser);
            this.groupBox1.Controls.Add(this.btnAdminLogin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(151, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 345);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Home";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserLog;
        private System.Windows.Forms.Button btnCrtUser;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

