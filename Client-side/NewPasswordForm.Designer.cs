
namespace GroupProject_v001
{
    partial class NewPasswordForm
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
            this.passwordOnce = new System.Windows.Forms.TextBox();
            this.passwordTwice = new System.Windows.Forms.TextBox();
            this.newPasswordBox = new System.Windows.Forms.GroupBox();
            this.updatePassword = new System.Windows.Forms.Label();
            this.newPasswordButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.label_errorMessage = new System.Windows.Forms.Label();
            this.newPasswordBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordOnce
            // 
            this.passwordOnce.Location = new System.Drawing.Point(95, 44);
            this.passwordOnce.Name = "passwordOnce";
            this.passwordOnce.PasswordChar = '*';
            this.passwordOnce.Size = new System.Drawing.Size(146, 20);
            this.passwordOnce.TabIndex = 0;
            this.passwordOnce.UseSystemPasswordChar = true;
            // 
            // passwordTwice
            // 
            this.passwordTwice.Location = new System.Drawing.Point(95, 81);
            this.passwordTwice.Name = "passwordTwice";
            this.passwordTwice.Size = new System.Drawing.Size(146, 20);
            this.passwordTwice.TabIndex = 1;
            this.passwordTwice.UseSystemPasswordChar = true;
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.Controls.Add(this.label_errorMessage);
            this.newPasswordBox.Controls.Add(this.updatePassword);
            this.newPasswordBox.Controls.Add(this.newPasswordButton);
            this.newPasswordBox.Controls.Add(this.PasswordLabel);
            this.newPasswordBox.Controls.Add(this.passwordTwice);
            this.newPasswordBox.Controls.Add(this.passwordOnce);
            this.newPasswordBox.Location = new System.Drawing.Point(110, 34);
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.Size = new System.Drawing.Size(352, 193);
            this.newPasswordBox.TabIndex = 2;
            this.newPasswordBox.TabStop = false;
            this.newPasswordBox.Text = "Password Recovery";
            // 
            // updatePassword
            // 
            this.updatePassword.AutoSize = true;
            this.updatePassword.Location = new System.Drawing.Point(92, 67);
            this.updatePassword.Name = "updatePassword";
            this.updatePassword.Size = new System.Drawing.Size(91, 13);
            this.updatePassword.TabIndex = 4;
            this.updatePassword.Text = "Update Password";
            // 
            // newPasswordButton
            // 
            this.newPasswordButton.Location = new System.Drawing.Point(95, 116);
            this.newPasswordButton.Name = "newPasswordButton";
            this.newPasswordButton.Size = new System.Drawing.Size(146, 23);
            this.newPasswordButton.TabIndex = 3;
            this.newPasswordButton.Text = "update password";
            this.newPasswordButton.UseVisualStyleBackColor = true;
            this.newPasswordButton.Click += new System.EventHandler(this.newPasswordButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(92, 28);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "new Password";
            // 
            // label_errorMessage
            // 
            this.label_errorMessage.AutoSize = true;
            this.label_errorMessage.ForeColor = System.Drawing.Color.Red;
            this.label_errorMessage.Location = new System.Drawing.Point(115, 158);
            this.label_errorMessage.Name = "label_errorMessage";
            this.label_errorMessage.Size = new System.Drawing.Size(0, 13);
            this.label_errorMessage.TabIndex = 3;
            // 
            // NewPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 246);
            this.Controls.Add(this.newPasswordBox);
            this.Name = "NewPasswordForm";
            this.Text = "newPassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewPasswordForm_FormClosed);
            this.Load += new System.EventHandler(this.NewPasswordForm_Load);
            this.newPasswordBox.ResumeLayout(false);
            this.newPasswordBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox passwordOnce;
        private System.Windows.Forms.TextBox passwordTwice;
        private System.Windows.Forms.GroupBox newPasswordBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label updatePassword;
        private System.Windows.Forms.Button newPasswordButton;
        private System.Windows.Forms.Label label_errorMessage;
    }
}