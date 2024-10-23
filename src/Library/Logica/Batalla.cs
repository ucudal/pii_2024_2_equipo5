using Library.Enums;
using Library.Interfaces;

namespace Library.Logica;

public class Batalla
{
    private Entrenador entrenador1;
    private Entrenador entrenador2;
    private Efectividad efectividad;
    private Entrenador entrenadorActual;
    private List<IPokemon> pokemonsDisponibles;
    private int contadorTurno;

    public Batalla(Entrenador entrenador1, Entrenador entrenador2, Efectividad efectividad,
        List<IPokemon> pokemonsDisponibles)
    {
        this.entrenador1 = entrenador1;
        this.entrenador2 = entrenador2;
        this.efectividad = efectividad;
        this.pokemonsDisponibles = pokemonsDisponibles ?? new List<IPokemon>();
        this.contadorTurno = 0;
        this.entrenadorActual = entrenador1;
    }

    public Entrenador Entrenador1
    {
        get => entrenador1;
        set => entrenador1 = value;
    }

    public Entrenador Entrenador2
    {
        get => entrenador2;
        set => entrenador2 = value;
    }

    public Efectividad Efectividad
    {
        get => efectividad;
        set => efectividad = value;
    }

    public Entrenador EntrenadorActual
    {
        get => entrenadorActual;
        private set => entrenadorActual = value;
    }

    public List<IPokemon> PokemonsDisponibles
    {
        get => pokemonsDisponibles;
        set => pokemonsDisponibles = value;
    }

    public int ContadorTurno
    {
        get => contadorTurno;
        private set => contadorTurno = value;
    }

    public void IniciarBatalla()
    {
        const int cantidadPokemones = 1; // Número de Pokémon a seleccionar

        // Selecciona Pokémon para ambos entrenadores
        SeleccionarPokemones(Entrenador1, cantidadPokemones);
        SeleccionarPokemones(Entrenador2, cantidadPokemones);

        InicializarPokemones(); // Inicializa los Pokémon activos

        // Bucle principal de la batalla
        while (!Fin())
        {
            Atacar(EntrenadorActual, entrenadorActual.PokemonActivo.Movimientos[0]); // El entrenador actual ataca
            SiguienteTurno(); // Cambia al siguiente turno
        }
    }

    public void Atacar(Entrenador entrenadorAtacante, IMovimiento movimiento)
    {
        // Obtiene el entrenador defensor basado en quién está atacando
        Entrenador entrenadorDefensor = ObtenerEntrenadorDefensor(entrenadorAtacante);
        // Busca el movimiento que el atacante desea usar
        IMovimiento ataque = ObtenerMovimiento(entrenadorAtacante, movimiento);
        ActualizarContadoresEntrenador(entrenadorAtacante, ataque); // Actualiza los contadores del entrenador
        if (entrenadorAtacante.PokemonActivo.Estado == EEstado.PARALIZADO)
        {
            Random rand = new Random();
            bool puedeAtacar = rand.NextDouble() >= 0.25; // 25% de probabilidad de no poder atacar

            if (!puedeAtacar)
            {
                return; // El ataque falla y el turno termina 
            }
        }
        else if (entrenadorAtacante.PokemonActivo.Estado == EEstado.DORMIDO)
        {
            if (entrenadorAtacante.PokemonActivo.TurnosDormido > 0)
            {
                //caso está dormido y no puede atacar
                //entrenadorAtacante.PokemonActivo.TurnosDormido--; NO LO REDUZCO ACA PORQUE SE REDUCE CUANDO ACTUALIZO EN aplicar efectosestados
                return; // El ataque falla y el turno termina
            }
        }

        if (!(ataque.esPreciso(entrenadorDefensor.PokemonActivo)))
        {
           return;
        }
        
        AplicarDanio(ataque, entrenadorDefensor); // Aplica el daño al defensor
        if (ataque is MovimientoEspecial)
        {
            AplicarEfectosEstados(entrenadorDefensor);
        } 
        
    }

