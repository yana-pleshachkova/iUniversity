using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace iUniversity
{
    public partial class Form1 : Form //partial - Частичное определение класса, создается автоматически
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
            var deanIit = new Dean(0, "ИИТ"); //создаем экземпляр класса Dean
            deanIit.RegistrationUser(0); deanIit.RegistrationUser(1); deanIit.RegistrationUser(2); //вызываем метод класса Dean
            _deans.Add(deanIit); //добавляем деканат в список деканатов


            // Список пользователей внтури деканата Матфака
            var deanMath = new Dean(1, "Математический");
            deanMath.RegistrationUser(3); deanMath.RegistrationUser(4); deanMath.RegistrationUser(5);
            _deans.Add(deanMath);

            foreach (var dean in _deans) // Добавляем деканаты в список на панели
            {
                DeansList.Items.Insert(dean.Id, dean.Id + "-" + dean.Name); // В элементы (Items) списка деканатов добавляем id и id+имя
                StatementDeanList.Items.Insert(dean.Id, dean.Id + "-" + dean.Name); //список деканатов в окне заявления
            }
        }

        public void ReDrawMainUsersList() // Выводим данные о всех пользователях в таблицу, отобразить заново список пользователей
        {
            GridAllUsers.Rows.Clear(); //очищаем область вывода всех пользователей, чтобы вывести другой список

            // Добавляем на панель всех пользователей
            foreach (var user in Users) //для каждого пользователя в глобальной базе данных (она сгенерирована в этой форме)
            {
                var realUser = (User)user; //создаем переменную пользователя и запихиваем туда пользователей из класса User, приводим их к типу User
                string[] row = {
                                    realUser.Id.ToString(), //для каждого пользователя выводим в таблицу его данные
                                    realUser.Surname,
                                    realUser.Name,
                                    realUser.Patromumyc,
                                    realUser.Job
                                };
                GridAllUsers.Rows.Add(row); //выводим новую сторку в графический интерфейс
            }
        }

        private void DeansList_SelectedIndexChanged(object sender, EventArgs e) // Выбираем деканат, здесь отображается список деканатов
        {
            //вызываем методы, что будет выводиться, когда выбрали деканат
            ReDrawMainUsersList(); // Обновляем список всех пользователей
            RedrawDeansUsersList(); // Обновляем список заявлений в деканате
            RedrawStatementsList(); // Обновляем список заявлений в деканате
            RedrawPermissionsList(); // Обновляем список пропусков
        }

        private void BtnDeleteUserInDean(object sender, EventArgs e) // Удалить пользователя из деканата
        {
            //проверяем, что в таблице выбран ли пользователь в таблице (в граф интерефейсе)
            if (GridRegUsersInDean.CurrentRow == null) return;
            if (DeansList.SelectedIndex == -1) return;

            var rowindex = GridRegUsersInDean.CurrentRow.Index; // получаем выделенную строку пользователя, CurrentRow - показывает выбранную строку, у нее есть индекс
            var idUser = GridRegUsersInDean.Rows[rowindex].Cells["Id"].Value != null ? Int32.Parse(GridRegUsersInDean.Rows[rowindex].Cells["Id"].Value.ToString()) : -1; //Cell - ячейка таблицы, получаем значение каждой ячейки строки

            // получаем идентификтаор деканата
            var tmpDeanId = DeansList.Items[DeansList.SelectedIndex].ToString().Split('-')[0]; //отделили id от имени деканата
            var realDeanId = Int32.Parse(tmpDeanId);

            // удаляем из списка пользователей в деканате, проходим по всему списку деканатов
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
                GridRegUsersInDean.Rows.RemoveAt(rowindex); // Удаляем из таблицы, в граф интерфейсе
            }
        }

        private void BtnRegistrationUserInDean_Click(object sender, EventArgs e) // Зарегестрировать пользователя в деканате 
        {
            //проверка на существование пользователя внутри метода в классе Dean

            //проверяем, выбрана ли строка и деканате
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

                    if (isReg) //проверка, зарегестрирован ли пользователь уже, чтобы не отображать дважды в интерфейсе
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

        private void BtnCreateNewUser_Click(object sender, EventArgs e) //редактиреум выбранного пользователя во всплывающем окне
        {
            //проверяем выбрана ли строка и деканат
            if (GridRegUsersInDean.CurrentRow == null) return;
            if (DeansList.SelectedIndex == -1) return;

            var rowindex = GridRegUsersInDean.CurrentRow.Index; // получаем выделенную строку пользователя

            if (GridRegUsersInDean.Rows[rowindex].Cells["Id"].Value == null) //если выделенная строка пуста
            {
                return; //ничего не делаем
            }

            var idUser = Int32.Parse(GridRegUsersInDean.Rows[rowindex].Cells["Id"].Value.ToString()); //получаем id пользователя

            foreach (object id in Users) //проходим по всем пользователям
            {
                var user = (User)id;

                if (user.Id == idUser) //находим выбранного
                {
                    EditUser form = new EditUser(user); //создаем экзепляр формы, куда передастся редактирование
                    form.ShowDialog(this); // Показать как всплывающее окно, this - текущий контекст, вся форма1
                }
            }
        }

        public void RedrawDeansUsersList() // Обновить информацию о пользователях в деканате
        {
            GridRegUsersInDean.Rows.Clear(); // очищаем список зарегистрированных пользователей одного деканата, когда переключаемся на другой
            
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
                            //проверяем, что пользователь с таким id есть в деканате
                            if (user.Id == userId)
                            {
                                object[] row = {
                                    user.Id.ToString(),
                                    user.Surname,
                                    user.Name,
                                    user.Patromumyc,
                                    user.Job
                                };
                                GridRegUsersInDean.Rows.Add(row); //создаем строку и выводим ее в интерфейс
                            }
                        }
                    }
                }
            }
        }

        private void BtnSaveStatement_Click(object sender, EventArgs e) //по нажатию отправляем в деканат заявление
        {
            var st = new Statement(StatementTitle.Text, StatementSubject.Text, StatementUserId.Text); //создаем экземпляр заявления
            var deanId = StatementDeanList.Text != "" ? int.Parse(StatementDeanList.Text.Split('-')[0]) : -1; //выбираем деканат

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
                        DataGridDeanStatementsList.Rows.Add(row); //выводит список всех заявлений
                    }
                }
            }
        }

        private void BtnRemoveStatement_Click(object sender, EventArgs e) //удаляет заявление из списка заявлений
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
                    dean.RemoveStatement(idUser, rowindex);
                    DataGridDeanStatementsList.Rows.RemoveAt(rowindex);
                }
            }
        }

        private void BtnViewStatement_Click(object sender, EventArgs e) //рассмотреть заявление
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
                    dean.RemoveStatement(idUser, rowindex);
                    DataGridDeanStatementsList.Rows.RemoveAt(rowindex);
                    RedrawPermissionsList();
                }
            }
        }

        private void BtnDeletePermission_Click(object sender, EventArgs e) //удалить пропуск
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
                    dean.RemovePermission(idUser, rowindex);
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
