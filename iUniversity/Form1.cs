using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace iUniversity
{
    public partial class Form1 : Form
    {
        private readonly List<Dean> _deans = new List<Dean>(); // Список всех деканатов
        public readonly ArrayList Users = new ArrayList(); // Список всех пользователей

        public Form1() // Инициализация формы
        {
            InitializeComponent();

            // Всеь пользователи
            Users.Add(new User(0, "Иван", "Иванов", "Иванович", "Студент"));
            Users.Add(new User(1, "Сергей", "Васильевич", "Хасанов", "Преподаватель"));
            Users.Add(new User(2, "Майк", "Микрофонович", "Мой", "Студент"));
            Users.Add(new User(3, "Васятка", "Инно", "Петрович", "Преподаватель"));
            Users.Add(new User(4, "Илон", "Тескович", "Ракета", "Студент"));
            Users.Add(new User(5, "Масяня", "Овсянкин", "Котлета", "Преподаватель"));

            // Список пользователелей внутри деканата ИИТ
            var deanIit = new Dean(0, "ИИТ");
            deanIit.RegistrationUser(0); deanIit.RegistrationUser(1); deanIit.RegistrationUser(2);
            _deans.Add(deanIit);


            // Список пользователей внтури деканата Матфака
            var deanMath = new Dean(1, "Математический");
            deanMath.RegistrationUser(3); deanMath.RegistrationUser(4); deanMath.RegistrationUser(5);
            _deans.Add(deanMath);

            foreach (var dean in _deans) // Добавляем деканаты в список на панели
            {
                DeansList.Items.Insert(dean.Id, dean.Id + "-" + dean.Name);
                StatementDeanList.Items.Insert(dean.Id, dean.Id + "-" + dean.Name);
            }
        }

        public void ReDrawMainUsersList() // Выводим данные о всех пользователях в таблицу
        {
            GridAllUsers.Rows.Clear();

            // Добавляем на панель всех пользователей
            foreach (var user in Users)
            {
                var realUser = (User)user;
                object[] row = {
                                    realUser.Id.ToString(),
                                    realUser.Surname,
                                    realUser.Name,
                                    realUser.Patromumyc,
                                    realUser.Job
                                };
                GridAllUsers.Rows.Add(row);
            }
        }

        private void DeansList_SelectedIndexChanged(object sender, EventArgs e) // Выбираем деканат
        {
            ReDrawMainUsersList(); // Показываем список всех пользователей
            RedrawDeansUsersList(); // Показываем список заявлений в деканате
            RedrawStatementsList(); // Обновляем список заявлений в деканате
            RedrawPermissionsList(); // Показываем список пропусков
        }

        private void BtnDeleteUserInDean(object sender, EventArgs e) // Удалить пользователя из деканата
        {
            if (GridRegUsersInDean.CurrentRow == null) return;
            if (DeansList.SelectedIndex == -1) return;

            var rowindex = GridRegUsersInDean.CurrentRow.Index; // получаем выделенную строку пользователя
            var idUser = GridRegUsersInDean.Rows[rowindex].Cells["Id"].Value != null ? Int32.Parse(GridRegUsersInDean.Rows[rowindex].Cells["Id"].Value.ToString()) : -1;

            // получаем идентификтаор деканата
            var tmpDeanId = DeansList.Items[DeansList.SelectedIndex].ToString().Split('-')[0];
            var realDeanId = Int32.Parse(tmpDeanId);

            // удаляем из списка пользователей в деканате
            foreach (var dean in _deans)
            {
                if (dean.Id == realDeanId) // Находим выбранный деканат
                {
                    for (int i = 0; i < dean.Users.Count; i++)
                    {
                        dean.UnRegistrationUser(idUser); // Удаляем из списка пользователей в деканате
                    }
                }
            }

            if (GridRegUsersInDean.Rows[rowindex].Cells["Id"].Value != null)
            {
                GridRegUsersInDean.Rows.RemoveAt(rowindex); // Удаляем из таблицы
            }
        }

        private void BtnRegistrationUserInDean_Click(object sender, EventArgs e) // Удалить пользователя из деканата
        {
            if (GridAllUsers.CurrentRow == null) return;
            if (DeansList.SelectedIndex == -1) return;

            var rowindex = GridAllUsers.CurrentRow.Index; // получаем выделенную строку пользователя
            var idUser = GridAllUsers.Rows[rowindex].Cells["AllUId"].Value != null ? Int32.Parse(GridAllUsers.Rows[rowindex].Cells["AllUId"].Value.ToString()) : -1;

            // получаем идентификтаор деканата
            var tmpDeanId = DeansList.Items[DeansList.SelectedIndex].ToString().Split('-')[0];
            var realDeanId = Int32.Parse(tmpDeanId);

            // регистрируем пользователя в деканате
            foreach (var dean in _deans)
            {
                if (dean.Id == realDeanId) // Находим выбранный деканат
                {
                    bool isReg = dean.RegistrationUser(idUser); // Регистрируем

                    if (isReg)
                    {
                        foreach (object id in Users)
                        {
                            var user = (User)id;

                            if (user.Id == idUser)
                            {
                                object[] row = {
                                    user.Id.ToString(),
                                    user.Surname,
                                    user.Name,
                                    user.Patromumyc,
                                    user.Job
                                };
                                GridRegUsersInDean.Rows.Add(row);
                            }
                        }
                    }
                }
            }
        }

        private void BtnCreateNewUser_Click(object sender, EventArgs e)
        {
            if (GridRegUsersInDean.CurrentRow == null) return;
            if (DeansList.SelectedIndex == -1) return;

            var rowindex = GridRegUsersInDean.CurrentRow.Index; // получаем выделенную строку пользователя

            if (GridRegUsersInDean.Rows[rowindex].Cells["Id"].Value == null)
            {
                return;
            }

            var idUser = Int32.Parse(GridRegUsersInDean.Rows[rowindex].Cells["Id"].Value.ToString());

            foreach (object id in Users)
            {
                var user = (User)id;

                if (user.Id == idUser)
                {
                    EditUser form = new EditUser(user);
                    form.ShowDialog(this); // Показать как всплывающее окно
                }
            }
        }

        public void RedrawDeansUsersList() // Обновить информацию о пользователях в деканате
        {
            GridRegUsersInDean.Rows.Clear(); // очищаем список зарегистрированных пользователей
            
            if (DeansList.SelectedIndex == -1) return;

            // получаем идентификтаор деканата
            var tmpId = DeansList.Items[DeansList.SelectedIndex].ToString().Split('-')[0];
            var realId = Int32.Parse(tmpId);

            // Уснатавливаем информацию о деканате в панель
            foreach (var dean in _deans)
            {
                if (dean.Id == realId) // Находим выбранный деканат
                {
                    for (var i = dean.Users.Count - 1; i >= 0; i--) // Наполняем список пользователей в деканате
                    {
                        var userId = dean.Users[i];

                        foreach (object id in Users)
                        {
                            var user = (User)id;

                            if (user.Id == userId)
                            {
                                object[] row = {
                                    user.Id.ToString(),
                                    user.Surname,
                                    user.Name,
                                    user.Patromumyc,
                                    user.Job
                                };
                                GridRegUsersInDean.Rows.Add(row);
                            }
                        }
                    }
                }
            }
        }

        private void BtnSaveStatement_Click(object sender, EventArgs e)
        {
            var st = new Statement(StatementTitle.Text, StatementSubject.Text, StatementUserId.Text);
            var deanId = StatementDeanList.Text != "" ? int.Parse(StatementDeanList.Text.Split('-')[0]) : -1;

            // Зарегистрируем заявление в деканате
            foreach (var dean in _deans)
            {
                if (dean.Id == deanId) // Находим выбранный деканат
                {
                    bool isSetUser = dean.GetStatement(st); // Регистрируем заявление в деканате

                    if (!isSetUser) // Если пользователя нет в таком деканате
                    {
                        MessageBox.Show("Вы не являетесь участником данного деканата!");
                    }
                    else
                    {
                        RedrawStatementsList(); // Обновляем список заявлений в деканате
                    }
                }
            }
        }

        private void RedrawStatementsList() // Обновить информацию 
        {
            DataGridDeanStatementsList.Rows.Clear();
            if (DeansList.SelectedIndex == -1) return;

            // получаем идентификтаор деканата
            var tmpId = DeansList.Items[DeansList.SelectedIndex].ToString().Split('-')[0];
            var realId = Int32.Parse(tmpId);

            // Зарегистрируем заявление в деканате
            foreach (var dean in _deans)
            {
                if (dean.Id == realId) // Находим выбранный деканат
                {
                    var statements = dean.Statements;

                    foreach (var statement in statements)
                    {
                        object[] row = {
                            statement.UserId,
                            statement.Title,
                            statement.Subject
                        };
                        DataGridDeanStatementsList.Rows.Add(row);
                    }
                }
            }
        }

        private void BtnRemoveStatement_Click(object sender, EventArgs e)
        {
            if (DataGridDeanStatementsList.CurrentRow == null) return;
            if (DeansList.SelectedIndex == -1) return;

            // получаем идентификтаор деканата
            var tmpId = DeansList.Items[DeansList.SelectedIndex].ToString().Split('-')[0];
            var realDeanId = Int32.Parse(tmpId);

            var rowindex = DataGridDeanStatementsList.CurrentRow.Index; // получаем выделенную строку заявлений

            if (DataGridDeanStatementsList.Rows[rowindex].Cells["DgStatementUserId"].Value == null)
            {
                return;
            }

            var idUser = DataGridDeanStatementsList.Rows[rowindex].Cells["DgStatementUserId"].Value.ToString();

            // Сгенерируем новый пропуск
            foreach (var dean in _deans)
            {
                if (dean.Id == realDeanId) // Находим выбранный деканат
                {
                    // Удалим заявление из деканата
                    dean.RemoveStatement(idUser);
                    DataGridDeanStatementsList.Rows.RemoveAt(rowindex);
                }
            }
        }

        private void BtnViewStatement_Click(object sender, EventArgs e)
        {
            if (DataGridDeanStatementsList.CurrentRow == null) return;
            if (DeansList.SelectedIndex == -1) return;

            // получаем идентификтаор деканата
            var tmpId = DeansList.Items[DeansList.SelectedIndex].ToString().Split('-')[0];
            var realDeanId = Int32.Parse(tmpId);

            var rowindex = DataGridDeanStatementsList.CurrentRow.Index; // получаем выделенную строку заявлений

            if (DataGridDeanStatementsList.Rows[rowindex].Cells["DgStatementUserId"].Value == null)
            {
                return;
            }

            var idUser = DataGridDeanStatementsList.Rows[rowindex].Cells["DgStatementUserId"].Value.ToString();
            
            // Удалим заявление из деканата
            foreach (var dean in _deans)
            {
                if (dean.Id == realDeanId) // Находим выбранный деканат
                {
                    dean.CreatePermission(idUser); // Сгененрируем новый пропуск для пользователя
                    dean.RemoveStatement(idUser);
                    DataGridDeanStatementsList.Rows.RemoveAt(rowindex);
                    RedrawPermissionsList();
                }
            }
        }

        private void BtnDeletePermission_Click(object sender, EventArgs e)
        {
            if (DgPermissionsList.CurrentRow == null) return;
            if (DeansList.SelectedIndex == -1) return;

            // получаем идентификтаор деканата
            var tmpId = DeansList.Items[DeansList.SelectedIndex].ToString().Split('-')[0];
            var realDeanId = Int32.Parse(tmpId);

            var rowindex = DgPermissionsList.CurrentRow.Index; // получаем выделенную строку заявлений

            if (DgPermissionsList.Rows[rowindex].Cells["DgPermissionsListUserId"].Value == null)
            {
                return;
            }

            var idUser = DgPermissionsList.Rows[rowindex].Cells["DgPermissionsListUserId"].Value.ToString();

            // Удалим пропуск
            foreach (var dean in _deans)
            {
                if (dean.Id == realDeanId) // Находим выбранный деканат
                {
                    dean.RemovePermission(idUser);
                    DgPermissionsList.Rows.RemoveAt(rowindex);
                }
            }
        }

        private void RedrawPermissionsList()
        {
            DgPermissionsList.Rows.Clear();
            if (DeansList.SelectedIndex == -1) return;

            // получаем идентификтаор деканата
            var tmpId = DeansList.Items[DeansList.SelectedIndex].ToString().Split('-')[0];
            var realDeanId = Int32.Parse(tmpId);

            foreach (var dean in _deans)
            {
                if (dean.Id == realDeanId) // Находим выбранный деканат
                {
                    foreach (var permission in dean.Permissions)
                    {
                        object[] row = { permission.Id, permission.Uid };
                        DgPermissionsList.Rows.Add(row);
                    }
                }
            }
        }
    }
}