    public void SeleccionarPokemones(Entrenador entrenador, int cantidadPokemones)
    {
        //Console.WriteLine($"Selecciona {cantidadPokemones} pokemones de la siguiente lista, {entrenador.Nombre}:");
        // Mostrar lista de Pokémon disponibles

        // Selecciona Pokémon de la lista disponible
        for (int i = 0; i < cantidadPokemones; i++)
        {
            IPokemon
                nuevoPokemon =
                    PokemonsDisponibles
                        .First(); // Toma el primer Pokémon disponible por ahora (luego tiene que tomar el que elija el usuario)
            entrenador.AgregarPokemon(nuevoPokemon); // Agrega el Pokémon al entrenador
            pokemonsDisponibles.Remove(nuevoPokemon); // Lo elimina de la lista de disponibles
        }
    }

    public Entrenador ObtenerEntrenadorActual()
    {
        // Devuelve el entrenador que tiene el turno actual
        return (ContadorTurno % 2 == 0) ? Entrenador1 : Entrenador2;
    }

    //creo que este metodo tiene que estar en el entrenador porque no toiene niguna relacion con la batalla
    public void CambiarPokemon(Entrenador entrenador, int indexPokemon)
    {
        if (entrenador.Pokemons.Count == 0) return; // Si no hay Pokémon disponibles, salir

        Console.WriteLine($"{entrenador.Nombre}, selecciona otro pokemon:");
        // Mostrar lista de Pokémon disponibles

        IPokemon nuevoPokemon = entrenador.Pokemons[indexPokemon]; // Toma el pokemon correspondiente al index
        entrenador.PokemonActivo = nuevoPokemon; // Establece el nuevo Pokémon como activo
        PokemonsDisponibles.Remove(nuevoPokemon); // Elimina el Pokémon de la lista de disponibles
    }

    public void SiguienteTurno()
    {
        ContadorTurno++; // Incrementa el contador de turnos
        EntrenadorActual = ObtenerEntrenadorActual(); // Actualiza el entrenador actual
    }
    private void AplicarEfectosEstados(Entrenador entrenador)
    {
        IPokemon pokemonActivo = entrenador.PokemonActivo;

        if (pokemonActivo.Estado == EEstado.ENVENENADO)
        {
            int danioVeneno = (int)(pokemonActivo.SaludTotal * 0.05);
            pokemonActivo.RecibirDanio(danioVeneno);
            
        }
        else if (pokemonActivo.Estado == EEstado.QUEMADO)
        {
            int danioQuemadura = (int)(pokemonActivo.SaludTotal * 0.10);
            pokemonActivo.RecibirDanio(danioQuemadura);
        }
        else if (pokemonActivo.Estado == EEstado.DORMIDO)
        {
            if (pokemonActivo.TurnosDormido > 0)
            {
                pokemonActivo.TurnosDormido--;
                //El pokemon sigue dormido pero se resta 1 a la cantidad de turnos dormido restantes
            }
            else
            {
                pokemonActivo.Estado = EEstado.NORMAL;
                //"Despierta" al pokemon, entonces pasa a estar normal
            }
        }
    }

    public bool Fin()
    {
        // Comprueba si alguno de los entrenadores ha quedado sin Pokémon
        return Entrenador1.Pokemons.Count == 0 || Entrenador2.Pokemons.Count == 0;
    }

    public void UsarItem(IItems item, Entrenador entrenador)
    {
        item.Usar(entrenador.PokemonActivo);
        entrenadorActual.RemoverItem(item);
        SiguienteTurno();
    }

    // Métodos privados
    private void InicializarPokemones()
    {
        // Establece el primer Pokémon de cada entrenador como activo
        Entrenador1.PokemonActivo = Entrenador1.Pokemons[0];
        Entrenador2.PokemonActivo = Entrenador2.Pokemons[2];
    }

    private Entrenador ObtenerEntrenadorDefensor(Entrenador entrenadorAtacante)
    {
        // Devuelve el entrenador que está defendiendo (el que no está atacando)
        return (entrenadorAtacante == Entrenador1) ? Entrenador2 : Entrenador1;
    }

