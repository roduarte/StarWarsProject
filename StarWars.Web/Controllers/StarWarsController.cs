using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using StarWars.Models;
using StarWars.Repositorio;

namespace StarWars.Api.Controllers
{
    [RoutePrefix("api/v1/starWars/")]
    class StarWarsController
    {
        /// <summary>
        /// Busca pessoa pelo nome
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.BadRequest, Description = "Parâmetro de entrada inválido.")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Description = "Erro no processamento do servidor.")]
        [SwaggerResponse(HttpStatusCode.NotFound, Description = "Valor do parâmetro de entrada não corresponde a um objeto existente.")]
        [SwaggerResponse(HttpStatusCode.OK, Description = "Agências retornadas com sucesso.")]
        [Route("people")]
        public IHttpActionResult BuscarPessoa(string name)
        {
            var repositorio = new StarWarsRepositorio();
            People resposta = repositorio.BuscarPessoa(name);
            return Ok(resposta);
        }
    }
}
