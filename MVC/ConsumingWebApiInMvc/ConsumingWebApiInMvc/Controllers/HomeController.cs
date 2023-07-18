using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using ConsumingWebApiInMvc.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConsumingWebApiInMvc.Controllers
{
    public class HomeController : Controller
    {
        // Hosted web API REST Service base url
        string Baseurl = "http://localhost:50477/api/employee";

        public async Task<ActionResult> Index()
        {
            List<Employee> EmpInfo = new List<Employee>();

            using (var client = new HttpClient())
            {
                // Passing service base url
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                // Define request data format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Sending request to find web api REST service resource GetAllEmployees using HttpClient
                HttpResponseMessage Res = await client.GetAsync("api/Employee");

                // Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    // Storing the response details received from web api
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    // Deserializing the response received from web api and storing into the Employee list
                    EmpInfo = JsonConvert.DeserializeObject<List<Employee>>(EmpResponse);
                }

                // Returning the employee list to view
                return View(EmpInfo);
            }
        }
    }

}