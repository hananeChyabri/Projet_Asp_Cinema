using BLL_Projet_Cinema.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet_Cinema_Films.Handlers;
using Projet_Cinema_Films.Models;
using Shared_Projet_Cinema.Repositories;

namespace Projet_Cinema_Films.Controllers
{
    public class CinemaRoomController : Controller
    {

        private readonly ICinemaRoomRepository<CinemaRoom> _cinemaRoomRepository;

        public CinemaRoomController(ICinemaRoomRepository<CinemaRoom> cinemaRoomRepository)
        {
            _cinemaRoomRepository = cinemaRoomRepository;
        }


        // GET: CinemaRoomController
        public ActionResult Index()
        {
            IEnumerable<CinemaRoomListItemViewModels> model = _cinemaRoomRepository.Get().Select(d => d.ToListItem());

            return View(model);
        }

        // GET: CinemaRoomController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CinemaRoomController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CinemaRoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CinemaRoomCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
                if (!ModelState.IsValid) throw new Exception();
                int id = _cinemaRoomRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new { id });
            }
            catch
            {
                return View();
            }
        }

        // GET: CinemaRoomController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CinemaRoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CinemaRoomController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CinemaRoomController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
