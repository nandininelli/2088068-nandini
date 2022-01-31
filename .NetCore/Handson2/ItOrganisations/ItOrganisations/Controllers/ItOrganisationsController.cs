using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ItOrganisations.Controllers
{
    public class ItOrganisationsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<string> org = new List<string>();
            org.Add("Microsoft www.microsoft.com");
            org.Add("CTS www.cognizant.com");
            org.Add("Google");
            org.Add("Amazon");
            org.Add("TCS");
            return View(org);
        }
    }
}
