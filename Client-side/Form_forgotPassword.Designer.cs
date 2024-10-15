
namespace EmployeeMaster
{
    partial class Form_forgotPassword
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
            this.input_Id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_ForgotPassword = new System.Windows.Forms.GroupBox();
            this.label_errorMessageForId = new System.Windows.Forms.Label();
            this.groupBox_ForgotPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // input_Id
            // 
            this.input_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Id.Location = new System.Drawing.Point(73, 34);
            this.input_Id.Name = "input_Id";
            this.input_Id.Size = new System.Drawing.Size(227, 26);
            this.input_Id.TabIndex = 1;
            this.input_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.event_forgotPass_IdInput);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(320, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "გაგზავნა";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.event_sendIDBtn);
            // 
            // groupBox_ForgotPassword
            // 
            this.groupBox_ForgotPassword.Controls.Add(this.label_errorMessageForId);
            this.groupBox_ForgotPassword.Controls.Add(this.input_Id);
            this.groupBox_ForgotPassword.Controls.Add(this.label1);
            this.groupBox_ForgotPassword.Controls.Add(this.button1);
            this.groupBox_ForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ForgotPassword.Location = new System.Drawing.Point(10, 32);
            this.groupBox_ForgotPassword.Name = "groupBox_ForgotPassword";
            this.groupBox_ForgotPassword.Size = new System.Drawing.Size(442, 118);
            this.groupBox_ForgotPassword.TabIndex = 3;
            this.groupBox_ForgotPassword.TabStop = false;
            this.groupBox_ForgotPassword.Text = "პაროლის აღდგენა";
            this.groupBox_ForgotPassword.Enter += new System.EventHandler(this.groupBox_ForgotPassword_Enter);
            // 
            // label_errorMessageForId
            // 
            this.label_errorMessageForId.AutoSize = true;
            this.label_errorMessageForId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_errorMessageForId.ForeColor = System.Drawing.Color.Red;
            this.label_errorMessageForId.Location = new System.Drawing.Point(70, 71);
            this.label_errorMessageForId.Name = "label_errorMessageForId";
            this.label_errorMessageForId.Size = new System.Drawing.Size(0, 13);
            this.label_errorMessageForId.TabIndex = 3;
            // 
            // Form_forgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 181);
            this.Controls.Add(this.groupBox_ForgotPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_forgotPassword";
            this.Text = "Form_forgotPassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.event_formClosingClick);
            this.groupBox_ForgotPassword.ResumeLayout(false);
            this.groupBox_ForgotPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_Id;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox_ForgotPassword;
        private System.Windows.Forms.Label label_errorMessageForId;
    }
}