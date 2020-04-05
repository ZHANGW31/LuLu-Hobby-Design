using System;
using System.Collections.Generic;

namespace LuLuHobby.Models
{
    public partial class Users
    {
        public Users()
        {
            Posts = new HashSet<Posts>();
        }

        public int UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthday { get; set; }

        public virtual ICollection<Posts> Posts { get; set; }
    }
}
