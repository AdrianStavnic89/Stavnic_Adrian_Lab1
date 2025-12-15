using Microsoft.AspNetCore.Mvc;

namespace Stavnic_Adrian_Lab1.Controllers
{
    public class ControllerNou : Controller
    {
        
        public string Index()
        {
            return "Bun venit pe aceasta pagina!";
        }

        public string Hello()
        {
            return "Salutare!";
        }

        public string CustomMessage(string name, int number)
        {
            return $"Bun venit pe pagina {name}, numarul alocat este {number}";
        }
    }
}
