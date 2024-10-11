using Library.Interfaces;
using Library.Logica;

namespace Library.Facade;

public class Facade
{
    private List<IPokemon> pokemonsDisponibles = new List<IPokemon>();
    private Entrenador entrenador1;
    private Entrenador entrenador2;

    public Facade(Entrenador entrenador1, Entrenador entrenador2, List<IPokemon> pokemonsDisponibles)
    {
        this.entrenador1 = entrenador1;
        this.entrenador2 = entrenador2;
        this.pokemonsDisponibles = pokemonsDisponibles;
    }

    // Método para iniciar la batalla
    public void IniciarBatalla()
    {
        Batalla batalla = new Batalla(entrenador1, entrenador2, new Efectividad(), pokemonsDisponibles);
        batalla.IniciarBatalla();
    }

    // Método para añadir un Pokémon a un entrenador
    public void AñadirPokemonAEntrenador(IPokemon pokemon, string nombreEntrenador)
    {
        if (nombreEntrenador == entrenador1.Nombre)
        {
            entrenador1.Pokemons.Add(pokemon);
        }
        else if (nombreEntrenador == entrenador2.Nombre)
        {
            entrenador2.Pokemons.Add(pokemon);
        }
        else
        {
            throw new ArgumentException("Entrenador no encontrado.");
        }
    }

    // Método para obtener el estado de todos los Pokémon de un entrenador
    public string ObtenerStatusEntrenador(string nombreEntrenador)
    {
        if (nombreEntrenador == entrenador1.Nombre)
        {
            return entrenador1.ObtenerStatusPokemon();
        }
        else if (nombreEntrenador == entrenador2.Nombre)
        {
            return entrenador2.ObtenerStatusPokemon();
        }
        else
        {
            throw new ArgumentException("Entrenador no encontrado.");
        }
    }

    // Método para cambiar el Pokémon activo de un entrenador
    public void CambiarPokemonActivo(string nombreEntrenador, IPokemon nuevoPokemon)
    {
        if (nombreEntrenador == entrenador1.Nombre)
        {
            entrenador1.EstablecerPokemonActivo(nuevoPokemon);
        }
        else if (nombreEntrenador == entrenador2.Nombre)
        {
            entrenador2.EstablecerPokemonActivo(nuevoPokemon);
        }
        else
        {
            throw new ArgumentException("Entrenador no encontrado.");
        }
    }

    // Método para verificar si un entrenador tiene Pokémon restantes
    public bool VerificarPokemonsRestantes(string nombreEntrenador)
    {
        if (nombreEntrenador == entrenador1.Nombre)
        {
            return entrenador1.TienePokemonsRestantes();
        }
        else if (nombreEntrenador == entrenador2.Nombre)
        {
            return entrenador2.TienePokemonsRestantes();
        }
        else
        {
            throw new ArgumentException("Entrenador no encontrado.");
        }
    }
}