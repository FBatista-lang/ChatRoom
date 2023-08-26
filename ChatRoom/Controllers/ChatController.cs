using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoom.Controllers
{
    public class ChatController : Controller
    {
        public static Dictionary<int, string> Salas =
            new Dictionary<int, string>(){
            {1, "Sala Uno" },
            {2, "Sala Dos" },
            {3, "Sala Tres" }
        };

        public IActionResult ListaDeSalas()
        {
            return View();
        }

        public IActionResult Cuarto(int sala)
        {
            return View("Cuarto", sala);
        }
    }
}
