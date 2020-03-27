using System;
using System.Collections.Generic;
using System.Net.Http;
using StarWars.Models;
using Newtonsoft.Json;

namespace StarWars.Repositorio
{
    public class StarWarsRepositorio
    {
        static readonly HttpClient client = new HttpClient();
        public People BuscarPessoa(string name)
        {
            // gets the response from the http request 
            HttpResponseMessage response = client.GetAsync("https://swapi.co/api/people/?search=" + name).Result;
            string str = JsonConvert.SerializeObject(response);
            return JsonConvert.DeserializeObject<People>(str);
        }
    }
}
