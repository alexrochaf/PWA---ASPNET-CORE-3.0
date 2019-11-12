using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PWApp.Models;

namespace PWApp.Controllers
{
    public class SuperHeroiController : Controller
    {
        // GET: SuperHeroi
        public ActionResult Index()
        {
            return View();
        }

        // GET: SuperHeroi/Details/5
        public ActionResult Detalhes(int id)
        {
            return View();
        }

        // GET: SuperHeroi/Create
        public ActionResult Criar()
        {
            return View();
        }

        // POST: SuperHeroi/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroi/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: SuperHeroi/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroi/Delete/5
        public ActionResult Deletar(int id)
        {
            return View();
        }

        // POST: SuperHeroi/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}