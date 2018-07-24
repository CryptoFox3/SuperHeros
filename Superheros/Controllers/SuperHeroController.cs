using Superheros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superheros.Controllers
{
    public class SuperHeroController : Controller
    {
        // GET: SuperHero
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListHeros()
        {
            List<Hero> superheros = new List<Hero>();

            superheros.Add(new Hero { ID = 1, Name = "Spoderman", PrimaryAbility = " ", SecondaryAbility = " ", AlterEgo = " ", CatchPhrase = " ", });
            superheros.Add(new Hero { ID = 1, Name = "Spoderman", PrimaryAbility = " ", SecondaryAbility = " ", AlterEgo = " ", CatchPhrase = " ", });
            superheros.Add(new Hero { ID = 1, Name = "Spoderman", PrimaryAbility = " ", SecondaryAbility = " ", AlterEgo = " ", CatchPhrase = " ", });
            superheros.Add(new Hero { ID = 1, Name = "Spoderman", PrimaryAbility = " ", SecondaryAbility = " ", AlterEgo = " ", CatchPhrase = " ", });
            superheros.Add(new Hero { ID = 1, Name = "Spoderman", PrimaryAbility = " ", SecondaryAbility = " ", AlterEgo = " ", CatchPhrase = " ", });

            return View();
        }
    }
}