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
        private List<IItems> items = new List<IItems>();

        // Getters y Setters públicos
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public IReadOnlyList<IPokemon> Pokemons
        {
            get => pokemons.AsReadOnly();
            set => pokemons = value.ToList();
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

        public List<IItems> Items => items;

        // Constructor que inicializa el nombre del entrenador y otras propiedades.
        public Entrenador(string nombre)
        {
            this.nombre = nombre;
            InicializarItems(); // Asignar ítems iniciales
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

        // Método para agregar un Pokémon a la lista
        public void AgregarPokemon(IPokemon pokemon)
        {
            if (pokemon != null && !pokemons.Contains(pokemon))
            {
                pokemons.Add(pokemon);
            }
        }

        // Método para quitar un Pokémon de la lista
        public void RemoverPokemon(IPokemon pokemon)
        {
            if (pokemon != null && pokemons.Contains(pokemon))
            {
                pokemons.Remove(pokemon);
            }
        }

        public void ClearPokemons()
        {
            pokemons.Clear();
        }

        private void InicializarItems()
        {
            Items.Add(new SuperPocion() { Nombre = "SuperPocion" });
            Items.Add(new SuperPocion() { Nombre = "SuperPocion" });
            Items.Add(new SuperPocion() { Nombre = "SuperPocion" });
            Items.Add(new SuperPocion() { Nombre = "SuperPocion" });
            Items.Add(new Revivir() { Nombre = "Revivir" });
            Items.Add(new CuraTotal() { Nombre = "CuraTotal" });
            Items.Add(new CuraTotal() { Nombre = "CuraTotal" });
        }

        public void RemoverItem(IItems item)
        {
            Items.Remove(item);
        }
    }
}