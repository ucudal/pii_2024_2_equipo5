using System.Collections.Generic;
using Library.Enums;
using Library.ClasesBase;
using Library.Movimientos.Electrico;
using Library.Movimientos.Normal;

namespace Library.Pokemones
{
    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            Nombre = "Pikachu";
            SaludTotal = 119;
            SaludActual = SaludTotal;
            ValorAtaque = 56;
            ValorDefensa = 43;
            ValorAtaqueEspecial = 63;
            ValorDefensaEspecial = 46;
            Velocidad = 107;
            Evasion = 25;
            Debil = false;

            
            Movimientos = new List<Movimiento>
            {
                new AtaqueRapido(),
                new BolaVoltio(),
                new Impactrueno(),
                new Rayo()
            };

            Tipo = new List<ETipos>
            {
                ETipos.ELECTRICO, 
            };
        }
    }
}