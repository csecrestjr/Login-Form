namespace Login
{
    partial class RegisterForm
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
            this.lblUsernameRegister = new System.Windows.Forms.Label();
            this.txtUsernameRegister = new System.Windows.Forms.TextBox();
            this.txtPasswordRegister = new System.Windows.Forms.TextBox();
            this.lblPasswordRegister = new System.Windows.Forms.Label();
            this.txtNameRegister = new System.Windows.Forms.TextBox();
            this.lblNameRegister = new System.Windows.Forms.Label();
            this.txtSurnameRegister = new System.Windows.Forms.TextBox();
            this.lblSurnameRegister = new System.Windows.Forms.Label();
            this.txtEmailRegister = new System.Windows.Forms.TextBox();
            this.lblEmailRegister = new System.Windows.Forms.Label();
            this.btnOkRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsernameRegister
            // 
            this.lblUsernameRegister.AutoSize = true;
            this.lblUsernameRegister.Location = new System.Drawing.Point(12, 17);
            this.lblUsernameRegister.Name = "lblUsernameRegister";
            this.lblUsernameRegister.Size = new System.Drawing.Size(55, 13);
            this.lblUsernameRegister.TabIndex = 0;
            this.lblUsernameRegister.Text = "Username";
            // 
            // txtUsernameRegister
            // 
            this.txtUsernameRegister.Location = new System.Drawing.Point(67, 10);
            this.txtUsernameRegister.Name = "txtUsernameRegister";
            this.txtUsernameRegister.Size = new System.Drawing.Size(100, 20);
            this.txtUsernameRegister.TabIndex = 1;
            // 
            // txtPasswordRegister
            // 
            this.txtPasswordRegister.Location = new System.Drawing.Point(67, 36);
            this.txtPasswordRegister.Name = "txtPasswordRegister";
            this.txtPasswordRegister.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordRegister.TabIndex = 3;
            // 
            // lblPasswordRegister
            // 
            this.lblPasswordRegister.AutoSize = true;
            this.lblPasswordRegister.Location = new System.Drawing.Point(12, 43);
            this.lblPasswordRegister.Name = "lblPasswordRegister";
            this.lblPasswordRegister.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordRegister.TabIndex = 2;
            this.lblPasswordRegister.Text = "Password";
            // 
            // txtNameRegister
            // 
            this.txtNameRegister.Location = new System.Drawing.Point(67, 62);
            this.txtNameRegister.Name = "txtNameRegister";
            this.txtNameRegister.Size = new System.Drawing.Size(100, 20);
            this.txtNameRegister.TabIndex = 5;
            // 
            // lblNameRegister
            // 
            this.lblNameRegister.AutoSize = true;
            this.lblNameRegister.Location = new System.Drawing.Point(32, 69);
            this.lblNameRegister.Name = "lblNameRegister";
            this.lblNameRegister.Size = new System.Drawing.Size(35, 13);
            this.lblNameRegister.TabIndex = 4;
            this.lblNameRegister.Text = "Name";
            // 
            // txtSurnameRegister
            // 
            this.txtSurnameRegister.Location = new System.Drawing.Point(67, 88);
            this.txtSurnameRegister.Name = "txtSurnameRegister";
            this.txtSurnameRegister.Size = new System.Drawing.Size(100, 20);
            this.txtSurnameRegister.TabIndex = 7;
            // 
            // lblSurnameRegister
            // 
            this.lblSurnameRegister.AutoSize = true;
            this.lblSurnameRegister.Location = new System.Drawing.Point(18, 95);
            this.lblSurnameRegister.Name = "lblSurnameRegister";
            this.lblSurnameRegister.Size = new System.Drawing.Size(49, 13);
            this.lblSurnameRegister.TabIndex = 6;
            this.lblSurnameRegister.Text = "Surname";
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.Location = new System.Drawing.Point(67, 114);
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.Size = new System.Drawing.Size(100, 20);
            this.txtEmailRegister.TabIndex = 9;
            // 
            // lblEmailRegister
            // 
            this.lblEmailRegister.AutoSize = true;
            this.lblEmailRegister.Location = new System.Drawing.Point(32, 121);
            this.lblEmailRegister.Name = "lblEmailRegister";
            this.lblEmailRegister.Size = new System.Drawing.Size(32, 13);
            this.lblEmailRegister.TabIndex = 8;
            this.lblEmailRegister.Text = "Email";
            // 
            // btnOkRegister
            // 
            this.btnOkRegister.Location = new System.Drawing.Point(15, 155);
            this.btnOkRegister.Name = "btnOkRegister";
            this.btnOkRegister.Size = new System.Drawing.Size(152, 22);
            this.btnOkRegister.TabIndex = 10;
            this.btnOkRegister.Text = "OK";
            this.btnOkRegister.UseVisualStyleBackColor = true;
            this.btnOkRegister.Click += new System.EventHandler(this.btnOkRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 192);
            this.Controls.Add(this.btnOkRegister);
            this.Controls.Add(this.txtEmailRegister);
            this.Controls.Add(this.lblEmailRegister);
            this.Controls.Add(this.txtSurnameRegister);
            this.Controls.Add(this.lblSurnameRegister);
            this.Controls.Add(this.txtNameRegister);
            this.Controls.Add(this.lblNameRegister);
            this.Controls.Add(this.txtPasswordRegister);
            this.Controls.Add(this.lblPasswordRegister);
            this.Controls.Add(this.txtUsernameRegister);
            this.Controls.Add(this.lblUsernameRegister);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsernameRegister;
        private System.Windows.Forms.TextBox txtUsernameRegister;
        private System.Windows.Forms.TextBox txtPasswordRegister;
        private System.Windows.Forms.Label lblPasswordRegister;
        private System.Windows.Forms.TextBox txtNameRegister;
        private System.Windows.Forms.Label lblNameRegister;
        private System.Windows.Forms.TextBox txtSurnameRegister;
        private System.Windows.Forms.Label lblSurnameRegister;
        private System.Windows.Forms.TextBox txtEmailRegister;
        private System.Windows.Forms.Label lblEmailRegister;
        private System.Windows.Forms.Button btnOkRegister;
    }
}