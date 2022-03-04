using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using MVC_Client.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MVC_Client.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HttpClient http;
        public EmployeeController(IHttpClientFactory factory)
        {
            http = factory.CreateClient("myapi");
            http.DefaultRequestHeaders.Accept.Clear();
            http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<IActionResult> Index()
        {
            var response = await http.GetAsync("api/Employee");
            //if(response.StatusCode == System.Net.HttpStatusCode.OK)
            //{
            //    return Json(response.Content);
            //}

            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            List<Employee> employee = JsonConvert.DeserializeObject<List<Employee>>(json);
            return View(employee);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            if(!ModelState.IsValid) return NotFound();
            var json = JsonConvert.SerializeObject(employee);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await http.PostAsync("api/employee", content);

            response.EnsureSuccessStatusCode();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int id)
        {
            var response = await http.GetAsync($"api/employee/{id}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            Employee e = JsonConvert.DeserializeObject<Employee>(json);
            return View(e);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var response = await http.GetAsync($"api/employee/{id}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            Employee e = JsonConvert.DeserializeObject<Employee>(json);
            return View(e);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,  Employee model)
        {
            if(!ModelState.IsValid) return View(model);

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await http.PutAsync("api/employee", content);
            response.EnsureSuccessStatusCode();
            return RedirectToAction("Index");
            
        }
        public async Task<IActionResult> Delete(int id)
        {
            var response = await http.GetAsync($"api/employee/{id}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            Employee e = JsonConvert.DeserializeObject<Employee>(json);
            return View(e);
        }
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var response = await http.DeleteAsync($"api/employee/{id}");
            response.EnsureSuccessStatusCode();
            return RedirectToAction("Index");
        }

    }
}
