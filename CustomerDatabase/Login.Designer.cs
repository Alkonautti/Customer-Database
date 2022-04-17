
namespace CustomerDatabase
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
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txtbox_serveraddr = new System.Windows.Forms.TextBox();
            this.lbl_serveraddr = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.lbl_loginheader = new System.Windows.Forms.Label();
            this.lbl_logininfo = new System.Windows.Forms.Label();
            this.lbl_serverport = new System.Windows.Forms.Label();
            this.txtbox_serverport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(15, 254);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(85, 22);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(140, 254);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(85, 20);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txtbox_serveraddr
            // 
            this.txtbox_serveraddr.Location = new System.Drawing.Point(73, 101);
            this.txtbox_serveraddr.Name = "txtbox_serveraddr";
            this.txtbox_serveraddr.Size = new System.Drawing.Size(152, 20);
            this.txtbox_serveraddr.TabIndex = 2;
            this.txtbox_serveraddr.Text = "localhost";
            // 
            // lbl_serveraddr
            // 
            this.lbl_serveraddr.AutoSize = true;
            this.lbl_serveraddr.Location = new System.Drawing.Point(12, 104);
            this.lbl_serveraddr.Name = "lbl_serveraddr";
            this.lbl_serveraddr.Size = new System.Drawing.Size(38, 13);
            this.lbl_serveraddr.TabIndex = 3;
            this.lbl_serveraddr.Text = "Server";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(12, 156);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "Username";
            // 
            // txtbox_username
            // 
            this.txtbox_username.Location = new System.Drawing.Point(73, 153);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(152, 20);
            this.txtbox_username.TabIndex = 4;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(12, 182);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Password";
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(73, 179);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '*';
            this.txtbox_password.Size = new System.Drawing.Size(152, 20);
            this.txtbox_password.TabIndex = 6;
            // 
            // lbl_loginheader
            // 
            this.lbl_loginheader.AutoSize = true;
            this.lbl_loginheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginheader.Location = new System.Drawing.Point(10, 22);
            this.lbl_loginheader.Name = "lbl_loginheader";
            this.lbl_loginheader.Size = new System.Drawing.Size(225, 29);
            this.lbl_loginheader.TabIndex = 8;
            this.lbl_loginheader.Text = "Customer Database";
            // 
            // lbl_logininfo
            // 
            this.lbl_logininfo.AutoSize = true;
            this.lbl_logininfo.Location = new System.Drawing.Point(12, 209);
            this.lbl_logininfo.Name = "lbl_logininfo";
            this.lbl_logininfo.Size = new System.Drawing.Size(0, 13);
            this.lbl_logininfo.TabIndex = 9;
            // 
            // lbl_serverport
            // 
            this.lbl_serverport.AutoSize = true;
            this.lbl_serverport.Location = new System.Drawing.Point(12, 130);
            this.lbl_serverport.Name = "lbl_serverport";
            this.lbl_serverport.Size = new System.Drawing.Size(26, 13);
            this.lbl_serverport.TabIndex = 11;
            this.lbl_serverport.Text = "Port";
            // 
            // txtbox_serverport
            // 
            this.txtbox_serverport.Location = new System.Drawing.Point(73, 127);
            this.txtbox_serverport.Name = "txtbox_serverport";
            this.txtbox_serverport.Size = new System.Drawing.Size(53, 20);
            this.txtbox_serverport.TabIndex = 10;
            this.txtbox_serverport.Text = "3306";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 290);
            this.Controls.Add(this.lbl_serverport);
            this.Controls.Add(this.txtbox_serverport);
            this.Controls.Add(this.lbl_logininfo);
            this.Controls.Add(this.lbl_loginheader);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.lbl_serveraddr);
            this.Controls.Add(this.txtbox_serveraddr);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.MinimumSize = new System.Drawing.Size(260, 329);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txtbox_serveraddr;
        private System.Windows.Forms.Label lbl_serveraddr;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label lbl_loginheader;
        private System.Windows.Forms.Label lbl_logininfo;
        private System.Windows.Forms.Label lbl_serverport;
        private System.Windows.Forms.TextBox txtbox_serverport;
    }
}

