using Cliente.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cliente.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AppCont _appCont;

        public ClienteController(AppCont appCont)
        {
            _appCont = appCont;
        }

        public IActionResult Index()
        {
            var allClientes = _appCont.Clientes.ToList();
            return View(allClientes);
        }
    }
}
