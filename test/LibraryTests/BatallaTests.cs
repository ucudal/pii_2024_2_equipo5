using System.Collections.Generic;
using Library.Interfaces;
using Library.Logica;
using Library.Movimientos.Electrico;
using Library.Pokemones;
using NUnit.Framework;

namespace LibraryTests
{
    public class BatallaTests
    {
        private Entrenador entrenador1;
        private Entrenador entrenador2;
        private Efectividad efectividad;
        private List<IPokemon> pokemonsDisponibles;

        [SetUp]
        public void Setup()
        {
            entrenador1 = new Entrenador("Ash");
            entrenador2 = new Entrenador("Misty");
            efectividad = new Efectividad();
            pokemonsDisponibles = new List<IPokemon> { new Pikachu(), new Charizard() };
        }

        [Test]
        public void InicializaEntrenador1Correctamente()
        {
            var batalla = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);
            Assert.That(batalla.Entrenador1, Is.EqualTo(entrenador1));
        }

        [Test]
        public void InicializaEntrenador2Correctamente()
        {
            var batalla = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);
            Assert.That(batalla.Entrenador2, Is.EqualTo(entrenador2));
        }

        [Test]
        public void InicializaEfectividadCorrectamente()
        {
            var batalla = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);
            Assert.That(batalla.Efectividad, Is.EqualTo(efectividad));
        }

        [Test]
        public void InicializaPokemonsDisponiblesCorrectamente()
        {
            var batalla = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);
            Assert.That(batalla.PokemonsDisponibles, Is.EqualTo(pokemonsDisponibles));
        }

        [Test]
        public void InicializaContadorTurnoEnCero()
        {
            var batalla = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);
            Assert.That(batalla.ContadorTurno, Is.EqualTo(0));
        }

        [Test]
        public void InicializaEntrenadorActualComoEntrenador1()
        {
            var batalla = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);
            Assert.That(batalla.EntrenadorActual, Is.EqualTo(entrenador1));
        }

        [Test]
        public void IniciarBatalla_SeleccionaPokemonesParaAmbosEntrenadores()
        {
            var batalla = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);
            batalla.IniciarBatalla();

            Assert.That(entrenador1.Pokemons.Count, Is.EqualTo(1));
            Assert.That(entrenador2.Pokemons.Count, Is.EqualTo(1));
        }

        [Test]
        public void Atacar_AplicaDanioCorrectamenteAlEntrenadorDefensor()
        {
            // Arrange
            var batalla = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);

            var pikachu = new Pikachu();
            var charizard = new Charizard();

            entrenador1.AgregarPokemon(pikachu);
            entrenador2.AgregarPokemon(charizard);

            // Inicializa los Pokémon activos manualmente
            entrenador1.PokemonActivo = pikachu;
            entrenador2.PokemonActivo = charizard;

            int vidaInicial = entrenador2.PokemonActivo.SaludTotal;

            // Act
            batalla.Atacar(entrenador1, new Impactrueno());

            // Assert
            Assert.That(entrenador2.PokemonActivo.SaludActual, Is.LessThan(vidaInicial));
        }


        [Test]
        public void SeleccionarPokemones_AgregaPokemonesAlEntrenador()
        {
            var batalla = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);
            batalla.SeleccionarPokemones(entrenador1, 1);

            Assert.That(entrenador1.Pokemons.Count, Is.EqualTo(1));
            Assert.That(pokemonsDisponibles.Count, Is.EqualTo(1));
        }

        [Test]
        public void ObtenerEntrenadorActual_DevuelveEntrenador1AlInicio()
        {
            var batalla = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);
            var entrenadorActual = batalla.ObtenerEntrenadorActual();

            Assert.That(entrenadorActual, Is.EqualTo(entrenador1));
        }

        [Test]
        public void CambiarPokemon_CambiaPokemonActivoCorrectamente()
        {
            var batalla = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);

            entrenador1.PokemonActivo = new Pikachu();
            batalla.CambiarPokemon(entrenador1, 1);

            Assert.That(entrenador1.PokemonActivo.Nombre, Is.EqualTo("Charizard"));
        }

        [Test]
        public void SiguienteTurno_CambiaEntrenadorActualCorrectamente()
        {
            var batalla = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);
            batalla.SiguienteTurno();

            Assert.That(batalla.EntrenadorActual, Is.EqualTo(entrenador2));
        }

        [Test]
        public void Fin_DevuelveTrueSiUnEntrenadorSeQuedaSinPokemones()
        {
            var batalla = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);
            entrenador1.ClearPokemons();

            bool resultado = batalla.Fin();

            Assert.That(resultado, Is.True);
        }

        [Test]
        public void Fin_DevuelveFalseSiAmbosEntrenadoresTienenPokemones()
        {
            var batalla = new Batalla(entrenador1, entrenador2, efectividad, pokemonsDisponibles);
            entrenador1.AgregarPokemon(new Pikachu());
            entrenador2.AgregarPokemon(new Charizard());

            bool resultado = batalla.Fin();

            Assert.That(resultado, Is.False);
        }
    }
}