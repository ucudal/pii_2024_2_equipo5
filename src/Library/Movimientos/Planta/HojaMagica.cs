using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Planta
{
    public class HojaMagica : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.PLANTA;
        public override string Nombre { get; } = "Hoja mágica";
        public override int Daño { get; } = 65;
        public override int PP { get; } = 4;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 100;
    }
}