using GigHub.Models;
using System.Collections.Generic;

namespace GigHub.ViewModels
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; internal set; }
        public bool ShowActions { get; internal set; }
        public string Heading { get; set; }
    }
}