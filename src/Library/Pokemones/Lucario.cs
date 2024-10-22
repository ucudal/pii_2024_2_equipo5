using System.Collections.Generic;
using Library.Enums;
using Library.ClasesBase;
using Library.Movimientos.Dragon;
using Library.Movimientos.Lucha;

namespace Library.Pokemones
{
    public class Lucario : Pokemon
    {
        public Lucario()
        {
            Nombre = "Lucario";
            SaludTotal = 136;
            SaludActual = SaludTotal;
            ValorAtaque = 60;
            ValorDefensa = 45;
            ValorAtaqueEspecial = 60;
            ValorDefensaEspecial = 42;
            Velocidad = 108;
            Evasion = 20;
            Debil = false;

            
            Movimientos = new List<Movimiento>
            {
                new PuñoCertero(),
                new PuñoIncremento(),
                new PulsoDragon(),
                new EsferaAural()
            };

            Tipo = new List<ETipos>
            {
                ETipos.LUCHA, 
            };
        }
    }
}