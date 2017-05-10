namespace iUniversity
{
    partial class EditUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSaveUserInfo = new System.Windows.Forms.Button();
            this.ComboBoxUserJob = new System.Windows.Forms.ComboBox();
            this.TextBoxUserPatronumyc = new System.Windows.Forms.TextBox();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelUserId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxUserSurname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextBoxUserSurname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtnSaveUserInfo);
            this.panel1.Controls.Add(this.ComboBoxUserJob);
            this.panel1.Controls.Add(this.TextBoxUserPatronumyc);
            this.panel1.Controls.Add(this.TextBoxUserName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LabelUserId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 195);
            this.panel1.TabIndex = 0;
            // 
            // BtnSaveUserInfo
            // 
            this.BtnSaveUserInfo.Location = new System.Drawing.Point(427, 152);
            this.BtnSaveUserInfo.Name = "BtnSaveUserInfo";
            this.BtnSaveUserInfo.Size = new System.Drawing.Size(114, 34);
            this.BtnSaveUserInfo.TabIndex = 8;
            this.BtnSaveUserInfo.Text = "Сохранить";
            this.BtnSaveUserInfo.UseVisualStyleBackColor = true;
            this.BtnSaveUserInfo.Click += new System.EventHandler(this.SaveUserBtn_Click);
            // 
            // ComboBoxUserJob
            // 
            this.ComboBoxUserJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxUserJob.FormattingEnabled = true;
            this.ComboBoxUserJob.Items.AddRange(new object[] {
            "Студент",
            "Преподаватель"});
            this.ComboBoxUserJob.Location = new System.Drawing.Point(129, 122);
            this.ComboBoxUserJob.Name = "ComboBoxUserJob";
            this.ComboBoxUserJob.Size = new System.Drawing.Size(412, 24);
            this.ComboBoxUserJob.TabIndex = 7;
            // 
            // TextBoxUserPatronumyc
            // 
            this.TextBoxUserPatronumyc.Location = new System.Drawing.Point(129, 63);
            this.TextBoxUserPatronumyc.Name = "TextBoxUserPatronumyc";
            this.TextBoxUserPatronumyc.Size = new System.Drawing.Size(412, 22);
            this.TextBoxUserPatronumyc.TabIndex = 6;
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(129, 35);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(412, 22);
            this.TextBoxUserName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // LabelUserId
            // 
            this.LabelUserId.AutoSize = true;
            this.LabelUserId.Location = new System.Drawing.Point(126, 4);
            this.LabelUserId.Name = "LabelUserId";
            this.LabelUserId.Size = new System.Drawing.Size(18, 17);
            this.LabelUserId.TabIndex = 1;
            this.LabelUserId.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id пользователя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Работа";
            // 
            // TextBoxUserSurname
            // 
            this.TextBoxUserSurname.Location = new System.Drawing.Point(129, 94);
            this.TextBoxUserSurname.Name = "TextBoxUserSurname";
            this.TextBoxUserSurname.Size = new System.Drawing.Size(412, 22);
            this.TextBoxUserSurname.TabIndex = 10;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 198);
            this.Controls.Add(this.panel1);
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о пользователе";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxUserJob;
        private System.Windows.Forms.TextBox TextBoxUserPatronumyc;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.Button BtnSaveUserInfo;
        private System.Windows.Forms.TextBox TextBoxUserSurname;
        private System.Windows.Forms.Label label5;
    }
}