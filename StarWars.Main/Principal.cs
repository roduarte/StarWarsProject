using System;
using StarWars.Api.Controllers;
using StarWars.Models;
using StarWars.Repositorio;

namespace StarWars.Main
{
    class Principal
    {
        static void Main(string[] args)
        {
            var api = new StarWarsController();
            Console.WriteLine(api.BuscarPessoa("luke"));
        }
    }
}
