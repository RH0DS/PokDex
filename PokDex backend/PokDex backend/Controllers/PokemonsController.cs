
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using PokDex_backend.POCO;

namespace PokDex_backend.Controllers;
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Pokemon>>> GetPokemonAsync(){

            using (var httpClient = new HttpClient())
            {  
                var apiUrl = "https://pokeapi.co/api/v2/pokemon";
                var response = await httpClient.GetAsync(apiUrl);
            
                    var content = await response.Content.ReadAsStringAsync();
                    var pokemonData = JsonSerializer.Deserialize<PokemonData>(content);
                    return Ok( pokemonData.results);
                
            
            }
        }
    
    }