using Library.Interfaces;
using Library.Logica;
using Library.Pokemones;

namespace LibraryTests;

public class EntrenadorTest
{
    private Entrenador entrenador1;
    private Entrenador entrenador2;
    private Efectividad efectividad;
    private List<IPokemon> pokemonsDisponibles;
    private Batalla bat;
    private Pikachu pikachu;
    private Charizard charizard;

    [SetUp]
    public void Setup()
    {
        entrenador1 = new Entrenador("Pepe");
        entrenador2 = new Entrenador("Euge");
        efectividad = new Efectividad();
        pikachu = new Pikachu();
        charizard = new Charizard();
        pokemonsDisponibles = new List<IPokemon> { pikachu, charizard };
        bat = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);
    }

    [Test]
    public void TienePokemonsRestantesTest()
    {
        bat.SeleccionarPokemones(entrenador1, 2);
        //Test cuando si tiene pokemons restantes
        Assert.That(true, Is.EqualTo(entrenador1.TienePokemonsRestantes()));
    }

    [Test]
    public void TienePokemonsRestantesTestDos()
    {
        //Test cuando NO tiene pokemons restantes
        Assert.That(false, Is.EqualTo(entrenador2.TienePokemonsRestantes()));
    }


    [Test]
    public void PuedeUsarAtaqueEspecialTest()
    {
        //Caso en que no puede
        entrenador2.ContadorEspecial = 2;
        Assert.That(entrenador2.PuedeUsarAtaqueEspecial(), Is.EqualTo(false));
    }

    [Test]
    public void PuedeUsarAtaqueEspecialTestDos()
    {
        //Caso en que se puede
        entrenador2.ContadorEspecial = 0;
        Assert.That(entrenador2.PuedeUsarAtaqueEspecial(), Is.EqualTo(true));
    }

    [Test]
    public void EstablecerPokemonActivoTest()
    {
        bat.SeleccionarPokemones(entrenador1, 2);
        entrenador1.EstablecerPokemonActivo(pikachu);
        Assert.That(pikachu, Is.EqualTo(entrenador1.PokemonActivo));
    }
}