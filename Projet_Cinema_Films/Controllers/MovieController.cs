using BLL_Projet_Cinema.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet_Cinema_Films.Handlers;
using Projet_Cinema_Films.Models;
using Shared_Projet_Cinema.Repositories;

namespace Projet_Cinema_Films.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository<Movie> _movieRepository;

        public MovieController(IMovieRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;

        }
        // GET: MovieController
        public ActionResult Index()
        {
            IEnumerable<MovieListItemViewModels> model = _movieRepository.Get().Select(d => d.ToListItem());

            return View(model);
       
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
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

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
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
