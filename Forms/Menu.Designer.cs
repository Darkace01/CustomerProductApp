namespace CustomerProductApp.Forms
{
    partial class Menu
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
            this.CreateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(305, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Welcome";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CreateBtn.Location = new System.Drawing.Point(104, 315);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(207, 73);
            this.CreateBtn.TabIndex = 11;
            this.CreateBtn.Text = "Add New Product";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AddBtn.Location = new System.Drawing.Point(495, 204);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(201, 73);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add New Customer";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ViewBtn.Location = new System.Drawing.Point(104, 204);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(216, 73);
            this.ViewBtn.TabIndex = 9;
            this.ViewBtn.Text = "View All Customer";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(489, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 73);
            this.button1.TabIndex = 13;
            this.button1.Text = "View All Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.Location = new System.Drawing.Point(559, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 58);
            this.button2.TabIndex = 14;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ViewBtn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}