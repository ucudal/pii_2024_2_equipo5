using System.Collections.Generic;
using Library.Enums;
using Library.ClasesBase;
using Library.Movimientos.Agua;

namespace Library.Pokemones
{
    public class Blastoise : Pokemon
    {
        public Blastoise()
        {
            Nombre = "Blastoise";
            SaludTotal = 150;
            SaludActual = SaludTotal;
            ValorAtaque = 58;
            ValorDefensa = 54;
            ValorAtaqueEspecial = 63;
            ValorDefensaEspecial = 60;
            Velocidad = 90;
            Evasion = 5;
            Debil = false;

            
            Movimientos = new List<Movimiento>
            {
                new Hidrobomba(),
                new AcuaCola(),
                new Hidrocañon(),
                new Burbuja()
            };

            Tipo = new List<ETipos>
            {
                ETipos.AGUA, 
            };
        }
    }
}