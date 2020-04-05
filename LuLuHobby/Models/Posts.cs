using System;
using System.Collections.Generic;

namespace LuLuHobby.Models
{
    public partial class Posts
    {
        public int PostId { get; set; }
        public string ContentUrl { get; set; }
        public DateTime? PostDate { get; set; }
        public int UserId { get; set; }
        public int HobbyId { get; set; }

        public virtual Hobbies Hobby { get; set; }
        public virtual Users User { get; set; }
    }
}
