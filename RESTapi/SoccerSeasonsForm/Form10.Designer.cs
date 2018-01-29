namespace SoccerSeasonsForm
{
    partial class FormEditUserInfo
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
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.inptEditRole = new System.Windows.Forms.TextBox();
            this.inptEditPassword = new System.Windows.Forms.TextBox();
            this.inptEditUsername = new System.Windows.Forms.TextBox();
            this.lblEditPassword = new System.Windows.Forms.Label();
            this.lblEditUsername = new System.Windows.Forms.Label();
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.lblEditRole = new System.Windows.Forms.Label();
            this.textBoxEditId = new System.Windows.Forms.TextBox();
            this.lblEditId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(231, 170);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(91, 38);
            this.btnEditUser.TabIndex = 21;
            this.btnEditUser.Text = "SPREMI";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Location = new System.Drawing.Point(87, 170);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(91, 38);
            this.btnEditCancel.TabIndex = 20;
            this.btnEditCancel.Text = "ZATVORI";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // inptEditRole
            // 
            this.inptEditRole.Location = new System.Drawing.Point(88, 125);
            this.inptEditRole.Name = "inptEditRole";
            this.inptEditRole.Size = new System.Drawing.Size(234, 20);
            this.inptEditRole.TabIndex = 19;
            // 
            // inptEditPassword
            // 
            this.inptEditPassword.Location = new System.Drawing.Point(88, 95);
            this.inptEditPassword.Name = "inptEditPassword";
            this.inptEditPassword.Size = new System.Drawing.Size(234, 20);
            this.inptEditPassword.TabIndex = 18;
            // 
            // inptEditUsername
            // 
            this.inptEditUsername.Location = new System.Drawing.Point(88, 66);
            this.inptEditUsername.Name = "inptEditUsername";
            this.inptEditUsername.Size = new System.Drawing.Size(234, 20);
            this.inptEditUsername.TabIndex = 17;
            // 
            // lblEditPassword
            // 
            this.lblEditPassword.AutoSize = true;
            this.lblEditPassword.Location = new System.Drawing.Point(38, 98);
            this.lblEditPassword.Name = "lblEditPassword";
            this.lblEditPassword.Size = new System.Drawing.Size(44, 13);
            this.lblEditPassword.TabIndex = 16;
            this.lblEditPassword.Text = "Lozinka";
            // 
            // lblEditUsername
            // 
            this.lblEditUsername.AutoSize = true;
            this.lblEditUsername.Location = new System.Drawing.Point(11, 69);
            this.lblEditUsername.Name = "lblEditUsername";
            this.lblEditUsername.Size = new System.Drawing.Size(75, 13);
            this.lblEditUsername.TabIndex = 14;
            this.lblEditUsername.Text = "Korisničko ime";
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTitle.Location = new System.Drawing.Point(120, 9);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(172, 28);
            this.lblEditTitle.TabIndex = 11;
            this.lblEditTitle.Text = "Uredi korisnika";
            // 
            // lblEditRole
            // 
            this.lblEditRole.AutoSize = true;
            this.lblEditRole.Location = new System.Drawing.Point(35, 128);
            this.lblEditRole.Name = "lblEditRole";
            this.lblEditRole.Size = new System.Drawing.Size(51, 13);
            this.lblEditRole.TabIndex = 22;
            this.lblEditRole.Text = "Privilegija";
            // 
            // textBoxEditId
            // 
            this.textBoxEditId.Location = new System.Drawing.Point(87, 40);
            this.textBoxEditId.Name = "textBoxEditId";
            this.textBoxEditId.Size = new System.Drawing.Size(234, 20);
            this.textBoxEditId.TabIndex = 23;
            this.textBoxEditId.Visible = false;
            // 
            // lblEditId
            // 
            this.lblEditId.AutoSize = true;
            this.lblEditId.Location = new System.Drawing.Point(65, 43);
            this.lblEditId.Name = "lblEditId";
            this.lblEditId.Size = new System.Drawing.Size(16, 13);
            this.lblEditId.TabIndex = 24;
            this.lblEditId.Text = "Id";
            this.lblEditId.Visible = false;
            // 
            // FormEditUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 219);
            this.Controls.Add(this.lblEditId);
            this.Controls.Add(this.textBoxEditId);
            this.Controls.Add(this.lblEditRole);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.inptEditRole);
            this.Controls.Add(this.inptEditPassword);
            this.Controls.Add(this.inptEditUsername);
            this.Controls.Add(this.lblEditPassword);
            this.Controls.Add(this.lblEditUsername);
            this.Controls.Add(this.lblEditTitle);
            this.Name = "FormEditUserInfo";
            this.Text = "Uredi korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnEditCancel;
        public System.Windows.Forms.TextBox inptEditRole;
        public System.Windows.Forms.TextBox inptEditPassword;
        public System.Windows.Forms.TextBox inptEditUsername;
        private System.Windows.Forms.Label lblEditPassword;
        private System.Windows.Forms.Label lblEditUsername;
        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.Label lblEditRole;
        public System.Windows.Forms.TextBox textBoxEditId;
        public System.Windows.Forms.Label lblEditId;
    }
}