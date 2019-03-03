using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PenguinComparison.Models;

namespace PenguinComparison.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //TODO : update about box with my contact info and app purpose
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Compare()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult Submit(Compare model)
        {
            //todo : replace this code with the commented out block
            //model.CostPerPerson = 12.50;
            //return View(model);
            
             // create the list of accomodations. 

            List<Lodging> LodgingList = new List<Lodging>();
            LodgingList.Add(new Lodging("Penguin"));
            LodgingList[0].LoadMemberRates(475, 150, 125, 400);
            LodgingList[0].LoadReservation(model);
            //TODO : thePenguin.LoadGuestRates();

            //TODO : pass in typical cost for 4 person 2 night stay
            //      and calculate a per person per night average.
            //      and use that figure to extrapolate all other cost 
            //      inquiries.
            LodgingList.Add(new Lodging("Woodstock"));
            LodgingList[1].LoadGuestRates(4,236);
            LodgingList[1].LoadReservation(model);
            LodgingList.Add(new Lodging("Pollard Brook"));
            LodgingList[2].LoadGuestRates(4, 273.50);
            LodgingList[2].LoadReservation(model);
            LodgingList.Add(new Lodging("Mountain Club"));
            LodgingList[3].LoadGuestRates(4, 541.50);
            LodgingList[3].LoadReservation(model);

            return View(LodgingList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}