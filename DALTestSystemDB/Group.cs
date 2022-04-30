﻿using System.Collections.Generic;

namespace DALTestingSystemDB
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAdminGroup { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public Group()
        {
            Users = new List<User>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}