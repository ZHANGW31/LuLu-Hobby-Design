using System;
using System.Collections.Generic;

namespace LuLuHobby.Models
{
    public partial class Locations
    {
        public int LocationId { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
    }
}
