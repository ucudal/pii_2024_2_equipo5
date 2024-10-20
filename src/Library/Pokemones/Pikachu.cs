using Library.Enums;
using Library.ClasesBase;
using Library.Movimientos.Electrico;

namespace Library.Pokemones
{
    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            Nombre = "Pikachu";
            SaludTotal = 145;
            SaludActual = SaludTotal;
            ValorAtaque = 58;
            ValorDefensa = 43;
            ValorAtaqueEspecial = 65;
            ValorDefensaEspecial = 50;
            Debil = false;

            
            Movimientos = new List<Movimiento>
            {
                new Rayo(), 
                new Impactrueno() 
            };

            Tipo = new List<ETipos>
            {
                ETipos.ELECTRICO
            };
        }
    }
}