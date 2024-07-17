using apiUI.Models.author;
using DtoLayer.Dtos.authorDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace apiUI.Controllers
{
    public class authorController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public authorController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var ResponseMessage = await client.GetAsync("https://localhost:7092/api/author");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                var datas = await ResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<authorModelView>>(datas);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult addAuthor()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> addAuthor(addAuthorModelView model)
        {
            if (!ModelState.IsValid)
            {
                // ModelState.IsValid false ise, doğrulama hataları var demektir.
                // Hataları toplu halde ModelState üzerinden alıp ekrana gönderebiliriz.
                var errorMessages = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();

                // Hata mesajlarını loglama veya kullanıcıya gösterme gibi işlemler yapılabilir.
                // Bu örnekte basitçe ModelStateErrors adında bir ViewBag ile view'e gönderiyoruz.
                ViewBag.ModelStateErrors = errorMessages;

                return View(model); // Hata ile birlikte addAuthor.cshtml sayfasına geri döner.
            }
            var client = _httpClientFactory.CreateClient();
            var data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var ResponseMessage = await client.PostAsync("https://localhost:7092/api/author", content);
            if (ResponseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> deleteAuthor(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7092/api/author/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> updateAuthor(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7092/api/author/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<updateAuthorModelView>(datas);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> updateAuthor(updateAuthorModelView model)
        {
            if (!ModelState.IsValid)
            {
                // ModelState.IsValid false ise, doğrulama hataları var demektir.
                // Hataları toplu halde ModelState üzerinden alıp ekrana gönderebiliriz.
                var errorMessages = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                // Hata mesajlarını loglama veya kullanıcıya gösterme gibi işlemler yapılabilir.
                // Bu örnekte basitçe ModelStateErrors adında bir ViewBag ile view'e gönderiyoruz.
                ViewBag.ModelStateErrors = errorMessages;
                return View(model); // Hata ile birlikte addAuthor.cshtml sayfasına geri döner.
            }
            var client = _httpClientFactory.CreateClient();
            var data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"https://localhost:7092/api/author/", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
