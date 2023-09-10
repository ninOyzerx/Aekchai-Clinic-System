
namespace DesktopProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backToHome = new System.Windows.Forms.Button();
            this.LoginAccount = new System.Windows.Forms.Button();
            this.LoginEmail = new System.Windows.Forms.TextBox();
            this.empEmail = new System.Windows.Forms.Label();
            this.mainHeading = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LoginPassword
            // 
            this.LoginPassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LoginPassword.Location = new System.Drawing.Point(138, 161);
            this.LoginPassword.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.PasswordChar = '*';
            this.LoginPassword.Size = new System.Drawing.Size(234, 20);
            this.LoginPassword.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 67;
            this.label1.Text = "Password";
            // 
            // backToHome
            // 
            this.backToHome.BackColor = System.Drawing.Color.Red;
            this.backToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToHome.Font = new System.Drawing.Font("TH SarabunPSK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToHome.ForeColor = System.Drawing.SystemColors.Info;
            this.backToHome.Location = new System.Drawing.Point(11, 270);
            this.backToHome.Margin = new System.Windows.Forms.Padding(2);
            this.backToHome.Name = "backToHome";
            this.backToHome.Size = new System.Drawing.Size(86, 32);
            this.backToHome.TabIndex = 65;
            this.backToHome.Text = "< กลับ";
            this.backToHome.UseMnemonic = false;
            this.backToHome.UseVisualStyleBackColor = false;
            this.backToHome.Click += new System.EventHandler(this.backToHome_Click);
            // 
            // LoginAccount
            // 
            this.LoginAccount.BackColor = System.Drawing.Color.Green;
            this.LoginAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginAccount.Font = new System.Drawing.Font("TH SarabunPSK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAccount.ForeColor = System.Drawing.SystemColors.Window;
            this.LoginAccount.Location = new System.Drawing.Point(175, 212);
            this.LoginAccount.Margin = new System.Windows.Forms.Padding(2);
            this.LoginAccount.Name = "LoginAccount";
            this.LoginAccount.Size = new System.Drawing.Size(110, 32);
            this.LoginAccount.TabIndex = 64;
            this.LoginAccount.Text = "เข้าสู่ระบบ";
            this.LoginAccount.UseMnemonic = false;
            this.LoginAccount.UseVisualStyleBackColor = false;
            this.LoginAccount.Click += new System.EventHandler(this.LoginAccount_Click);
            // 
            // LoginEmail
            // 
            this.LoginEmail.Location = new System.Drawing.Point(138, 116);
            this.LoginEmail.Margin = new System.Windows.Forms.Padding(2);
            this.LoginEmail.Name = "LoginEmail";
            this.LoginEmail.Size = new System.Drawing.Size(234, 20);
            this.LoginEmail.TabIndex = 59;
            // 
            // empEmail
            // 
            this.empEmail.AutoSize = true;
            this.empEmail.BackColor = System.Drawing.Color.Transparent;
            this.empEmail.Font = new System.Drawing.Font("TH SarabunPSK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.empEmail.Location = new System.Drawing.Point(63, 112);
            this.empEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.empEmail.Name = "empEmail";
            this.empEmail.Size = new System.Drawing.Size(53, 28);
            this.empEmail.TabIndex = 58;
            this.empEmail.Text = "Email ";
            // 
            // mainHeading
            // 
            this.mainHeading.AutoSize = true;
            this.mainHeading.BackColor = System.Drawing.Color.Transparent;
            this.mainHeading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainHeading.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeading.Location = new System.Drawing.Point(142, 23);
            this.mainHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainHeading.Name = "mainHeading";
            this.mainHeading.Size = new System.Drawing.Size(176, 39);
            this.mainHeading.TabIndex = 55;
            this.mainHeading.Text = "เข้าสู่ระบบบัญชีผู้ใช้";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(313, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(443, 317);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToHome);
            this.Controls.Add(this.LoginAccount);
            this.Controls.Add(this.LoginEmail);
            this.Controls.Add(this.empEmail);
            this.Controls.Add(this.mainHeading);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.ShowIcon = false;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backToHome;
        private System.Windows.Forms.Button LoginAccount;
        private System.Windows.Forms.TextBox LoginEmail;
        private System.Windows.Forms.Label empEmail;
        private System.Windows.Forms.Label mainHeading;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}