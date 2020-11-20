using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using blogging.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using blogging.viewmodels;
using System.IO;
using Microsoft.AspNetCore.Http;
using blogging.viewmodel;
using System.Collections.Generic;

namespace blogging.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHostingEnvironment hostingEnvironment;

        private static SignInManager<IdentityUser> signInManager;
        private  UserManager<IdentityUser> userManager;
        private Iuserreposetory iuserreposetory;

        private IstoryRepository istoryRepository;
        private string loggedin = null;
        public string isloggedin = "0";
        private string useremail = "_email";

        public HomeController(ILogger<HomeController> logger,IstoryRepository istoryRepository,Iuserreposetory iuserreposetory,IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            this.istoryRepository = istoryRepository;
            this.hostingEnvironment = hostingEnvironment;
            this.iuserreposetory = iuserreposetory;
        }

        [HttpGet]
        public IActionResult edit(int id)
        {
            ViewBag.login = true;
            story st = istoryRepository.Getstory(id);

            return View(st);

        }

        [HttpPost]
        public IActionResult edit(story st)
        {
            ViewBag.login = true;
            story st1 = istoryRepository.Update(st);

            return Redirect("~/Home/mystory");

        }

        [HttpGet]
        public IActionResult create()
        {

            ViewBag.login = false;
            if (HttpContext.Session.GetString(isloggedin) == "0")
            {
                return View("login");
            }
            ViewBag.login = true;
            return View();
        }


        public IActionResult show_allstory_of_perticular_user(string id)
        {
            ViewBag.login = false;
            if (HttpContext.Session.GetString(isloggedin) == "0")
            {
                return View("login");
            }
            ViewBag.login = true;
            string email = id;
            Users user = iuserreposetory.fetch(email);
            ViewBag.allstories = istoryRepository.GetAllstorybyuser(email);
            return View("public_story", user);
        }

        [HttpPost]
        public IActionResult create(story st)
        {
            ViewBag.login = true;
            st.userId = HttpContext.Session.GetString(useremail);
            st.createdat = DateTime.Now;
            story newst = istoryRepository.Add(st);
            return Redirect("~/Home/mystory");
        }
        public IActionResult show(int id)
        {

            ViewBag.login = false;
            if (HttpContext.Session.GetString(isloggedin) == "0")
            {
                return View("login");
            }
            ViewBag.login = true;
            story st = istoryRepository.Getstory(id);
            Users user = iuserreposetory.fetch(st.userId);
            storyViewModel model = new storyViewModel
            {
                body = st.body,
                title = st.title,
                photopath = user.photopath,
                firstname = user.firstname,
                lastname = user.lastname,
                email = user.email,
                createdat = st.createdat,
                status = st.status
            };
            return View(model);
        }

        public IActionResult mystory()
        {
            ViewBag.login = false;
            if (HttpContext.Session.GetString(isloggedin) == "0")
            {
                return View("login");
            }
            ViewBag.login = true;

            Users user = iuserreposetory.fetch(HttpContext.Session.GetString(useremail));
            ViewBag.allstories = null;
            ViewBag.allstories = istoryRepository.GetAllstory();
            return View(user);
        }

        public IActionResult delete(int id)
        {

            ViewBag.login = false;
            if (HttpContext.Session.GetString(isloggedin) == "0")
            {
                return View("login");
            }
            ViewBag.login = true;
            istoryRepository.Delete(id);
            return Redirect("~/Home/mystory");
        }

        public IActionResult index()
        {
            ViewBag.login = false;
            if (HttpContext.Session.GetString(isloggedin) == "0")
            {
                return View("login");
            }
            ViewBag.login = true;
            IEnumerable<Users> users = iuserreposetory.GetUsers();
             IList<storyViewModel> all = new List<storyViewModel>();
             foreach(Users user in users)
             {
                IEnumerable<story> st1 = istoryRepository.GetAllstorybyuser(user.email);
                storyViewModel st = new storyViewModel
                {
                    firstname = user.firstname,
                    lastname = user.lastname,
                    email = user.email,
                    photopath = user.photopath,
                    stories = st1
                };
                all.Add(st);
             }
            ViewBag.stories = all;
            return View();
        }

        
        public IActionResult error404()
        {

            ViewBag.login = false;
            if (HttpContext.Session.GetString(isloggedin) == "0")
            {
                return View("login");
            }

            ViewBag.login = true;
            return View();
        }

        [HttpGet]
        public IActionResult registration()
        {
            ViewBag.login = false;
            ViewBag.already = "0";
            ViewBag.post = "0";
            ViewBag.done = "0";
            ViewBag.pass = "0";
            return View();
        }

        [HttpPost]
        public IActionResult registration(UserCreateViewModel model)
        {
            ViewBag.login = false;
            ViewBag.post = "1";
            if (iuserreposetory.fetch(model.email) != null)
            {
                ViewBag.already = "1";
                ViewBag.done = "0";
                return View();
            }
            else if(model.password != model.repassword)
            {
                ViewBag.pass = "0";
                ViewBag.done = "0";
                return View();
            }
            else
            {
                ViewBag.done = "1";
                string uniquefilename = null;
                if (model.photo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniquefilename = Guid.NewGuid().ToString() + "_" + model.photo.FileName;
                    string filepath = Path.Combine(uploadsFolder, uniquefilename);
                    model.photo.CopyTo(new FileStream(filepath, FileMode.Create));
                }
                Users user = new Users
                {
                    firstname = model.firstname,
                    lastname = model.lastname,
                    email = model.email,
                    password = model.password,
                    photopath = uniquefilename
                };
                iuserreposetory.add(user);
                return View();
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.error = "1";
            ViewBag.login = false;
            HttpContext.Session.SetString(isloggedin, "0");
            HttpContext.Session.SetString(useremail,"none");
            return View();
        }

        [HttpPost]
        public IActionResult Login(Users model)
        {
            ViewBag.login = false;
            var valid = iuserreposetory.fetch(model.email);
            HttpContext.Session.SetString(isloggedin, "0");
            HttpContext.Session.SetString(useremail, "none");
            if (valid != null && model.password == valid.password)
            {
                ViewBag.login = true;
                HttpContext.Session.SetString(useremail,model.email);
                HttpContext.Session.SetString(isloggedin, "1");
                return Redirect("~/Home/index");
            }
            else
            {
                ViewBag.error = "0";
            }
            return View();
        }
    }
}
