using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CougBites.Models
{
    public class Profile
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; } 
    }
}
