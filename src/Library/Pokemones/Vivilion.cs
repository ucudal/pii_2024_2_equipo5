using System.Collections.Generic;
using Library.Enums;
using Library.ClasesBase;
using Library.Movimientos.Bicho;
using Library.Movimientos.Normal;

namespace Library.Pokemones
{
    public class Vivillion : Pokemon
    {
        public Vivillion()
        {
            Nombre = "Vivillion";
            SaludTotal = 132;
            SaludActual = SaludTotal;
            ValorAtaque = 57;
            ValorDefensa = 48;
            ValorAtaqueEspecial = 62;
            ValorDefensaEspecial = 53;
            Velocidad = 104;
            Evasion = 19;
            Debil = false;

            
            Movimientos = new List<Movimiento>
            {
                new TijeraX(),
                new Zumbido(),
                new Placaje()
            };

            Tipo = new List<ETipos>
            {
                ETipos.BICHO, 
            };
        }
    }
}