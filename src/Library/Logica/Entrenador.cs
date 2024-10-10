using System.Text;
using Library.Interfaces;

namespace Library.Logica;

public class Entrenador
{
    private string nombre;
    private List<IPokemon> pokemons;
    private IPokemon pokemonActivo;
    private int contadorEspecial;

    private List<IMovimiento> ataquesDisponibles;
    //faltan getters y setters y constructor
    
    
    
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

    public List<IMovimiento> VerAtaquesDisponibles()
    {
        return this.ataquesDisponibles;
    }
}