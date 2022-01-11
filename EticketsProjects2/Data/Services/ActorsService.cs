using eTickets.Data;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace EticketsProjects2.Data.Services
{
    public class ActorsService : IActorService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public void AddAsync(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result =await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetById(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
        }

        public Actor update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
