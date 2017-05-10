using System;

namespace iUniversity
{
    class Permission
    {
        public string Id { get; set; }
        public string Uid { get; }

        public Permission(string userId)
        {
            Id = userId;
            Uid = GenerateUserUid();
        }

        private string GenerateUserUid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
