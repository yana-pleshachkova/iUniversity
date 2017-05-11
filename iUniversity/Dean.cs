using System.Collections.Generic;
using System.Diagnostics;

namespace iUniversity
{
    internal class Dean
    {
        public Dean(int id, string name)
        {
            Id = id;
            Name = name;
            Users = new List<int>(); //сисок пользователей, где хранятся id пользователей
            Statements = new List<Statement>(); //создает список, с экземплярами класса Statement
            Permissions = new List<Permission>(); //создает список, с экземплярами класса Permission
        }

        public string Name { get; }
        public int Id { get; }
        public List<int> Users { get; }
        public List<Statement> Statements { get; }
        public List<Permission> Permissions { get; }

        public bool RegistrationUser(int idUser) // Зарегистрировать пользователя в деканате, idUser берем id пользователя из экземпляра класса User
        {
            if (!Users.Contains(idUser)) //метод String.Contains указывающет, содержит ли указанная строка значение подстроки 
            {
                Users.Add(idUser);
                return true;
            }

            return false;
        }

        public bool UnRegistrationUser(int idUser) // Удалить пользоватея из деканата
        {
            if (Users.Contains(idUser))
            {
                Users.Remove(idUser);
                return true;
            }

            return false;
        }

        public bool GetStatement(Statement st) // Принять заявление
        {
            if (!Users.Contains(int.Parse(st.UserId))) //если в списке пользователей деканата нет пользователя с таким id, которое указано в заявлении
            {
                return false;
            }

            Statements.Add(st); //если есть такой пользователь, то принимаем заявление

            return true;
        }

        public void RemoveStatement(string userId, int index) // удалить заявление из таблицы по ID пользователя и номеру записи
        {
            for (int i = 0; i < Statements.Count; i++)
            {
                if (userId == Statements[i].UserId && i == index)
                {
                    Statements.RemoveAt(i); //удаляет элемент списка List<T> с указанным индексом
                }
            }
        }

        public void CreatePermission(string userId) // Регистрация и восстановление пропуска
        {
            int permIndex = -1;
            for (int i = 0; i < Permissions.Count; i++)
            {
                if (userId == Permissions[i].Id) //если в списке пропусков есть пользователь с переданным id 
                {
                    permIndex = i;
                }
            }

            if (permIndex != -1)
            {
                Permissions.RemoveAt(permIndex); //удаляем элемент списка List<T> с указанным индексом, чтобы добавить новый
            }

            Permissions.Add(new Permission(userId)); //создаем новый пропуск с новым id
        }

        public void RemovePermission(string userId, int index) //удаление пропуска
        {
            for (int i = 0; i < Permissions.Count; i++)
            {
                if (userId == Permissions[i].Id && i == index)
                {
                    Permissions.RemoveAt(i);
                }
            }
        }
    }
}
