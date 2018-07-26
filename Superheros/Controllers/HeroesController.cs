using Microsoft.AspNet.Identity;
using Superheros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superheros.Controllers
{
    public class HeroesController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
     
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            return View(db.Heroes.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int ID)
        {
            var hero = db.Heroes.Where(h => h.ID == ID).First();
            return View(hero);
        }
        public ActionResult Delete(int ID)
        {
            var hero = db.Heroes.Where(h => h.ID == ID).First();
            return View(hero);                
        }

        public ActionResult Details(int ID)
        {
            var hero = db.Heroes.Where(h => h.ID == ID).First();
            return View(hero);                
        }


        [HttpPost]
        public ActionResult Create([Bind(Include = "ID, Name, AlterEgo, PrimaryAbility, SecondaryAbility, CatchPhrase")] Hero hero) 
        {
            if (ModelState.IsValid)
            {
                db.Heroes.Add(hero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hero);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(Hero hero)
        {
            if (ModelState.IsValid)
            {
                var deleteHero = db.Heroes.Where(h => hero.ID.Equals(hero.ID)).First();
                db.Heroes.Remove(deleteHero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hero);
        }

        [HttpPost]
        public ActionResult Details([Bind(Include = "")]Hero hero)
        {
                return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID, Name, AlterEgo, PrimaryAbility, SecondaryAbility, CatchPhrase")] Hero hero)
        {
            var updatedHero = db.Heroes.Where(h => h.ID == hero.ID).FirstOrDefault();
            updatedHero.Name = hero.Name;
            updatedHero.AlterEgo = hero.AlterEgo;
            updatedHero.PrimaryAbility = hero.PrimaryAbility;
            updatedHero.SecondaryAbility = hero.SecondaryAbility;
            updatedHero.CatchPhrase = hero.CatchPhrase;
            db.SaveChanges();
            return RedirectToAction("Index");
          
        }




    }
}