using System;

namespace iUniversity
{
    class Permission
    {
        public string Id { get; set; } // id пользователя
        public string Uid { get; } //id пропуска

        public Permission(string userId)
        {
            Id = userId;
            Uid = GenerateUserUid();
        }

        private string GenerateUserUid() //создает id, когда вызываем, возвращает сроку - уникальный id пропуска (генерируется в Guid)
        {
            return Guid.NewGuid().ToString(); // (GUID) - глобальный уникальный идентификатор, 
                                             //NewGuid() - метод, инициализирует новый экземпляр структуры Guid
        }
    }
}
