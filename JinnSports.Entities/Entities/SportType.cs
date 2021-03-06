﻿using System;
using System.Collections.Generic;

namespace JinnSports.Entities
{
    public class SportType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            SportType st = (SportType)obj;
            return (st.Name == Name);
        }

        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name;
        }
    }
}
