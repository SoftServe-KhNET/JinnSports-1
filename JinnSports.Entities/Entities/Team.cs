﻿using System.Collections.Generic;

namespace JinnSports.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public virtual SportType SportType { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Result> Results { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Team t = (Team)obj;
            return ((t.Name == Name) && (SportType.Id == t.SportType.Id));
        }

        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name + "SportType: " + SportType.Name;
        }
    }


}
