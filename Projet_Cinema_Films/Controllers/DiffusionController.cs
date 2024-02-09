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
            return View();
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
            return View();
        }

        // POST: DiffusionController/Delete/5
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
