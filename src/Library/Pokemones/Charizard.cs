using System.Collections.Generic;
using Library.Enums;
using Library.ClasesBase;
using Library.Movimientos.Dragon;
using Library.Movimientos.Fuego;
using Library.Movimientos.Electrico;

namespace Library.Pokemones
{
    public class Charizard : Pokemon
    {
        public Charizard()
        {
            Nombre = "Charizard";
            SaludTotal = 145;
            SaludActual = SaludTotal;
            ValorAtaque = 58;
            ValorDefensa = 43;
            ValorAtaqueEspecial = 65;
            ValorDefensaEspecial = 50;
            Debil = false;

            // Ahora solo se crean instancias de clases derivadas de Movimiento
            Movimientos = new List<Movimiento>
            {
                new Lanzallamas(), 
                new Vuelo(), 
                new GarraDragon(), 
                new Impactrueno() // Añadiendo el nuevo movimiento
            };

            Tipo = new List<ETipos>
            {
                ETipos.FUEGO, 
                ETipos.VOLADOR 
            };
        }
    }
}