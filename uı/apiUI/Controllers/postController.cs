using apiUI.Models.author;
using apiUI.Models.post;
using entityLayer.concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace apiUI.Controllers
{
    public class postController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public postController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7092/api/post");

            if (responseMessage.IsSuccessStatusCode)
            {
                var data = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<postModelView>>(data);
                return View(values);
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> addPost()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7092/api/author");

            if (responseMessage.IsSuccessStatusCode)
            {
                var data = await responseMessage.Content.ReadAsStringAsync();
                var authors = JsonConvert.DeserializeObject<List<authorModelView>>(data);

                // Yazarları SelectListItem listesine dönüştürme
                List<SelectListItem> authorValues = authors.Select(a => new SelectListItem
                {
                    Text = a.authorName,
                    Value = a.authorId.ToString()
                }).ToList();

                ViewBag.authorValue = authorValues;
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> addPost(addPostModelView model)
        {

            var client = _httpClientFactory.CreateClient();
            var data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7092/api/post", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> deletePost(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7092/api/post/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> updatePost(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7092/api/post/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var data = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<updatePostModelView>(data);
                return View(values);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> updatePost(updatePostModelView model)
        {
            if (!ModelState.IsValid)
            {
                var errorMessages = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                ViewBag.ModelStateErrors = errorMessages;
                return View(model);
            }

            var client = _httpClientFactory.CreateClient();
            var data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"https://localhost:7092/api/post/", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
        }
    }
}
