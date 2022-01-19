using eTickets.Data;
using eTickets.Models;
using EticketsProjects2.Data.Base;
using Microsoft.EntityFrameworkCore;

namespace EticketsProjects2.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context) : base(context) { }

    }
}
