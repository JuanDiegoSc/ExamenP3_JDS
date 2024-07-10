using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;
using ExamenP3_JDS.Models;

namespace ExamenP3_JDS.Servicios
{
    public class PersonajeServiceJDS : IPersonajesJDS
    {
        public string UrlApiJDS = "https://www.swapi.tech/api/people";

        public async Task<List<PersonajesJDS>> ObtenerPersonaje()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(UrlApiJDS);
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode results = nodos["results"];
            var apiData = JsonSerializer.Deserialize<List<PersonajesJDS>>(results.ToString());
            return apiData;
        }
    }
}
