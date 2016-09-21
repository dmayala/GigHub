using GigHub.Core.Models;
using System.Collections.Generic;

namespace GigHub.Core.Repositories
{
    public interface IGigRepository
    {
        Gig GetGigWithAttendee(int gigId);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        object GetUpcomingGigsByArtist(string userId);
        Gig GetGig(int gigId);
        void Add(Gig gig);
        IEnumerable<Gig> GetUpcomingGigs(string query);
    }
}