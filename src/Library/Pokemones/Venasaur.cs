using System.Collections.Generic;
using Library.Enums;
using Library.ClasesBase;
using Library.Movimientos.Dragon;
using Library.Movimientos.Fuego;
using Library.Movimientos.Planta;
using Library.Movimientos.Veneno;
using Library.Movimientos.Volador;

namespace Library.Pokemones
{
    public class Venasaur : Pokemon
    {
        public Venasaur()
        {
            Nombre = "Venasaur";
            SaludTotal = 146;
            SaludActual = SaludTotal;
            ValorAtaque = 60;
            ValorDefensa = 52;
            ValorAtaqueEspecial = 64;
            ValorDefensaEspecial = 56;
            Velocidad = 91;
            Evasion = 6;
            Debil = false;

            
            Movimientos = new List<Movimiento>
            {
                new LatigoCepa(),
                new HojaMagica(),
                new Eructo(),
                new CargaToxica(),
            };

            Tipo = new List<ETipos>
            {
                ETipos.PLANTA, 
            };
        }
    }
}