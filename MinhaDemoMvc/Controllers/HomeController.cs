using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaDemoMvc.Models;

namespace MinhaDemoMvc.Controllers
{
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("pagina-inicial")]
        [Route("/{id:int}/{categoria:guid}")]
        [Route("pagina-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index(int id, Guid categoria)
        {
            var filme = new Filme
            {
                Titulo = "Oi",
                DataLancamento = DateTime.Now,
                Genero = null,
                Avaliacao = 10,
                Valor = 20000
            };

            //return RedirectToAction("Privacy", filme);

            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy(Filme filme)
        {
            // return Json("{'nome':'Gabriel'}");

            //var fileBytes = System.IO.File.ReadAllBytes(@"c:\arquivo.txt");
            //var fileName = "ola.txt";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);

            if (ModelState.IsValid)
            {

            }
            else
            {
                foreach (var item in ModelState.Values.SelectMany(m => m.Errors))
                {
                    Console.WriteLine(item.ErrorMessage);
                }
            }            

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
