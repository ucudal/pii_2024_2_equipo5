using System.Collections.Generic;
using Library.Enums;
using Library.ClasesBase;
using Library.Movimientos.Hada;
using Library.Movimientos.Normal;

namespace Library.Pokemones
{
    public class Sylveon : Pokemon
    {
        public Sylveon()
        {
            Nombre = "Sylveon";
            SaludTotal = 130;
            SaludActual = SaludTotal;
            ValorAtaque = 55;
            ValorDefensa = 45;
            ValorAtaqueEspecial = 59;
            ValorDefensaEspecial = 48;
            Velocidad = 103;
            Evasion = 18;
            Debil = false;

            
            Movimientos = new List<Movimiento>
            {
                new Placaje(),
                new AtaqueRapido(),
                new FuerzaLunar()
                
            };

            Tipo = new List<ETipos>
            {
                ETipos.HADA, 
            };
        }
    }
}