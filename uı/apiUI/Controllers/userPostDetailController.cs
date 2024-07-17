using apiUI.Models.author;
using apiUI.Models.post;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace apiUI.Controllers
{
    public class userPostDetailController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public userPostDetailController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task <IActionResult> Index(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7092/api/post/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var data = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<postModelView>(data);
                return View(new List<postModelView> { value });
            }
            return View();
        }
    }
}
