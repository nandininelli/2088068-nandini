using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieApp_UsingMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MovieApp_UsingMvc.Controllers
{
    public class MovieController : Controller
    {
        private readonly DataDbContext context;

        //public object DefaultAuthenticationTypes { get; private set; }

        public MovieController(DataDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("Movie/Register")]
        public IActionResult Register(Registration account)
        {

            if (ModelState.IsValid)
            {
                context.signUps.Add(account);
                context.SaveChanges();
                ModelState.Clear();
                ViewBag.Message = account.FirstName +account.LastName+ " successfully registered ";
                //return RedirectToAction("Index","SignUp");

            }
            return View();


        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]


        public IActionResult Login(Registration account, string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;

            var usr = context.signUps.Where(u => u.LastName == account.LastName && u.Password == account.Password).FirstOrDefault();

            if (!string.IsNullOrEmpty(usr.LastName) && string.IsNullOrEmpty(usr.Password))
            {

                return RedirectToAction("Login");
            }
            ClaimsIdentity identity = null;
            bool isAuthenticate = false;
            if (usr.LastName == account.LastName && usr.Password == account.Password)
            {
                identity = new ClaimsIdentity(new[]
                {
                        new Claim(ClaimTypes.Name,usr.LastName),
                        new Claim(ClaimTypes.Role,usr.Roles)
                    }, CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticate = true;
            }

            if (isAuthenticate)
            {
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Index", "Movie");
            }


            return View();
        }
        public IActionResult List()
        {
            var queryMovies = from p in context.movieLists
                                select p;
            var movies = queryMovies.ToList();
            return View(movies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MovieList movie)
        {
            if (!ModelState.IsValid)
                return View(movie);

            context.movieLists.Add(movie);
            context.SaveChanges();

            return RedirectToAction("List");
        }

        public IActionResult Details(int id)
        {
            var movie = context.movieLists.Find(id);

            if (movie == null) return NotFound();

            return View(movie);
        }

        public IActionResult Edit(int id)
        {
            var movie = context.movieLists.Find(id);

            if (movie == null) return NotFound();

            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieList movie)
        {
            if (!ModelState.IsValid)
                return View(movie);

            context.Attach(movie);
            context.Entry(movie).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("List");
        }


        public IActionResult Delete(int id)
        {
            var movie = context.movieLists.Find(id);

            if (movie == null) return NotFound();

            return View(movie);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = context.movieLists.Find(id);
            context.movieLists.Remove(product);
            context.SaveChanges();
            return RedirectToAction("List");
        }
        [Authorize(Roles ="Admin")]
        public IActionResult AdminPage()
        {
            var queryMovies = from p in context.movieLists
                              select p;
            var movies = queryMovies.ToList();
            return View(movies);
        }
        public IActionResult AddFav(MovieList movie)
        {
            if (!ModelState.IsValid)
                return View(movie);

            context.movieLists.Add(movie);
            context.SaveChanges();

            return RedirectToAction("");

        }


    }
}
