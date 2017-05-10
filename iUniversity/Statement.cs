using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iUniversity
{
    class Statement
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public string UserId { get; set; }

        public Statement(string title, string subject, string userId)
        {
            Title = title;
            Subject = subject;
            UserId = userId;
        }
    }
}
