﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelHub.Shared.Domain
{
    class ActivitySelection
    {
        public int AcsID { get; set; }
        public DateTime Date { get; set; }
        public int ItnID { get; set; }
        public virtual Itinerary Itinerary { get; set; }
        public int AcID { get; set; } 
        public virtual Activity Activity { get; set; }
    }
}