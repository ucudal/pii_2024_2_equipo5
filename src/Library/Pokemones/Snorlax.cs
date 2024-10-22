using System.Collections.Generic;
using Library.Enums;
using Library.ClasesBase;
using Library.Movimientos.Normal;

namespace Library.Pokemones
{
    public class Snorlax : Pokemon
    {
        public Snorlax()
        {
            Nombre = "Snorlax";
            SaludTotal = 180;
            SaludActual = SaludTotal;
            ValorAtaque = 44;
            ValorDefensa = 80;
            ValorAtaqueEspecial = 41;
            ValorDefensaEspecial = 75;
            Velocidad = 30;
            Evasion = 2;
            Debil = false;

            
            Movimientos = new List<Movimiento>
            {
                new Placaje()
                
            };

            Tipo = new List<ETipos>
            {
                ETipos.NORMAL, 
            };
        }
    }
}