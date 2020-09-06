using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CWsite.Models;
using Microsoft.AspNetCore.Http;

namespace CWsite.Controllers
{
    public class LocationsController : Controller
    {

        public IActionResult Message(int loc)
        {
            string location = "";
            if (Request.Form.TryGetValue("message", out var messageValue))
            {
                if (loc == 0) location = "Questions";
                if (loc == 1) location = "ThunderClan";
                if (loc == 2) location = "RiverClan";
                if (loc == 3) location = "WindClan";
                if (loc == 4) location = "ShadowClan";
                if (loc == 5) location = "FourTrees";
                if (loc == 6) location = "Loners";

                var time = DateTime.Now;
                var author = HttpContext.Session.GetString("author");
                RegistrationModel.Users.TryGetValue(author, out var user);
                var message = (string)messageValue;
                PostModel.Add(location, new Post(time, user._currentName, message));
            }

            return Redirect(location);
        }

        public IActionResult Questions()
        {
            return View();
        }

        public IActionResult FourTrees()
        {
            return View();
        }

        public IActionResult Loners()
        {
            return View();
        }

        public IActionResult RiverClan()
        {
            return View();
        }

        public IActionResult ShadowClan()
        {
            return View();
        }

        public IActionResult ThunderClan()
        {
            return View();
        }

        public IActionResult WindClan()
        {
            return View();
        }
    }
}
