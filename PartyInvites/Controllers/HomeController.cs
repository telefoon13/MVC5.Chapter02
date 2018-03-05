using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ViewResult Index()
        /* public RedirectResult = Redirect naar andere url
        * public String = Enkel string geven
        * public HttpUnauthorizedResult = Force user to login
        * Meer in Hoofdstuk 17
        */
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Goede morgen deze morgen" : "Goede middag";

            return View();
        }


        // GET : RsvpForm
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        //POST : RsvpForm
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO email sturen naar organisator
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
            
        }
    }
}