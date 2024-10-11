using System.Text;
using Library.Interfaces;

namespace Library.Logica
{
    public class Entrenador
    {
        // Atributos privados
        private string nombre;
        private List<IPokemon> pokemons = new List<IPokemon>();
        private IPokemon pokemonActivo;
        private int contadorEspecial = 0;

        // Getters y Setters públicos
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public List<IPokemon> Pokemons
        {
            get => pokemons;
            set => pokemons = value;
        }

        public IPokemon PokemonActivo
        {
            get => pokemonActivo;
            set => pokemonActivo = value;
        }

        public int ContadorEspecial
        {
            get => contadorEspecial;
            set => contadorEspecial = value;
        }

        // Constructor que inicializa el nombre del entrenador y otras propiedades.
        public Entrenador(string nombre)
        {
            this.nombre = nombre;
        }

        // Método para obtener el estado de todos los Pokémon del entrenador.
        public string ObtenerStatusPokemon()
        {
            StringBuilder statusBuilder = new StringBuilder();
            foreach (var pokemon in pokemons)
            {
                statusBuilder.AppendLine($"{pokemon.Nombre}: {pokemon.SaludActual}/{pokemon.SaludTotal} HP");
            }

            return statusBuilder.ToString();
        }

        // Verifica si el entrenador tiene algún Pokémon no debilitado.
        public bool TienePokemonsRestantes()
        {
            foreach (var pokemon in pokemons)
            {
                if (!pokemon.Debil)
                {
                    return true;
                }
            }

            return false;
        }

        // Verifica si el ataque especial está disponible.
        public bool PuedeUsarAtaqueEspecial()
        {
            return contadorEspecial == 0;
        }

        // Método para disminuir el contador especial.
        public void ActualizarContadorEspecial()
        {
            if (contadorEspecial > 0)
            {
                contadorEspecial--;
            }
        }

        // Cambia el Pokémon activo, si está en la lista de Pokémons.
        public void EstablecerPokemonActivo(IPokemon nuevoPokemon)
        {
            if (pokemons.Contains(nuevoPokemon))
            {
                pokemonActivo = nuevoPokemon;
            }
        }

        // Devuelve un diccionario donde cada Pokémon está asociado con su lista de movimientos.
        public Dictionary<IPokemon, List<IMovimiento>> VerAtaquesDisponibles()
        {
            Dictionary<IPokemon, List<IMovimiento>> ataquesDisponibles = new Dictionary<IPokemon, List<IMovimiento>>();
            foreach (IPokemon pokemon in pokemons)
            {
                ataquesDisponibles.Add(pokemon, pokemon.Movimientos);
            }

            return ataquesDisponibles;
        }
    }
}