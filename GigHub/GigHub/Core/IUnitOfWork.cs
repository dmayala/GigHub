using GigHub.Core.Repositories;

namespace GigHub.Core
{
    public interface IUnitOfWork
    {
        IGigRepository Gigs { get; }
        IGenreRepository Genres { get; set; }
        IFollowingRepository Followings { get; set; }
        IAttendanceRepository Attendances { get; set; }
        void Complete();
    }
}