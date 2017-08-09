using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dice.Model;

namespace Dice.Controllers
{
    public class NewGameController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {           
            return View();
        }
        public IActionResult Generate(string teamName)
        {
           
           
            return RedirectToAction("ShowRolls", "ShowGame");           
        }
    }
}
