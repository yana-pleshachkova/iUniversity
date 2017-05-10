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
            Users = new List<int>();
            Statements = new List<Statement>();
            Permissions = new List<Permission>();
        }

        public string Name { get; }
        public int Id { get; }
        public List<int> Users { get; }
        public List<Statement> Statements { get; }
        public List<Permission> Permissions { get; }

        public bool RegistrationUser(int idUser) // Зарегистрировать пользователя в деканате
        {
            if (!Users.Contains(idUser))
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
            if (!Users.Contains(int.Parse(st.UserId)))
            {
                return false;
            }

            Statements.Add(st);

            return true;
        }

        public void RemoveStatement(string userId)
        {
            int stIndex = -1;
            for (int i = 0; i < Statements.Count; i++)
            {
                if (userId == Statements[i].UserId)
                {
                    stIndex = i;
                }
            }

            if (stIndex != -1)
            {
                Statements.RemoveAt(stIndex);
            }
        }

        public void CreatePermission(string userId) // Регистрация новго пропуска
        {
            int permIndex = -1;
            for (int i = 0; i < Permissions.Count; i++)
            {
                if (userId == Permissions[i].Id)
                {
                    permIndex = i;
                }
            }

            if (permIndex != -1)
            {
                Permissions.RemoveAt(permIndex);
            }

            Permissions.Add(new Permission(userId));
        }

        public void RemovePermission(string userId)
        {
            int permIndex = -1;
            for (int i = 0; i < Permissions.Count; i++)
            {
                if (userId == Permissions[i].Id)
                {
                    permIndex = i;
                }
            }

            if (permIndex != -1)
            {
                Permissions.RemoveAt(permIndex);
            }
        }
    }
}
