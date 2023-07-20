
namespace BMI
{
    partial class Dashboard
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
            this.contact = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.service = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(449, 209);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(130, 41);
            this.contact.TabIndex = 25;
            this.contact.Text = "Contact";
            this.contact.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.about.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(231, 115);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(130, 41);
            this.about.TabIndex = 24;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // service
            // 
            this.service.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service.Location = new System.Drawing.Point(341, 162);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(130, 41);
            this.service.TabIndex = 23;
            this.service.Text = "Services";
            this.service.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(119, 68);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(130, 41);
            this.home.TabIndex = 22;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.button8_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 335);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.about);
            this.Controls.Add(this.service);
            this.Controls.Add(this.home);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button contact;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button service;
        private System.Windows.Forms.Button home;
    }
}