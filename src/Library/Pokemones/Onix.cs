using System.Collections.Generic;
using Library.Enums;
using Library.ClasesBase;
using Library.Movimientos.Normal;
using Library.Movimientos.Roca;
using Library.Movimientos.Tierra;

namespace Library.Pokemones
{
    public class Onix : Pokemon
    {
        public Onix()
        {
            Nombre = "Onix";
            SaludTotal = 141;
            SaludActual = SaludTotal;
            ValorAtaque = 59;
            ValorDefensa = 57;
            ValorAtaqueEspecial = 62;
            ValorDefensaEspecial = 57;
            Velocidad = 88;
            Evasion = 10;
            Debil = false;

            
            Movimientos = new List<Movimiento>
            {
                new Terremoto(),
                new Pedrada(),
                new RompeRocas(),
                new Placaje()
            };

            Tipo = new List<ETipos>
            {
                ETipos.ROCA, 
            };
        }
    }
}