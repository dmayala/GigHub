using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Core.Repositories
{
    public interface IGigRepository
    {
        Gig GetGigWithAttendee(int gigId);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        object GetUpcomingGigsByArtist(string userId);
        Gig GetGig(int gigId);
        void Add(Gig gig);
    }
}