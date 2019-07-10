using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;
using Microsoft.AspNetCore.Http;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("IsPlaying") == null)
            {
                HttpContext.Session.SetInt32("IsPlaying",1);
                HttpContext.Session.SetInt32("Happiness",20);
                HttpContext.Session.SetInt32("Fullness",20);
                HttpContext.Session.SetInt32("Energy",50);
                HttpContext.Session.SetInt32("Meals",3);
                HttpContext.Session.SetString("Message", "welcome to dojodachi");
                ViewBag.Happiness = (int)HttpContext.Session.GetInt32("Happiness");
                ViewBag.Fullness = (int)HttpContext.Session.GetInt32("Fullness");
                ViewBag.Energy = (int)HttpContext.Session.GetInt32("Energy");
                ViewBag.Meals = (int)HttpContext.Session.GetInt32("Meals");
                ViewBag.Message = HttpContext.Session.GetString("Message");
                return View();
            }
            else
                if (HttpContext.Session.GetInt32("Happiness")>= 100 || HttpContext.Session.GetInt32("Energy")>= 100 || HttpContext.Session.GetInt32("Fullness")>= 100)
                {
                    return View("Win");
                }
                else if (HttpContext.Session.GetInt32("Happiness")<= 0 || HttpContext.Session.GetInt32("Happiness")<= 0)
                {
                    return View("Lose");
                }
                ViewBag.Happiness = (int)HttpContext.Session.GetInt32("Happiness");
                ViewBag.Fullness = (int)HttpContext.Session.GetInt32("Fullness");
                ViewBag.Energy = (int)HttpContext.Session.GetInt32("Energy");
                ViewBag.Meals = (int)HttpContext.Session.GetInt32("Meals");
                ViewBag.Message = HttpContext.Session.GetString("Message");
                return View();

            
        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            Console.WriteLine("Feeding...");
            int meals = (int)HttpContext.Session.GetInt32("Meals");
            int fullness = (int)HttpContext.Session.GetInt32("Fullness");
            if (meals <= 0 )
            {
                HttpContext.Session.SetString("Message", "You have no food");
                return RedirectToAction("Index");
            }
            else
            {
                meals --;
                Random rand = new Random();
                int eat = rand.Next(5,10);
                HttpContext.Session.SetInt32("Meals",meals);
                HttpContext.Session.SetInt32("Fullness", eat + fullness);
                HttpContext.Session.SetString("Message", $" Your pet ate a meal and is {eat} much fuller.");
                return RedirectToAction("Index");
            }

        }

        
        [HttpGet("play")]
        public IActionResult Play()
        {
            int energy = (int)HttpContext.Session.GetInt32("Energy");
            int happiness = (int)HttpContext.Session.GetInt32("Happiness");
            if(energy <=4)
            {
                HttpContext.Session.SetString("message", "Your pet is tired.");
                return RedirectToAction("Index");
            }
            else
            {
            Random rand = new Random();
            int play = rand.Next(5,10);
            energy -=5;
            HttpContext.Session.SetInt32("Happiness", happiness + play);
            HttpContext.Session.SetInt32("Energy", energy);
            HttpContext.Session.SetString("Message", $"YOu played with your pet, and it has {play} much more energy.");
            return RedirectToAction("Index");

            }
            
        }

        
        [HttpGet("work")]
        public IActionResult Work()
        {
            int energy = (int)HttpContext.Session.GetInt32("Energy");
            int meals = (int)HttpContext.Session.GetInt32("Meals");
            if (energy <= 4 )
            {
                HttpContext.Session.SetString("message", "Your pet is tired.");
                return RedirectToAction("Index");
            }
            else
            {
                Random rand = new Random();
                int work = rand.Next(1,3);
                energy -= 5;
                HttpContext.Session.SetInt32("Energy", energy);
                HttpContext.Session.SetInt32("Meals", meals + work);
                HttpContext.Session.SetString("Message", " Its been a long work day, your pet now has {work} more meals.");
                return RedirectToAction("Index");

            }
            
        }

        
        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            int energy = (int)HttpContext.Session.GetInt32("Energy");
            int fullness = (int)HttpContext.Session.GetInt32("Fullness");
            int happiness = (int)HttpContext.Session.GetInt32("Happiness");
            if(fullness <= 4)
            {
                HttpContext.Session.SetString("Message", "Your pet needs more foood");
                return RedirectToAction("Index");
            }
            else if (happiness <= 4)
            {
                HttpContext.Session.SetString("Message", "Your pet isnt happy.");
                return RedirectToAction("Index");
            }
            else
            {
                happiness -= 5;
                fullness -=5;
                energy +=15;
                HttpContext.Session.SetInt32("Happiness",happiness);
                HttpContext.Session.SetInt32("Fullness", fullness);
                HttpContext.Session.SetInt32("Energy", energy);
                HttpContext.Session.SetString("Message", "Your pet has been sleeping for hours, your pet has 15 more energy");
                return RedirectToAction("Index");

            }
            
        }

        [HttpGet("restart")]
        public IActionResult Restart ()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}
