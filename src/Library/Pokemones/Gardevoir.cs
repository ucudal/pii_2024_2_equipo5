using System.Collections.Generic;
using Library.Enums;
using Library.ClasesBase;
using Library.Movimientos.Fantasma;
using Library.Movimientos.Hada;
using Library.Movimientos.Psiquico;

namespace Library.Pokemones
{
    public class Gardevoir : Pokemon
    {
        public Gardevoir()
        {
            Nombre = "Gardevoir";
            SaludTotal = 139;
            SaludActual = SaludTotal;
            ValorAtaque = 58;
            ValorDefensa = 43;
            ValorAtaqueEspecial = 72;
            ValorDefensaEspecial = 46;
            Velocidad = 101;
            Evasion = 35;
            Debil = false;

            
            Movimientos = new List<Movimiento>
            {
                new FuerzaLunar(),
                new Psiquico(),
                new CabezazoZen(),
                new BolaSombra()
            };

            Tipo = new List<ETipos>
            {
                ETipos.PSIQUICO, 
            };
        }
    }
}