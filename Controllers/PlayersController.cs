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
    public class PlayersController : Controller
    {
        public IActionResult GetUser(string userName)
        {
            User u = new User();
            foreach (var user in RegistrationModel.Users)
            {
                if (user.Value._currentName == userName)
                {
                    u = user.Value;
                    break;
                }
            }
            if (HttpContext.Session.GetString("author") == u._login) return Redirect(nameof(Profile));
            HttpContext.Session.SetString("user", userName);
            return Redirect(nameof(Userpage));
        }

        public IActionResult Profile()
        {
            var name = new string(HttpContext.Session.GetString("author"));
            RegistrationModel.Users.TryGetValue(name, out var user);
            HttpContext.Session.SetString("user", user._currentName);
            return View();
        }

        public IActionResult Userpage()
        {
            return View();
        }

        public IActionResult GetClan(int clan)
        {
            if (clan == 1) HttpContext.Session.SetString("Clan", "Грозовое племя");
            if (clan == 2) HttpContext.Session.SetString("Clan", "Речное племя");
            if (clan == 3) HttpContext.Session.SetString("Clan", "Племя ветра");
            if (clan == 4) HttpContext.Session.SetString("Clan", "Племя теней");
            if (clan == 5) HttpContext.Session.SetString("Clan", "Звёздное племя");
            if (clan == 6) HttpContext.Session.SetString("Clan", "Одиночки/домашние");

            return Redirect(nameof(Clan));
        }

        public IActionResult Clan()
        {
            return View();
        }


    }
}
