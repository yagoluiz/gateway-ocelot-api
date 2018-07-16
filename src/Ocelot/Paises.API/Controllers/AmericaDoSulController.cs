using Microsoft.AspNetCore.Mvc;
using Paises.API.Models;
using System.Collections.Generic;

namespace Paises.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public class AmericaDoSulController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var paises = new List<PaisModel>()
            {
                new PaisModel
                {
                    Nome = "Argentina",
                    Sigla = "ARG"
                },
                new PaisModel
                {
                    Nome = "Bolívia",
                    Sigla = "BOL"
                },
                new PaisModel
                {
                    Nome = "Brasíl",
                    Sigla = "BRA"
                },
                new PaisModel
                {
                    Nome = "Chile",
                    Sigla = "CHL"
                },
                new PaisModel
                {
                    Nome = "Colômbia",
                    Sigla = "COL"
                },
                new PaisModel
                {
                    Nome = "Equador",
                    Sigla = "ECU"
                },
                new PaisModel
                {
                    Nome = "Guiana",
                    Sigla = "GUY"
                },
                new PaisModel
                {
                    Nome = "Paraguai",
                    Sigla = "PRY"
                },
                new PaisModel
                {
                    Nome = "Peru",
                    Sigla = "PER",
                },
                new PaisModel
                {
                    Nome = "Suriname",
                    Sigla = "SUR",
                },
                new PaisModel
                {
                    Nome = "Uruguai",
                    Sigla = "URY",
                },
                new PaisModel
                {
                    Nome = "Venezuela",
                    Sigla = "VEN",
                }
            };

            return Ok(paises);
        }
    }
}