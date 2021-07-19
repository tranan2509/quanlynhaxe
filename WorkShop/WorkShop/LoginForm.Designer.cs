namespace WorkShop
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linklbcontact = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdManager = new System.Windows.Forms.RadioButton();
            this.rdStaff = new System.Windows.Forms.RadioButton();
            this.picHidePassWord = new System.Windows.Forms.PictureBox();
            this.picPassWord = new System.Windows.Forms.PictureBox();
            this.picUserName = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.toolTipLogin = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linklbcontact);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picHidePassWord);
            this.panel1.Controls.Add(this.picPassWord);
            this.panel1.Controls.Add(this.picUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPassWord);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 296);
            this.panel1.TabIndex = 0;
            // 
            // linklbcontact
            // 
            this.linklbcontact.AutoSize = true;
            this.linklbcontact.Location = new System.Drawing.Point(199, 265);
            this.linklbcontact.Name = "linklbcontact";
            this.linklbcontact.Size = new System.Drawing.Size(130, 19);
            this.linklbcontact.TabIndex = 12;
            this.linklbcontact.TabStop = true;
            this.linklbcontact.Text = "Contact Information";
            this.toolTipLogin.SetToolTip(this.linklbcontact, "0392889894");
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 41);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(147, 188);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 41);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdManager);
            this.panel2.Controls.Add(this.rdStaff);
            this.panel2.Location = new System.Drawing.Point(91, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 34);
            this.panel2.TabIndex = 9;
            // 
            // rdManager
            // 
            this.rdManager.AutoSize = true;
            this.rdManager.Location = new System.Drawing.Point(140, 6);
            this.rdManager.Name = "rdManager";
            this.rdManager.Size = new System.Drawing.Size(81, 23);
            this.rdManager.TabIndex = 9;
            this.rdManager.Text = "Manager";
            this.rdManager.UseVisualStyleBackColor = true;
            // 
            // rdStaff
            // 
            this.rdStaff.AutoSize = true;
            this.rdStaff.Checked = true;
            this.rdStaff.Location = new System.Drawing.Point(27, 6);
            this.rdStaff.Name = "rdStaff";
            this.rdStaff.Size = new System.Drawing.Size(55, 23);
            this.rdStaff.TabIndex = 8;
            this.rdStaff.TabStop = true;
            this.rdStaff.Text = "Staff";
            this.rdStaff.UseVisualStyleBackColor = true;
            // 
            // picHidePassWord
            // 
            this.picHidePassWord.Image = global::WorkShop.Properties.Resources.hidePassword;
            this.picHidePassWord.Location = new System.Drawing.Point(330, 117);
            this.picHidePassWord.Name = "picHidePassWord";
            this.picHidePassWord.Size = new System.Drawing.Size(25, 25);
            this.picHidePassWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHidePassWord.TabIndex = 7;
            this.picHidePassWord.TabStop = false;
            this.picHidePassWord.Click += new System.EventHandler(this.picHidePassWord_Click);
            // 
            // picPassWord
            // 
            this.picPassWord.Image = global::WorkShop.Properties.Resources.password;
            this.picPassWord.Location = new System.Drawing.Point(91, 116);
            this.picPassWord.Name = "picPassWord";
            this.picPassWord.Size = new System.Drawing.Size(25, 25);
            this.picPassWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassWord.TabIndex = 6;
            this.picPassWord.TabStop = false;
            this.toolTipLogin.SetToolTip(this.picPassWord, "Your password");
            // 
            // picUserName
            // 
            this.picUserName.Image = global::WorkShop.Properties.Resources.Gender_Neutral_User_icon_icons1;
            this.picUserName.Location = new System.Drawing.Point(91, 75);
            this.picUserName.Name = "picUserName";
            this.picUserName.Size = new System.Drawing.Size(25, 25);
            this.picUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserName.TabIndex = 5;
            this.picUserName.TabStop = false;
            this.toolTipLogin.SetToolTip(this.picUserName, "Your Staff ID");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(118, 116);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(211, 26);
            this.txtPassWord.TabIndex = 3;
            this.txtPassWord.Text = "1";
            this.txtPassWord.UseSystemPasswordChar = true;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(112, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(118, 75);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(211, 26);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "1";
            this.toolTipLogin.SetToolTip(this.txtUserName, "Your Staff ID");
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkShop.Properties.Resources.WORK_SHOP_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(373, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 316);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ToolTip toolTipLogin;
        private System.Windows.Forms.PictureBox picPassWord;
        private System.Windows.Forms.PictureBox picHidePassWord;
        private System.Windows.Forms.LinkLabel linklbcontact;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdManager;
        private System.Windows.Forms.RadioButton rdStaff;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}