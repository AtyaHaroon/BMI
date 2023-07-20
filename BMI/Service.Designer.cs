
namespace BMI
{
    partial class Service
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
            this.dash = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Services";
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(432, 231);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(130, 41);
            this.contact.TabIndex = 13;
            this.contact.Text = "Contact";
            this.contact.UseVisualStyleBackColor = true;
            this.contact.Click += new System.EventHandler(this.contact_Click);
            // 
            // dash
            // 
            this.dash.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash.Location = new System.Drawing.Point(336, 184);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(130, 41);
            this.dash.TabIndex = 12;
            this.dash.Text = "Dashboard";
            this.dash.UseVisualStyleBackColor = true;
            this.dash.Click += new System.EventHandler(this.dash_Click);
            // 
            // about
            // 
            this.about.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(238, 137);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(130, 41);
            this.about.TabIndex = 11;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(124, 90);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(130, 41);
            this.home.TabIndex = 10;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.dash);
            this.Controls.Add(this.about);
            this.Controls.Add(this.home);
            this.Controls.Add(this.label1);
            this.Name = "Service";
            this.Text = "Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button contact;
        private System.Windows.Forms.Button dash;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button home;
    }
}