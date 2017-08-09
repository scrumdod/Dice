using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dice.Model;

namespace Dice.Controllers
{
    public class ShowGameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowRolls()
        {
            DiceScores scores = new DiceScores();
            scores.Generate("test");
            ViewData["id"] = 1;
            return View(scores.Scores);
        }
        [HttpPost]
        public IActionResult Next(List<TurnScore> scores)
        {
            string Id = Request.Form["id"];
            int numId = Convert.ToInt32(Id);
            if (!string.IsNullOrEmpty(Request.Form["Next"]))
            {
                if(Convert.ToInt32(Id)<100)
                    numId++;
            }
            else
                if(Convert.ToInt32(Id)>1)
                    numId--;

            ViewData["id"] = numId;
            return View("ShowRolls", scores);
        }
    }
        
}
