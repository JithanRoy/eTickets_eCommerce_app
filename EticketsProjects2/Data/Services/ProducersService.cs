using eTickets.Data;
using eTickets.Models;
using EticketsProjects2.Data.Base;

namespace EticketsProjects2.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {

        }
    }
}
