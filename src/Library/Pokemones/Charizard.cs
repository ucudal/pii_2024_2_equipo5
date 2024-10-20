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

            
            Movimientos = new List<Movimiento>
            {
                new Lanzallamas(), 
                new Impactrueno() 
            };

            Tipo = new List<ETipos>
            {
                ETipos.FUEGO, 
                ETipos.VOLADOR 
            };
        }
    }
}