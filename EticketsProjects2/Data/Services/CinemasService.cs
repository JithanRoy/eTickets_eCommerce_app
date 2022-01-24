using eTickets.Data;
using eTickets.Models;
using EticketsProjects2.Data.Base;

namespace EticketsProjects2.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        private readonly AppDbContext _context;
        public CinemasService(AppDbContext context): base(context)
        {

        }
    }
}
