using System.Collections.Generic;
using Library.Enums;
using Library.ClasesBase;
using Library.Movimientos.Dragon;
using Library.Movimientos.Fuego;
using Library.Movimientos.Volador;

namespace Library.Pokemones
{
    public class Charizard : Pokemon
    {
        public Charizard()
        {
            Nombre = "Charizard";
            SaludTotal = 145;
            SaludActual = SaludTotal;
            ValorAtaque = 61;
            ValorDefensa = 50;
            ValorAtaqueEspecial = 68;
            ValorDefensaEspecial = 54;
            Velocidad = 100;
            Evasion = 9;
            Debil = false;

            
            Movimientos = new List<Movimiento>
            {
                new Lanzallamas(), 
                new Vuelo(),
                new GarraDragon(),
                new LlamaAzul()
            };

            Tipo = new List<ETipos>
            {
                ETipos.FUEGO, 
            };
        }
    }
}