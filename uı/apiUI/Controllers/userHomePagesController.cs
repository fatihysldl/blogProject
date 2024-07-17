using apiUI.Models.post;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace apiUI.Controllers
{
    public class userHomePagesController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public userHomePagesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var ResponseMessage = await client.GetAsync("https://localhost:7092/api/post");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                var datas = await ResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<postModelView>>(datas);
                return View(values);
            }
            return View();
        }
    }
}
