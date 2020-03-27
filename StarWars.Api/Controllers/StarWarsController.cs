using System;
using System.Collections.Generic;
using Swashbuckle.Swagger.Annotations;
using StarWars.Models;
using StarWars.Repositorio;
using System.Net;
using System.Web.Http;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RoutePrefixAttribute = System.Web.Http.RoutePrefixAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace StarWars.Api.Controllers
{
    [RoutePrefix("api/v1/starWars/")]
    class StarWarsController : ApiController
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
