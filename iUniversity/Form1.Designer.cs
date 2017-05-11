namespace iUniversity
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnRegistrationUserInDean = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridAllUsers = new System.Windows.Forms.DataGridView();
            this.AllUId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllUSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllUUName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllUPatronumyc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllUJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridRegUsersInDean = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronumyc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCreateNewUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnRemoveStatement = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DataGridDeanStatementsList = new System.Windows.Forms.DataGridView();
            this.DgStatementUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgStatementTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgStatementSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.BtnDeletePermission = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.DgPermissionsList = new System.Windows.Forms.DataGridView();
            this.DgPermissionsListUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgPermissionsListGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeanLabelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeansList = new System.Windows.Forms.ListBox();
            this.tabDean = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StatementDeanList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSaveStatement = new System.Windows.Forms.Button();
            this.StatementSubject = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StatementTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StatementUserId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAllUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRegUsersInDean)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDeanStatementsList)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPermissionsList)).BeginInit();
            this.tabDean.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.DeansList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(777, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Деканаты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.DeanLabelName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(161, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 548);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(5, 20);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 526);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BtnRegistrationUserInDean);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.GridAllUsers);
            this.tabPage3.Controls.Add(this.GridRegUsersInDean);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.BtnCreateNewUser);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(602, 500);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Пользователи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrationUserInDean
            // 
            this.BtnRegistrationUserInDean.Location = new System.Drawing.Point(4, 463);
            this.BtnRegistrationUserInDean.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRegistrationUserInDean.Name = "BtnRegistrationUserInDean";
            this.BtnRegistrationUserInDean.Size = new System.Drawing.Size(178, 34);
            this.BtnRegistrationUserInDean.TabIndex = 8;
            this.BtnRegistrationUserInDean.Text = "Зарегистрировать в деканате";
            this.BtnRegistrationUserInDean.UseVisualStyleBackColor = true;
            this.BtnRegistrationUserInDean.Click += new System.EventHandler(this.BtnRegistrationUserInDean_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Список всех пользователей";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(4, 223);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 11);
            this.panel2.TabIndex = 6;
            // 
            // GridAllUsers
            // 
            this.GridAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAllUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AllUId,
            this.AllUSurname,
            this.AllUUName,
            this.AllUPatronumyc,
            this.AllUJob});
            this.GridAllUsers.Location = new System.Drawing.Point(4, 257);
            this.GridAllUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridAllUsers.Name = "GridAllUsers";
            this.GridAllUsers.RowTemplate.Height = 24;
            this.GridAllUsers.Size = new System.Drawing.Size(596, 202);
            this.GridAllUsers.TabIndex = 5;
            // 
            // AllUId
            // 
            this.AllUId.Frozen = true;
            this.AllUId.HeaderText = "Id";
            this.AllUId.Name = "AllUId";
            this.AllUId.ReadOnly = true;
            this.AllUId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AllUSurname
            // 
            this.AllUSurname.HeaderText = "Surname";
            this.AllUSurname.Name = "AllUSurname";
            this.AllUSurname.ReadOnly = true;
            // 
            // AllUUName
            // 
            this.AllUUName.HeaderText = "UName";
            this.AllUUName.Name = "AllUUName";
            this.AllUUName.ReadOnly = true;
            // 
            // AllUPatronumyc
            // 
            this.AllUPatronumyc.HeaderText = "Patronumyc";
            this.AllUPatronumyc.Name = "AllUPatronumyc";
            this.AllUPatronumyc.ReadOnly = true;
            // 
            // AllUJob
            // 
            this.AllUJob.HeaderText = "Job";
            this.AllUJob.Name = "AllUJob";
            this.AllUJob.ReadOnly = true;
            // 
            // GridRegUsersInDean
            // 
            this.GridRegUsersInDean.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRegUsersInDean.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Surname,
            this.UName,
            this.Patronumyc,
            this.Job});
            this.GridRegUsersInDean.Location = new System.Drawing.Point(4, 19);
            this.GridRegUsersInDean.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridRegUsersInDean.Name = "GridRegUsersInDean";
            this.GridRegUsersInDean.RowTemplate.Height = 24;
            this.GridRegUsersInDean.Size = new System.Drawing.Size(596, 161);
            this.GridRegUsersInDean.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // UName
            // 
            this.UName.HeaderText = "UName";
            this.UName.Name = "UName";
            this.UName.ReadOnly = true;
            // 
            // Patronumyc
            // 
            this.Patronumyc.HeaderText = "Patronumyc";
            this.Patronumyc.Name = "Patronumyc";
            this.Patronumyc.ReadOnly = true;
            // 
            // Job
            // 
            this.Job.HeaderText = "Job";
            this.Job.Name = "Job";
            this.Job.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 184);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnDeleteUserInDean);
            // 
            // BtnCreateNewUser
            // 
            this.BtnCreateNewUser.Location = new System.Drawing.Point(4, 184);
            this.BtnCreateNewUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCreateNewUser.Name = "BtnCreateNewUser";
            this.BtnCreateNewUser.Size = new System.Drawing.Size(95, 34);
            this.BtnCreateNewUser.TabIndex = 3;
            this.BtnCreateNewUser.Text = "Редактировать";
            this.BtnCreateNewUser.UseVisualStyleBackColor = true;
            this.BtnCreateNewUser.Click += new System.EventHandler(this.BtnCreateNewUser_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зарегистрированные";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(602, 500);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Заявления";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnRemoveStatement);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.DataGridDeanStatementsList);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 494);
            this.panel3.TabIndex = 0;
            // 
            // BtnRemoveStatement
            // 
            this.BtnRemoveStatement.Location = new System.Drawing.Point(322, 3);
            this.BtnRemoveStatement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRemoveStatement.Name = "BtnRemoveStatement";
            this.BtnRemoveStatement.Size = new System.Drawing.Size(123, 30);
            this.BtnRemoveStatement.TabIndex = 3;
            this.BtnRemoveStatement.Text = "Удалить заявление";
            this.BtnRemoveStatement.UseVisualStyleBackColor = true;
            this.BtnRemoveStatement.Click += new System.EventHandler(this.BtnRemoveStatement_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 2);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Заявления";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Рассмотреть заявление";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnViewStatement_Click);
            // 
            // DataGridDeanStatementsList
            // 
            this.DataGridDeanStatementsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDeanStatementsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgStatementUserId,
            this.DgStatementTitle,
            this.DgStatementSubject});
            this.DataGridDeanStatementsList.Location = new System.Drawing.Point(2, 38);
            this.DataGridDeanStatementsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridDeanStatementsList.Name = "DataGridDeanStatementsList";
            this.DataGridDeanStatementsList.RowTemplate.Height = 24;
            this.DataGridDeanStatementsList.Size = new System.Drawing.Size(592, 453);
            this.DataGridDeanStatementsList.TabIndex = 0;
            // 
            // DgStatementUserId
            // 
            this.DgStatementUserId.HeaderText = "User Id";
            this.DgStatementUserId.Name = "DgStatementUserId";
            this.DgStatementUserId.ReadOnly = true;
            // 
            // DgStatementTitle
            // 
            this.DgStatementTitle.HeaderText = "Title";
            this.DgStatementTitle.Name = "DgStatementTitle";
            this.DgStatementTitle.ReadOnly = true;
            // 
            // DgStatementSubject
            // 
            this.DgStatementSubject.HeaderText = "Subject";
            this.DgStatementSubject.Name = "DgStatementSubject";
            this.DgStatementSubject.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.BtnDeletePermission);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.DgPermissionsList);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Size = new System.Drawing.Size(602, 500);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Пропуска";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // BtnDeletePermission
            // 
            this.BtnDeletePermission.Location = new System.Drawing.Point(482, 6);
            this.BtnDeletePermission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDeletePermission.Name = "BtnDeletePermission";
            this.BtnDeletePermission.Size = new System.Drawing.Size(118, 24);
            this.BtnDeletePermission.TabIndex = 2;
            this.BtnDeletePermission.Text = "Удалить пропуск";
            this.BtnDeletePermission.UseVisualStyleBackColor = true;
            this.BtnDeletePermission.Click += new System.EventHandler(this.BtnDeletePermission_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Поропуска";
            // 
            // DgPermissionsList
            // 
            this.DgPermissionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPermissionsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgPermissionsListUserId,
            this.DgPermissionsListGuid});
            this.DgPermissionsList.Location = new System.Drawing.Point(4, 32);
            this.DgPermissionsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgPermissionsList.Name = "DgPermissionsList";
            this.DgPermissionsList.RowTemplate.Height = 24;
            this.DgPermissionsList.Size = new System.Drawing.Size(596, 465);
            this.DgPermissionsList.TabIndex = 0;
            // 
            // DgPermissionsListUserId
            // 
            this.DgPermissionsListUserId.HeaderText = "User Id";
            this.DgPermissionsListUserId.Name = "DgPermissionsListUserId";
            this.DgPermissionsListUserId.ReadOnly = true;
            // 
            // DgPermissionsListGuid
            // 
            this.DgPermissionsListGuid.HeaderText = "Guid";
            this.DgPermissionsListGuid.Name = "DgPermissionsListGuid";
            this.DgPermissionsListGuid.ReadOnly = true;
            // 
            // DeanLabelName
            // 
            this.DeanLabelName.AutoSize = true;
            this.DeanLabelName.Location = new System.Drawing.Point(62, 3);
            this.DeanLabelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeanLabelName.Name = "DeanLabelName";
            this.DeanLabelName.Size = new System.Drawing.Size(13, 13);
            this.DeanLabelName.TabIndex = 1;
            this.DeanLabelName.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // DeansList
            // 
            this.DeansList.FormattingEnabled = true;
            this.DeansList.Location = new System.Drawing.Point(5, 5);
            this.DeansList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeansList.Name = "DeansList";
            this.DeansList.Size = new System.Drawing.Size(152, 550);
            this.DeansList.TabIndex = 0;
            this.DeansList.SelectedIndexChanged += new System.EventHandler(this.DeansList_SelectedIndexChanged);
            // 
            // tabDean
            // 
            this.tabDean.Controls.Add(this.tabPage1);
            this.tabDean.Controls.Add(this.tabPage2);
            this.tabDean.Location = new System.Drawing.Point(1, 2);
            this.tabDean.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDean.Name = "tabDean";
            this.tabDean.SelectedIndex = 0;
            this.tabDean.Size = new System.Drawing.Size(785, 583);
            this.tabDean.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.StatementDeanList);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.BtnSaveStatement);
            this.tabPage2.Controls.Add(this.StatementSubject);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.StatementTitle);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.StatementUserId);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(777, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заявление";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StatementDeanList
            // 
            this.StatementDeanList.BackColor = System.Drawing.Color.White;
            this.StatementDeanList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatementDeanList.FormattingEnabled = true;
            this.StatementDeanList.Location = new System.Drawing.Point(97, 11);
            this.StatementDeanList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatementDeanList.Name = "StatementDeanList";
            this.StatementDeanList.Size = new System.Drawing.Size(679, 21);
            this.StatementDeanList.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Деканат";
            // 
            // BtnSaveStatement
            // 
            this.BtnSaveStatement.Location = new System.Drawing.Point(651, 193);
            this.BtnSaveStatement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSaveStatement.Name = "BtnSaveStatement";
            this.BtnSaveStatement.Size = new System.Drawing.Size(124, 31);
            this.BtnSaveStatement.TabIndex = 6;
            this.BtnSaveStatement.Text = "Подать заявление";
            this.BtnSaveStatement.UseVisualStyleBackColor = true;
            this.BtnSaveStatement.Click += new System.EventHandler(this.BtnSaveStatement_Click);
            // 
            // StatementSubject
            // 
            this.StatementSubject.Location = new System.Drawing.Point(97, 102);
            this.StatementSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatementSubject.MaxLength = 1500;
            this.StatementSubject.Name = "StatementSubject";
            this.StatementSubject.Size = new System.Drawing.Size(679, 87);
            this.StatementSubject.TabIndex = 5;
            this.StatementSubject.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Описание";
            // 
            // StatementTitle
            // 
            this.StatementTitle.Location = new System.Drawing.Point(97, 70);
            this.StatementTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatementTitle.MaxLength = 255;
            this.StatementTitle.Name = "StatementTitle";
            this.StatementTitle.Size = new System.Drawing.Size(679, 20);
            this.StatementTitle.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Заголовок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID пользователя";
            // 
            // StatementUserId
            // 
            this.StatementUserId.Location = new System.Drawing.Point(97, 41);
            this.StatementUserId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatementUserId.MaxLength = 5;
            this.StatementUserId.Name = "StatementUserId";
            this.StatementUserId.Size = new System.Drawing.Size(679, 20);
            this.StatementUserId.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 29);
            this.label8.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 587);
            this.Controls.Add(this.tabDean);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "iUniversity";
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAllUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRegUsersInDean)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDeanStatementsList)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPermissionsList)).EndInit();
            this.tabDean.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnRegistrationUserInDean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GridAllUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllUId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllUSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllUUName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllUPatronumyc;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllUJob;
        private System.Windows.Forms.DataGridView GridRegUsersInDean;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn UName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronumyc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCreateNewUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DeanLabelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox DeansList;
        private System.Windows.Forms.TabControl tabDean;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox StatementSubject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StatementTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StatementUserId;
        private System.Windows.Forms.Button BtnSaveStatement;
        private System.Windows.Forms.ComboBox StatementDeanList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DataGridDeanStatementsList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgStatementUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgStatementTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgStatementSubject;
        private System.Windows.Forms.Button BtnRemoveStatement;
        private System.Windows.Forms.Button BtnDeletePermission;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DgPermissionsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgPermissionsListUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgPermissionsListGuid;
    }
}

