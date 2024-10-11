using System.Text;
using Library.Interfaces;

namespace Library.Logica;

public class Entrenador
{
    private string nombre;
    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }
    
    private List<IPokemon> pokemons;
    public List<IPokemon> Pokemons
    {
        get => pokemons;
        set => pokemons = value;
    }
    
    private IPokemon pokemonActivo;
    public IPokemon PokemonActivo
    {
        get => pokemonActivo;
        set => pokemonActivo = value;
    }
    
    private int contadorEspecial; 
    public int ContadorEspecial
    {
        get => contadorEspecial;
        set => contadorEspecial = value;
    }

    public Entrenador(string nombre)
    {
        Nombre = nombre;
        ContadorEspecial = 0;
        Pokemons = new List<IPokemon>();
        PokemonActivo = null;
    }
    
    public string ObtenerStatusPokemon()
    {
        StringBuilder statusBuilder = new StringBuilder();       
        foreach (var pokemon in pokemons)
        {
            statusBuilder.AppendLine($"{pokemon.Nombre}: {pokemon.SaludActual}/{pokemon.SaludTotal} HP");
        }
        
        return statusBuilder.ToString();
    }
    
    public bool TienePokemonsRestantes()
    {
        foreach (var poke in pokemons)
        {
            if (!poke.Debil)
            {
                return true;
            }
        }
        return false;
    }
    
    public bool PuedeUsarAtaqueEspecial()
    {
        if (contadorEspecial == 0)
        {
            return true;
        }
    
        return false; 
    }

    public Dictionary<IPokemon, List<IMovimiento>> VerAtaquesDisponibles()
    {
        Dictionary<IPokemon, List<IMovimiento>> ataquesDisponibles = new Dictionary<IPokemon, List<IMovimiento>>();
        foreach (IPokemon pokemon in Pokemons)
        {
            ataquesDisponibles.Add(pokemon, pokemon.Movimientos);
        }

        return ataquesDisponibles;
    }
}