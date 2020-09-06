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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rules()
        {
            return View();
        }


        public IActionResult ListOfPlayers()
        {
            return View();
        }

        public IActionResult RolePlay()
        {
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }






        public IActionResult SignIn()
        {
            ViewBag.Error = null;

            if (Request.Method == "POST")
            {
                if (!Request.Form.TryGetValue("login", out var loginValue))
                {
                    ViewBag.Error = "Неправильный формат запроса!";
                    return View();
                }
                var login = (string)loginValue;

                if (!RegistrationModel.Users.Keys.Contains(login))
                {
                    ViewBag.Error = "Пользователя с таким логином не существует.";
                    return View();
                }

                RegistrationModel.Users.TryGetValue(login, out var user);

                Request.Form.TryGetValue("password", out var passwordValue);

                if (user._password != passwordValue.ToString())
                {
                    ViewBag.Error = "Неверный пароль.";
                    return View();
                }

                HttpContext.Session.SetString("author", login);
                return Redirect(nameof(Index));
            }
            return View();
        }

        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return Redirect(nameof(Index));
        }


        //логин не должен существовать
        //поля не должны быть пустыми
        //возраст не должен быть отрицательным? (не тут, в хтмл)
        //только русские буквы? (не тут?)
        //можно без описания?
        public IActionResult Registration()
        {
            ViewBag.Error = null;

            if (Request.Method == "POST")
            {
                /*if (!Request.Form.TryGetValue("kittenName", out var kittenName) ||
                    !Request.Form.TryGetValue("squireName", out var squireName) ||
                    !Request.Form.TryGetValue("warriorName", out var warriorName) ||
                    !Request.Form.TryGetValue("leaderName", out var leaderName) ||
                    !Request.Form.TryGetValue("age", out var age) ||
                    !Request.Form.TryGetValue("gender", out var gender) ||
                    !Request.Form.TryGetValue("clan", out var clan) ||
                    !Request.Form.TryGetValue("rank", out var rank) ||
                    !Request.Form.TryGetValue("login", out var login) ||
                    !Request.Form.TryGetValue("password", out var password) ||
                    !Request.Form.TryGetValue("password2", out var password2)
                    )
                {
                    ViewBag.Error = "Неправильный формат запроса!";
                    return View();
                }*/

                Request.Form.TryGetValue("kittenName", out var kittenName);
                Request.Form.TryGetValue("squireName", out var squireName);
                Request.Form.TryGetValue("warriorName", out var warriorName);
                Request.Form.TryGetValue("leaderName", out var leaderName);
                Request.Form.TryGetValue("age", out var age);
                Request.Form.TryGetValue("gender", out var gender);
                Request.Form.TryGetValue("clan", out var clan);
                Request.Form.TryGetValue("rank", out var rank);
                Request.Form.TryGetValue("login", out var login);
                Request.Form.TryGetValue("password", out var password);
                Request.Form.TryGetValue("password2", out var password2);

                if ((kittenName.ToString().Length < 1) || squireName.ToString().Length < 1 || warriorName.ToString().Length < 1 || 
                    leaderName.ToString().Length < 1 || age.ToString().Length < 1 || gender.ToString().Length < 1
                    || clan.ToString().Length < 1 || rank.ToString().Length < 1 || login.ToString().Length < 1
                    || password.ToString().Length < 1 || password2.ToString().Length < 1)
                {
                    ViewBag.Error = "Заполнены не все обязательные поля.";
                    return View();
                }

                if (RegistrationModel.Users.Keys.Contains(login))
                {
                    ViewBag.Error = "Пользователь с таким логином уже существует.";
                    return View();
                }

                if (password != password2)
                {
                    ViewBag.Error = "Пароли не совпадают!";
                    return View();
                }
                Request.Form.TryGetValue("description", out var description);
                RegistrationModel.Add(new User((string)kittenName, (string)squireName, (string)warriorName, (string)leaderName, (string)age, (string)gender, (string)clan,
            (string)rank, (string)description, (string)login, (string)password));


                HttpContext.Session.SetString("author", login);
                return Redirect(nameof(Index));
            }
            return View();
        }


        public IActionResult Editing()
        {
            return View();
        }


        public IActionResult Edit()
        {
            ViewBag.Error = null;

            if (Request.Method == "POST")
            {
                Request.Form.TryGetValue("login", out var login);
                RegistrationModel.Users.TryGetValue(login, out var user);

                /*Request.Form.TryGetValue("kittenName", out var kittenName);
                if (kittenName.ToString().Length > 1)
                {
                    user._kittenName = (string)kittenName;
                }
                Request.Form.TryGetValue("squireName", out var squireName);
                if (squireName.ToString().Length > 1)
                {
                    user._squireName = (string)squireName;
                }

                Request.Form.TryGetValue("warriorName", out var warriorName);
                if (warriorName.ToString().Length > 1)
                {
                    user._warriorName = (string)warriorName;
                }
                Request.Form.TryGetValue("leaderName", out var leaderName);
                if (leaderName.ToString().Length > 1)
                {
                    user._leaderName = (string)leaderName;
                }*/

                if (Request.Form.TryGetValue("currentName", out var currentName) && currentName.ToString().Length > 1)
                {
                    user._currentName = (string)currentName;
                }

                if (Request.Form.TryGetValue("age", out var age) && age.ToString().Length > 0)
                {
                    user._age = (string)age;
                }

                if (Request.Form.TryGetValue("clan", out var clan) && clan.ToString().Length > 1)
                {
                    user._clan = (string)clan;
                }

                if (Request.Form.TryGetValue("rank", out var rank) && rank.ToString().Length > 1)
                {
                    user._rank = (string)rank;
                }
                Request.Form.TryGetValue("password", out var password);
                Request.Form.TryGetValue("password2", out var password2);
                if (password.ToString().Length > 1)
                {
                    if (password != password2)
                    {
                        ViewBag.Error = "Пароли не совпадают!";
                        return Redirect(nameof(Editing));
                    }
                    else
                    {
                        user._password = (string)password;
                    }
                }
                Request.Form.TryGetValue("description", out var description);
                if (description.ToString().Length > 0)
                {
                    user._description = (string)description;
                }
                return Redirect(nameof(Index));
            }
            return Redirect(nameof(Editing));
        }







        public IActionResult GetUser()
        {
            return View();
        }



    }

}