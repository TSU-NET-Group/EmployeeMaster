
using System.Drawing;

namespace GroupProject_v001
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnForeigner = new System.Windows.Forms.RadioButton();
            this.radioBtnGeorgian = new System.Windows.Forms.RadioButton();
            this.label_errorMessage = new System.Windows.Forms.Label();
            this.label_forgotPassWord = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.languageSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_message = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logIn
            // 
            this.btn_logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_logIn.Location = new System.Drawing.Point(216, 263);
            this.btn_logIn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(127, 46);
            this.btn_logIn.TabIndex = 0;
            this.btn_logIn.Text = "შესვლა";
            this.btn_logIn.UseVisualStyleBackColor = true;
            this.btn_logIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.event_logInOnClick);
            // 
            // input_ID
            // 
            this.input_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input_ID.Location = new System.Drawing.Point(216, 129);
            this.input_ID.Margin = new System.Windows.Forms.Padding(4);
            this.input_ID.Name = "input_ID";
            this.input_ID.Size = new System.Drawing.Size(348, 30);
            this.input_ID.TabIndex = 2;
            this.input_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.event_formInputId);
            // 
            // input_password
            // 
            this.input_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input_password.Location = new System.Drawing.Point(216, 193);
            this.input_password.Margin = new System.Windows.Forms.Padding(4);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(348, 30);
            this.input_password.TabIndex = 3;
            this.input_password.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_message);
            this.groupBox1.Controls.Add(this.radioBtnForeigner);
            this.groupBox1.Controls.Add(this.radioBtnGeorgian);
            this.groupBox1.Controls.Add(this.label_errorMessage);
            this.groupBox1.Controls.Add(this.label_forgotPassWord);
            this.groupBox1.Controls.Add(this.label_ID);
            this.groupBox1.Controls.Add(this.label_password);
            this.groupBox1.Controls.Add(this.input_ID);
            this.groupBox1.Controls.Add(this.input_password);
            this.groupBox1.Controls.Add(this.btn_logIn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(719, 465);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ავტორიზაცია";
            // 
            // radioBtnForeigner
            // 
            this.radioBtnForeigner.AutoSize = true;
            this.radioBtnForeigner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnForeigner.Location = new System.Drawing.Point(384, 71);
            this.radioBtnForeigner.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnForeigner.Name = "radioBtnForeigner";
            this.radioBtnForeigner.Size = new System.Drawing.Size(203, 24);
            this.radioBtnForeigner.TabIndex = 10;
            this.radioBtnForeigner.TabStop = true;
            this.radioBtnForeigner.Text = "უცხოეთის მოქალაქე";
            this.radioBtnForeigner.UseVisualStyleBackColor = true;
            // 
            // radioBtnGeorgian
            // 
            this.radioBtnGeorgian.AutoSize = true;
            this.radioBtnGeorgian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnGeorgian.Location = new System.Drawing.Point(216, 71);
            this.radioBtnGeorgian.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnGeorgian.Name = "radioBtnGeorgian";
            this.radioBtnGeorgian.Size = new System.Drawing.Size(119, 24);
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
            this.label_errorMessage.Location = new System.Drawing.Point(213, 368);
            this.label_errorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_errorMessage.Name = "label_errorMessage";
            this.label_errorMessage.Size = new System.Drawing.Size(0, 20);
            this.label_errorMessage.TabIndex = 8;
            // 
            // label_forgotPassWord
            // 
            this.label_forgotPassWord.AutoSize = true;
            this.label_forgotPassWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_forgotPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forgotPassWord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_forgotPassWord.Location = new System.Drawing.Point(373, 277);
            this.label_forgotPassWord.Name = "label_forgotPassWord";
            this.label_forgotPassWord.Size = new System.Drawing.Size(215, 20);
            this.label_forgotPassWord.TabIndex = 6;
            this.label_forgotPassWord.Text = "დაგავიწყდა პაროლი???";
            this.label_forgotPassWord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.event_forgotOnClick);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ID.Location = new System.Drawing.Point(27, 129);
            this.label_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(37, 25);
            this.label_ID.TabIndex = 4;
            this.label_ID.Text = "ID:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_password.Location = new System.Drawing.Point(28, 194);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(99, 25);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "პაროლი:";
            // 
            // languageSelector
            // 
            this.languageSelector.FormattingEnabled = true;
            this.languageSelector.Items.AddRange(new object[] {
            "GEO",
            "ENG"});
            this.languageSelector.Location = new System.Drawing.Point(573, 27);
            this.languageSelector.Margin = new System.Windows.Forms.Padding(4);
            this.languageSelector.Name = "languageSelector";
            this.languageSelector.Size = new System.Drawing.Size(160, 24);
            this.languageSelector.TabIndex = 7;
            this.languageSelector.Text = "GEO";
            this.languageSelector.SelectedValueChanged += new System.EventHandler(this.event_langSelected);
            this.languageSelector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.languageSelector_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ენა:";
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message.ForeColor = System.Drawing.Color.OliveDrab;
            this.label_message.Location = new System.Drawing.Point(213, 336);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(0, 20);
            this.label_message.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languageSelector);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.TextBox input_ID;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_forgotPassWord;
        private System.Windows.Forms.Label label_errorMessage;
        private System.Windows.Forms.RadioButton radioBtnForeigner;
        private System.Windows.Forms.RadioButton radioBtnGeorgian;
        private System.Windows.Forms.ComboBox languageSelector;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label_message;
    }
}

