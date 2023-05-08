using Microsoft.AspNetCore.Mvc;
using proyectodefinitivo.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace proyectodefinitivo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        public IActionResult Privacy()

        {
            Floristeria2Context _context = new Floristeria2Context();

            var Listarclientes = _context.Clientes.ToList();
            //ViewBang.Usuario = ListarUsuarios;
            return View(Listarclientes);

        }
        [HttpGet]
       


        [HttpGet]
        public IActionResult Index()
        {
            Floristeria2Context _context = new Floristeria2Context();

            var ListarProd = _context.Productos.ToList();
            //ViewBang.Usuario = ListarUsuarios;
            return View(ListarProd);

        }


        [HttpGet]
        public IActionResult Ventas()
        {
            Floristeria2Context _context = new Floristeria2Context();

            var Listarventa = _context.Venta.ToList();
            //ViewBang.Usuario = ListarUsuarios;
            return View(Listarventa);
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}