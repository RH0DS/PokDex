namespace PokDex_backend.POCO;

public class      PokemonData{
    public int count { get; set; }
    public string next { get; set; }
    public string previous { get; set; }
    public List<Pokemon> results { get; set; }

} 