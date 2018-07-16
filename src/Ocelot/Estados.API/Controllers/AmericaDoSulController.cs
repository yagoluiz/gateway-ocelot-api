using Estados.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Estados.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public class AmericaDoSulController : Controller
    {
        [Route("brasil")]
        [HttpGet]
        public IActionResult Get()
        {
            var estados = new List<EstadoModel>()
            {
                new EstadoModel
                {
                    Nome = "Acre",
                    Sigla = "AC",
                },
                new EstadoModel
                {
                    Nome = "Alagoas",
                    Sigla = "AL",
                },
                new EstadoModel
                {
                    Nome = "Amapá",
                    Sigla = "AP",
                },
                new EstadoModel
                {
                    Nome = "Amazonas",
                    Sigla = "AM",
                },
                new EstadoModel
                {
                    Nome = "Bahia",
                    Sigla = "BA",
                },
                new EstadoModel
                {
                    Nome = "Ceará",
                    Sigla = "CE",
                },
                new EstadoModel
                {
                    Nome = "Distrito Federal",
                    Sigla = "DF",
                },
                new EstadoModel
                {
                    Nome = "Espírito Santo",
                    Sigla = "ES",
                },
                new EstadoModel
                {
                    Nome = "Goiás",
                    Sigla = "GO",
                },
                new EstadoModel
                {
                    Nome = "Maranhão",
                    Sigla = "MA",
                },
                new EstadoModel
                {
                    Nome = "Mato Grosso",
                    Sigla = "MT",
                },
                new EstadoModel
                {
                    Nome = "Mato Grosso do Sul",
                    Sigla = "MS",
                },
                new EstadoModel
                {
                    Nome = "Minas Gerais",
                    Sigla = "MG",
                },
                new EstadoModel
                {
                    Nome = "Pará",
                    Sigla = "PA",
                },
                new EstadoModel
                {
                    Nome = "Paraíba",
                    Sigla = "PB",
                },
                new EstadoModel
                {
                    Nome = "Paraná",
                    Sigla = "PR",
                },
                new EstadoModel
                {
                    Nome = "Pernambuco",
                    Sigla = "PE",
                },
                new EstadoModel
                {
                    Nome = "Piauí",
                    Sigla = "PI",
                },
                new EstadoModel
                {
                    Nome = "Rio de Janeiro",
                    Sigla = "RJ",
                },
                new EstadoModel
                {
                    Nome = "Rio Grande do Norte",
                    Sigla = "RN",
                },
                new EstadoModel
                {
                    Nome = "Rio Grande do Sul",
                    Sigla = "RS",
                },
                new EstadoModel
                {
                    Nome = "Rondônia",
                    Sigla = "RO",
                },
                new EstadoModel
                {
                    Nome = "Roraima",
                    Sigla = "RR",
                },
                new EstadoModel
                {
                    Nome = "Santa Catarina",
                    Sigla = "SC",
                },
                new EstadoModel
                {
                    Nome = "São Paulo",
                    Sigla = "SP",
                },
                new EstadoModel
                {
                    Nome = "Sergipe",
                    Sigla = "SE",
                },
                new EstadoModel
                {
                    Nome = "Tocantins",
                    Sigla = "TO",
                }
            };

            return Ok(estados);
        }
    }
}