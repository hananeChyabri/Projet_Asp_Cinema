using BLL_Projet_Cinema.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet_Cinema_Films.Handlers;
using Projet_Cinema_Films.Models;
using Shared_Projet_Cinema.Repositories;

namespace Projet_Cinema_Films.Controllers
{
    public class DiffusionController : Controller
    {
        private readonly IDiffusionRepository<Diffusion> _diffusionRepository;

        public DiffusionController(IDiffusionRepository<Diffusion> diffusionRepository)
        {
            _diffusionRepository = diffusionRepository;

        }


        // GET: DiffusionController
        public ActionResult Index()
        {
            IEnumerable<DiffusionListItemViewModels> model = _diffusionRepository.Get().Select(d => d.ToListItem());
            return View(model);
        }

        // GET: DiffusionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DiffusionController/Create/id_cinemaplace
        public ActionResult Create(int id_cinemaPlace)
        {
            ViewBag.Id = id_cinemaPlace;
            return View();
        }

        // POST: DiffusionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DiffusionCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
                if (!ModelState.IsValid) throw new Exception();
                int id = _diffusionRepository.Insert(form.ToBLL()); 
                return RedirectToAction(nameof(Details), new { id });
            }
            catch
            {
                return View();
            }
        }

        // GET: DiffusionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DiffusionController/Edit/5
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

        // GET: DiffusionController/Delete/5
        public ActionResult Delete(int id)
        {
            DiffusionDeleteForm model = _diffusionRepository.Get(id).ToDelete();
            if (model is null)
            {
                TempData["Error"] = "Diffusion inexistante...";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // POST: DiffusionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, DiffusionDeleteForm form)
        {
            try
            {
                int idCinemaPlace = form.Id_cinemaPlace;
               _diffusionRepository.Delete(id);
       
                return RedirectToAction(nameof(Details),nameof(CinemaPlace), new { id = form.Id_cinemaPlace }); 
            }
            catch
            {
                TempData["Error"] = "Erreur de suppression...";
                return View();
            }
        }
    }
}
