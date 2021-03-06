﻿using System.Collections.Generic;
using System.Linq;
using GigHub.Core.Models;

namespace GigHub.ViewModels
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; internal set; }
        public bool ShowActions { get; internal set; }
        public string Heading { get; set; }
        public string SearchTerm { get; set; }
        public ILookup<int, Attendance> Attendances { get; set; }
    }
}