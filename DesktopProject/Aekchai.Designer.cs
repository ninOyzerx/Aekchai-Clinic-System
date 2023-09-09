
namespace DesktopProject
{
    partial class Aekchai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aekchai));
            this.mainHeading = new System.Windows.Forms.Label();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.LoginIntoAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainHeading
            // 
            this.mainHeading.AutoSize = true;
            this.mainHeading.BackColor = System.Drawing.Color.Transparent;
            this.mainHeading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeading.ForeColor = System.Drawing.Color.Lime;
            this.mainHeading.Location = new System.Drawing.Point(209, 9);
            this.mainHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainHeading.Name = "mainHeading";
            this.mainHeading.Size = new System.Drawing.Size(455, 42);
            this.mainHeading.TabIndex = 0;
            this.mainHeading.Text = "ยินดีตอนรับเข้าสู่ เอกชัยคลินิก";
            this.mainHeading.Click += new System.EventHandler(this.mainHeading_Click);
            // 
            // CreateAccount
            // 
            this.CreateAccount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccount.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.CreateAccount.ForeColor = System.Drawing.SystemColors.Info;
            this.CreateAccount.Location = new System.Drawing.Point(500, 286);
            this.CreateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(164, 78);
            this.CreateAccount.TabIndex = 8;
            this.CreateAccount.Text = "สมัครสมาชิก";
            this.CreateAccount.UseVisualStyleBackColor = false;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // LoginIntoAccount
            // 
            this.LoginIntoAccount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginIntoAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginIntoAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginIntoAccount.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.LoginIntoAccount.ForeColor = System.Drawing.SystemColors.Info;
            this.LoginIntoAccount.Location = new System.Drawing.Point(500, 181);
            this.LoginIntoAccount.Margin = new System.Windows.Forms.Padding(2);
            this.LoginIntoAccount.Name = "LoginIntoAccount";
            this.LoginIntoAccount.Size = new System.Drawing.Size(164, 78);
            this.LoginIntoAccount.TabIndex = 9;
            this.LoginIntoAccount.Text = "เข้าสู่ระบบ";
            this.LoginIntoAccount.UseVisualStyleBackColor = false;
            this.LoginIntoAccount.Click += new System.EventHandler(this.LoginIntoAccount_Click);
            // 
            // Aekchai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(879, 386);
            this.Controls.Add(this.LoginIntoAccount);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.mainHeading);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Aekchai";
            this.Text = "Aekchai Clinic App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainHeading;
        private System.Windows.Forms.Button CreateAccount;
        private System.Windows.Forms.Button LoginIntoAccount;
    }
}

