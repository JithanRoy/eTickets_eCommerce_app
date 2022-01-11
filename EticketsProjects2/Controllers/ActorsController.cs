using eTickets.Data;
using eTickets.Models;
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

        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActorService Get_service()
        {
            return _service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = _service.GetById(id);

            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }
    }
}
