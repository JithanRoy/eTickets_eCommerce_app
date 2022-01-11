using eTickets.Data;
using EticketsProjects2.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace EticketsProjects2.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _service;

        public ActorsController(IActorService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data =await _service.GetAll();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
