using eTickets.Models;
using EticketsProjects2.Data.Base;

namespace EticketsProjects2.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
    }
}
