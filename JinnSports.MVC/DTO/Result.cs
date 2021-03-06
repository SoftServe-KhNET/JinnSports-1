﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinnSports.BLL.DTO
{
    class Result
    {
        public int Id { get; set; }
        public virtual Team Team { get; set; }
        public virtual CompetitionEvent CompetitionEvent { get; set; }
        public string Score { get; set; }
    }
}
