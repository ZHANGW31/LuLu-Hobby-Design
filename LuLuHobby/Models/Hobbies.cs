using System;
using System.Collections.Generic;

namespace LuLuHobby.Models
{
    public partial class Hobbies
    {
        public Hobbies()
        {
            Posts = new HashSet<Posts>();
        }

        public int HobbyId { get; set; }
        public string HobbyName { get; set; }
        public string HobbyType { get; set; }

        public virtual ICollection<Posts> Posts { get; set; }
    }
}
