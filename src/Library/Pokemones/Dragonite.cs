using System.Collections.Generic;
using Library.Enums;
using Library.ClasesBase;
using Library.Movimientos.Dragon;
using Library.Movimientos.Normal;
using Library.Movimientos.Volador;

namespace Library.Pokemones
{
    public class Dragonite : Pokemon
    {
        public Dragonite()
        {
            Nombre = "Dragonite";
            SaludTotal = 142;
            SaludActual = SaludTotal;
            ValorAtaque = 55;
            ValorDefensa = 48;
            ValorAtaqueEspecial = 60;
            ValorDefensaEspecial = 52;
            Velocidad = 99;
            Evasion = 8;
            Debil = false;

            
            Movimientos = new List<Movimiento>
            {
                new GarraDragon(),
                new PulsoDragon(),
                new Corte(),
                new AtaqueAereo()
            };

            Tipo = new List<ETipos>
            {
                ETipos.DRAGON, 
            };
        }
    }
}