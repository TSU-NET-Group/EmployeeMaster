
using System.Drawing;

namespace EmployeeMaster
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
            this.btn_logIn = new System.Windows.Forms.Button();
            this.input_ID = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.btn_registration = new System.Windows.Forms.Button();
            this.label_message = new System.Windows.Forms.Label();
            this.radioBtnForeigner = new System.Windows.Forms.RadioButton();
            this.radioBtnGeorgian = new System.Windows.Forms.RadioButton();
            this.label_errorMessage = new System.Windows.Forms.Label();
            this.label_forgotPassWord = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.languageSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logIn
            // 
            this.btn_logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_logIn.Location = new System.Drawing.Point(162, 214);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(95, 37);
            this.btn_logIn.TabIndex = 0;
            this.btn_logIn.Text = "შესვლა";
            this.btn_logIn.UseVisualStyleBackColor = true;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            this.btn_logIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.event_logInOnClick);
            // 
            // input_ID
            // 
            this.input_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input_ID.Location = new System.Drawing.Point(162, 105);
            this.input_ID.Name = "input_ID";
            this.input_ID.Size = new System.Drawing.Size(262, 26);
            this.input_ID.TabIndex = 2;
            this.input_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.event_formInputId);
            // 
            // input_password
            // 
            this.input_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input_password.Location = new System.Drawing.Point(162, 157);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(262, 26);
            this.input_password.TabIndex = 3;
            this.input_password.UseSystemPasswordChar = true;
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.btn_registration);
            this.loginGroupBox.Controls.Add(this.label_message);
            this.loginGroupBox.Controls.Add(this.radioBtnForeigner);
            this.loginGroupBox.Controls.Add(this.radioBtnGeorgian);
            this.loginGroupBox.Controls.Add(this.label_errorMessage);
            this.loginGroupBox.Controls.Add(this.label_forgotPassWord);
            this.loginGroupBox.Controls.Add(this.label_ID);
            this.loginGroupBox.Controls.Add(this.label_password);
            this.loginGroupBox.Controls.Add(this.input_ID);
            this.loginGroupBox.Controls.Add(this.input_password);
            this.loginGroupBox.Controls.Add(this.btn_logIn);
            this.loginGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginGroupBox.Location = new System.Drawing.Point(12, 59);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(539, 378);
            this.loginGroupBox.TabIndex = 6;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "ავტორიზაცია";
            this.loginGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_registration
            // 
            this.btn_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_registration.Location = new System.Drawing.Point(162, 265);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(131, 33);
            this.btn_registration.TabIndex = 12;
            this.btn_registration.Text = "რეგისტრაცია";
            this.btn_registration.UseVisualStyleBackColor = true;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click);
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message.ForeColor = System.Drawing.Color.OliveDrab;
            this.label_message.Location = new System.Drawing.Point(160, 273);
            this.label_message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(0, 17);
            this.label_message.TabIndex = 11;
            // 
            // radioBtnForeigner
            // 
            this.radioBtnForeigner.AutoSize = true;
            this.radioBtnForeigner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnForeigner.Location = new System.Drawing.Point(288, 58);
            this.radioBtnForeigner.Name = "radioBtnForeigner";
            this.radioBtnForeigner.Size = new System.Drawing.Size(158, 20);
            this.radioBtnForeigner.TabIndex = 10;
            this.radioBtnForeigner.TabStop = true;
            this.radioBtnForeigner.Text = "უცხოეთის მოქალაქე";
            this.radioBtnForeigner.UseVisualStyleBackColor = true;
            // 
            // radioBtnGeorgian
            // 
            this.radioBtnGeorgian.AutoSize = true;
            this.radioBtnGeorgian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnGeorgian.Location = new System.Drawing.Point(162, 58);
            this.radioBtnGeorgian.Name = "radioBtnGeorgian";
            this.radioBtnGeorgian.Size = new System.Drawing.Size(95, 20);
            this.radioBtnGeorgian.TabIndex = 9;
            this.radioBtnGeorgian.TabStop = true;
            this.radioBtnGeorgian.Text = "ქართველი";
            this.radioBtnGeorgian.UseVisualStyleBackColor = true;
            // 
            // label_errorMessage
            // 
            this.label_errorMessage.AutoSize = true;
            this.label_errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_errorMessage.ForeColor = System.Drawing.Color.Red;
            this.label_errorMessage.Location = new System.Drawing.Point(160, 299);
            this.label_errorMessage.Name = "label_errorMessage";
            this.label_errorMessage.Size = new System.Drawing.Size(0, 17);
            this.label_errorMessage.TabIndex = 8;
            // 
            // label_forgotPassWord
            // 
            this.label_forgotPassWord.AutoSize = true;
            this.label_forgotPassWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_forgotPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forgotPassWord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_forgotPassWord.Location = new System.Drawing.Point(280, 225);
            this.label_forgotPassWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_forgotPassWord.Name = "label_forgotPassWord";
            this.label_forgotPassWord.Size = new System.Drawing.Size(166, 16);
            this.label_forgotPassWord.TabIndex = 6;
            this.label_forgotPassWord.Text = "დაგავიწყდა პაროლი???";
            this.label_forgotPassWord.Click += new System.EventHandler(this.label_forgotPassWord_Click);
            this.label_forgotPassWord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.event_forgotOnClick);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ID.Location = new System.Drawing.Point(20, 105);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(30, 20);
            this.label_ID.TabIndex = 4;
            this.label_ID.Text = "ID:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_password.Location = new System.Drawing.Point(21, 158);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(78, 20);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "პაროლი:";
            // 
            // languageSelector
            // 
            this.languageSelector.FormattingEnabled = true;
            this.languageSelector.Items.AddRange(new object[] {
            "GEO",
            "ENG"});
            this.languageSelector.Location = new System.Drawing.Point(430, 22);
            this.languageSelector.Name = "languageSelector";
            this.languageSelector.Size = new System.Drawing.Size(121, 21);
            this.languageSelector.TabIndex = 7;
            this.languageSelector.Text = "GEO";
            this.languageSelector.SelectedValueChanged += new System.EventHandler(this.event_langSelected);
            this.languageSelector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.languageSelector_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ენა:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languageSelector);
            this.Controls.Add(this.loginGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.TextBox input_ID;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_forgotPassWord;
        private System.Windows.Forms.Label label_errorMessage;
        private System.Windows.Forms.RadioButton radioBtnForeigner;
        private System.Windows.Forms.RadioButton radioBtnGeorgian;
        private System.Windows.Forms.ComboBox languageSelector;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Button btn_registration;
    }
}

