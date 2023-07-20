
namespace BMI
{
    partial class Contact
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
            this.service = new System.Windows.Forms.Button();
            this.dash = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // service
            // 
            this.service.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service.Location = new System.Drawing.Point(434, 239);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(130, 41);
            this.service.TabIndex = 9;
            this.service.Text = "Service";
            this.service.UseVisualStyleBackColor = true;
            this.service.Click += new System.EventHandler(this.service_Click);
            // 
            // dash
            // 
            this.dash.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash.Location = new System.Drawing.Point(338, 192);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(130, 41);
            this.dash.TabIndex = 8;
            this.dash.Text = "Dashboard";
            this.dash.UseVisualStyleBackColor = true;
            this.dash.Click += new System.EventHandler(this.dash_Click);
            // 
            // about
            // 
            this.about.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(240, 145);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(130, 41);
            this.about.TabIndex = 7;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(126, 98);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(130, 41);
            this.home.TabIndex = 6;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contact";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 364);
            this.Controls.Add(this.service);
            this.Controls.Add(this.dash);
            this.Controls.Add(this.about);
            this.Controls.Add(this.home);
            this.Controls.Add(this.label1);
            this.Name = "Contact";
            this.Text = "Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button service;
        private System.Windows.Forms.Button dash;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label label1;
    }
}