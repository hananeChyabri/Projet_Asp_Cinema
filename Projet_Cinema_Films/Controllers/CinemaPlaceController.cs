using BLL_Projet_Cinema.Entities;
using Microsoft.AspNetCore.Mvc;
using Shared_Projet_Cinema.Repositories;
using Projet_Cinema_Films.Models;
using Projet_Cinema_Films.Handlers;

namespace Projet_Cinema_Films.Controllers
{
    public class CinemaPlaceController : Controller
    {
        private readonly ICinemaPlaceRepository<CinemaPlace> _cinemaPlaceRepository;

        public CinemaPlaceController(ICinemaPlaceRepository<CinemaPlace> cinemaPlaceRepository)
        {
            _cinemaPlaceRepository = cinemaPlaceRepository;
      
        }
        // GET: CinemaPlaceController
        public ActionResult Index()
        {
            IEnumerable<CinemaPlaceListItemViewModels> model = _cinemaPlaceRepository.Get().Select(d => d.ToListItem());

            return View(model);
        }

        // GET: CinemaPlaceController/Details/5
        public ActionResult Details(int id)
        {
            CinemaPlaceDetailsViewModel model = _cinemaPlaceRepository.Get(id).ToDetails();

            return View(model);
        }

        // GET: CinemaPlaceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CinemaPlaceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CinemaPlaceCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
                if (!ModelState.IsValid) throw new Exception();
                int id = _cinemaPlaceRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new { id });
            }
            catch
            {
                return View();
            }
        }

        // GET: CinemaPlaceController/Edit/5
        public ActionResult Edit(int id)
        {
            CinemaPlaceEditForm model = _cinemaPlaceRepository.Get(id).ToEdit();
            if (model is null)
            {
                TempData["ErrorMessage"] = $"Identifiant {id} invalide...";
                return RedirectToAction("Index");
            }
            return View(model);


        }

        // POST: CinemaPlaceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,CinemaPlaceEditForm form)
        {
            if (!ModelState.IsValid) return View(form);
            if (!_cinemaPlaceRepository.Update(id,form.ToBLL()))
            {
                ViewBag.Error = "Erreur lors de la mise à jour... Réessayez.";
                return View(form);
            }
            return RedirectToAction("Details", new { id = form.Id_CinemaPlace});
        }

        // GET: CinemaPlaceController/Delete/5
        public ActionResult Delete(int id)
        {
            CinemaPlaceDelete model = _cinemaPlaceRepository.Get(id).ToDelete();
            if (model is null)
            {
                TempData["Error"] = "Cinema inexistante...";
                return RedirectToAction("Index");
            }
            return View(model);
          
        }

        // POST: CinemaPlaceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CinemaPlace form)
        {
            try
            {
                _cinemaPlaceRepository.Delete(id);
                TempData["Error"] = "Erreur de suppression...";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }


        }
    }
}
