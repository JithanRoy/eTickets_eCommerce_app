using eTickets.Models;

namespace EticketsProjects2.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor update(int id, Actor newActor);
        void Delete(int id);
    }
}
