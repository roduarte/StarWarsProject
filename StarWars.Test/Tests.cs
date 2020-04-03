using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StarWars.Api.Controllers;
using StarWars.Models;
using StarWars.Repositorio;

namespace StarWars.Test
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var repositorio = new StarWarsRepositorio();
            Console.WriteLine(repositorio.BuscarPessoa("luke"));
        }
    }
}
