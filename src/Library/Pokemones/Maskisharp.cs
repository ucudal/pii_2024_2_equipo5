using System.Collections.Generic;
using Library.Enums;
using Library.ClasesBase;
using Library.Movimientos.Normal;

namespace Library.Pokemones
{
    public class Mashikarp : Pokemon
    {
        public Mashikarp()
        {
            Nombre = "Mashikarp";
            SaludTotal = 110;
            SaludActual = SaludTotal;
            ValorAtaque = 40;
            ValorDefensa = 40;
            ValorAtaqueEspecial = 45;
            ValorDefensaEspecial = 42;
            Velocidad = 95;
            Evasion = 10;
            Debil = false;

            
            Movimientos = new List<Movimiento>
            {
                new Placaje(),
                new Salpicadura(),
            };

            Tipo = new List<ETipos>
            {
                ETipos.AGUA, 
            };
        }
    }
}