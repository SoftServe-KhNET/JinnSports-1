﻿using System;
using System.Collections.Generic;

namespace JinnSports.Entities
{
    public class Result
    {
        public int Id { get; set; }
        public virtual Team Team { get; set; }
        public virtual CompetitionEvent CompetitionEvent { get; set; }
        public string Score { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Result result = (Result)obj;
            return ((result.Team.Id == Team.Id) && (result.CompetitionEvent.Id == CompetitionEvent.Id));
        }

        public override string ToString()
        {
            return "Id: " + " TeamId: " + " EventId: " + CompetitionEvent.Id + " Score: " + Score;
        }
    }
}
