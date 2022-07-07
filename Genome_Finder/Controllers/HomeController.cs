using Genome_Finder.Models;
using Genome_Finder.Views;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Genome_Finder.DataLibrary;
using static Genome_Finder.DataLibrary.BusinessLogic.GenomeProcessor;
using System.Data;
using System.Data.Entity;
using System.Collections.Generic;

namespace Genome_Finder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Compare()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CompareRes(Base_Nitrogen model)
        {


            if (ModelState.IsValid)
            {
                var data = LoadBases();

                List<Base_Nitrogen> bases = new List<Base_Nitrogen>();

                foreach (var row in data)
                {
                    bases.Add(new Base_Nitrogen
                    {
                        Gene = row.Gene,
                        Nome = row.Nome,
                        NCBICod = row.NBCICod,
                        searchnum = row.searchNum
                    });
                }

                if (data.Any(x => x.Nome == model.Nome))
                {
                    UpdateGenome(model.Nome);
                } else
                {
                    CreateGenome(model.Gene, model.Nome, model.searchnum, model.NCBICod);
                }
            }
            return NoContent();


        }

        public IActionResult Comunity()
        {
            var data = LoadBases();
            List<int> searchCount = new List<int>();
            List<string> nomesLista = new List<string>();
            var nomes = data.Select(x => x.Nome);
            var searchs = data.Select(x => x.searchNum).Distinct();
            List<Base_Nitrogen> bases = new List<Base_Nitrogen>();

            foreach (var row in data)
            {
                bases.Add(new Base_Nitrogen
                {
                    Gene = row.Gene,
                    Nome = row.Nome,
                    NCBICod = row.NBCICod,
                    searchnum = row.searchNum
                });
            }

                nomesLista.AddRange(data.Select(x => x.Nome));

                searchCount.AddRange(data.Select(x => x.searchNum));


            var chartDataModel = new Models.ChartDataModel()
            {
                ChartData = searchCount,
                ChartLabel = nomesLista,
                ChartName = "Numero de Pesquisas"

            };

            return View(chartDataModel);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}