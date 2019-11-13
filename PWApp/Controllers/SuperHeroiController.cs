using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PWApp.Models;
using System;
using System.IO;
using System.Linq;

namespace PWApp.Controllers
{
    public class SuperHeroiController : Controller
    {
        private readonly HeroisContext context;
        private readonly IWebHostEnvironment webHostEnvironment;


        public SuperHeroiController(HeroisContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
        }
        // GET: SuperHeroi
        public ActionResult Index(string busca = "")
        {
            var superHerois = context.SuperHeroi.Where(x => x.Nome.Contains(busca.ToLower()) || x.SuperPoder.Contains(busca.ToLower())).Take(10);
            return View(superHerois);
        }

        // GET: SuperHeroi/Details/5
        public ActionResult Detalhes(int id)
        {
            var superHeroi = context.SuperHeroi.FirstOrDefault(x => x.Id == id);
            return View(superHeroi);
        }

        // GET: SuperHeroi/Create
        public ActionResult Criar()
        {

            return View();
        }

        // POST: SuperHeroi/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(SuperHeroi superHeroi, IFormFile file)
        {
            string pasta = "images";

            var nomeArquivo = GetUniqueFileName(file.FileName);
            var uploads = Path.Combine(@"D:\home\site", pasta);
            var filePath = Path.Combine(uploads, nomeArquivo);

            FileInfo fi = new FileInfo(file.FileName);

            string caminhoWebRoot = webHostEnvironment.WebRootPath;

            file.CopyTo(new FileStream(filePath, FileMode.Create));

            superHeroi.AdicionarFoto(filePath);

            context.SuperHeroi.Add(superHeroi);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));

        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int id)
        {
            try
            {
                var superHeroi = context.SuperHeroi.FirstOrDefault(x => x.Id == id);
                context.SuperHeroi.Remove(superHeroi);
                context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