    private IMovimiento ObtenerMovimiento(Entrenador entrenadorAtacante, IMovimiento movimiento)
    {
        // Busca el movimiento comparando por el nombre del movimiento
        return entrenadorAtacante.PokemonActivo.Movimientos
                   .Find(f => f.Nombre == movimiento.Nombre)
               ?? throw new InvalidOperationException("Movimiento no encontrado.");
    }

    private void AplicarDanio(IMovimiento ataque, Entrenador entrenadorDefensor)
    {
        if (ataque == null)
        {
            throw new ArgumentNullException(nameof(ataque), "El ataque no puede ser null.");
        }

        if (entrenadorDefensor == null)
        {
            throw new ArgumentNullException(nameof(entrenadorDefensor), "El entrenador defensor no puede ser null.");
        }

        if (entrenadorDefensor.PokemonActivo == null)
        {
            throw new InvalidOperationException("El entrenador defensor no tiene un Pokémon activo.");
        }

        // Calcula el daño considerando la efectividad del movimiento
        int danio = Convert.ToInt32(ataque.Daño *
                                    Efectividad.ObtenerEfectividad(ataque.Tipo,
                                        entrenadorDefensor.PokemonActivo.Tipo[0]));

        // Si es critico, aumenta un 20% el daño causado (Hay un 10% de probabilidad)
        if (esCritico())
        { danio = (int)(danio * 1.2); }

        entrenadorDefensor.PokemonActivo.RecibirDanio(danio); // Aplica el daño al Pokémon defensor
        InformarDanio(ataque, entrenadorDefensor, danio); // Informa sobre el daño
        VerificarDebilidad(entrenadorDefensor,
            ObtenerEntrenadorDefensor(entrenadorDefensor)); // Verifica si el Pokémon defensor se ha debilitado
    }


    private void InformarDanio(IMovimiento ataque, Entrenador entrenadorDefensor, int danio)
    {
        // Muestra en la consola información sobre el ataque realizado y el daño recibido
        Console.WriteLine(
            $"{entrenadorDefensor.Nombre} ha usado {ataque.Nombre}. ¡{entrenadorDefensor.PokemonActivo.Nombre} ha recibido {danio} puntos de daño!");
    }

    private void VerificarDebilidad(Entrenador entrenadorDefensor, Entrenador entrenadorAtacante)
    {
        // Verifica si el Pokémon defensor se ha debilitado
        if (entrenadorDefensor.PokemonActivo.Debil)
        {
            Console.WriteLine($"{entrenadorDefensor.PokemonActivo.Nombre} se ha debilitado.");
            entrenadorDefensor.RemoverPokemon(entrenadorDefensor
                .PokemonActivo); // Elimina el Pokémon debilitado de la lista

            // Si el defensor no tiene más Pokémon, el atacante gana la batalla
            if (entrenadorDefensor.Pokemons.Count == 0)
            {
                Console.WriteLine($"{entrenadorAtacante.Nombre} ha ganado la batalla.");
            }
            else
            {
                CambiarPokemon(entrenadorDefensor, 0); // Cambia al siguiente Pokémon del defensor
            }
        }
    }

    private void ActualizarContadoresEntrenador(Entrenador entrenadorAtacante, IMovimiento ataque)
    {
        // Actualiza el contador del ataque especial basado en el movimiento utilizado
        if (ataque.Especial && entrenadorAtacante.PuedeUsarAtaqueEspecial())
        {
            entrenadorAtacante.ContadorEspecial = 2; // Establece un contador de 2 turnos para el ataque especial
        }
        else if (!entrenadorAtacante.PuedeUsarAtaqueEspecial())
        {
            entrenadorAtacante.ContadorEspecial -= 1; // Reduce el contador si el ataque especial no está disponible
        }
    }
    
    private bool esCritico()
    {
        Random rand = new Random(); 
        bool critico = rand.Next(1, 101) <= 10; // Genera un número aleatorio entre 1 y 100 
        // si el número generado está dentro del rango de 1 a 10
        // retorna que el ataque es crítico. (Hay un 10% de probabilidades de que sea crítico)
        return critico;
    }
}