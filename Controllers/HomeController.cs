using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ingos.Models;

namespace ingos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Users()
        {
            User _model = new User() { name = "Гайк", lastName = "Инанц", age = 26, Posts = {
                new Post { id = 1, content = "Очень интересный пост, а главное, содержательный!!", likeCnt = 2, title = "Очень интересный пост 1!" },
                new Post { id = 2, content = "Очень интересный пост, а главное, содержательный!!", likeCnt = 4, title = "Очень интересный пост 2!" },
                new Post { id = 3, content = "Очень интересный пост, а главное, содержательный!!", likeCnt = 5, title = "Очень интересный пост 3!" },
                new Post { id = 4, content = "Очень интересный пост, а главное, содержательный!!", likeCnt = 1, title = "Очень интересный пост 4!" },
                new Post { id = 5, content = "Очень интересный пост, а главное, содержательный!!", likeCnt = 15, title = "Очень интересный пост 5!" }
            } };

            return View(_model);
        }

    }
}
