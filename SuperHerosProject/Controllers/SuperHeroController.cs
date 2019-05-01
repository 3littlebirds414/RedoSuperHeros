using SuperHerosProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHerosProject.Controllers
{
    public class SuperHeroController : Controller
    {
        ApplicationDbContext context;
        public SuperHeroController()
        {
            context = new ApplicationDbContext();
        }

        // GET: SuperHero
        public ActionResult Index()
        {
            var listOfSuperHeros = context.SuperHeros.ToList();
            return View(listOfSuperHeros);
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int id)
        {
            var superHero = context.SuperHeros.Find(id);
            return View(superHero);
        }

        // GET: SuperHero/Create
        public ActionResult Create()
        {
            SuperHero superHero = new SuperHero();
            return View(superHero);
        }

        // POST: SuperHero/Create
        [HttpPost]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                context.SuperHeros.Add(superHero);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHero superHero = context.SuperHeros.Find(id);
            return View(superHero);
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SuperHero superHero)
        {
            try
            {
                //Natalie TODO
                //I think its a Bind function
                //context.SuperHeros.(superHero);
                //NATALIE: SuperHero heroFromDb; // query for me!
                SuperHero heroFromDb = context.SuperHeros.Find(id);
                heroFromDb.Name = superHero.Name;
                heroFromDb.AlterEgo = superHero.AlterEgo;
                heroFromDb.PrimarySuperHeroAbility = superHero.PrimarySuperHeroAbility;
                heroFromDb.SecondarySuperHeroAbility = superHero.SecondarySuperHeroAbility;
                heroFromDb.CatchPhrase = superHero.CatchPhrase;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int id)
        {
            SuperHero superHero = context.SuperHeros.Find(id);
            return View(superHero);
        }

        // POST: SuperHero/Delete/5
        [HttpPost,ActionName("Delete")]
        public ActionResult Delete(int id, SuperHero superHero)
        {
            try
            {
                //NATALIE: SuperHero heroFromDb = query for me!;
                SuperHero heroFromDb = context.SuperHeros.Find(id);
                context.SuperHeros.Remove(heroFromDb);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
