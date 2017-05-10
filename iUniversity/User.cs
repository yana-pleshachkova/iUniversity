using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iUniversity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patromumyc { get; set; }
        public string Job { get; set; }

        public User(int id, string name, string surname, string patronumyc, string job)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Patromumyc = patronumyc;
            Job = job;
        }
    }
}
