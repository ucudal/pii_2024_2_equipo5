using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Dragon
{
    public class GarraDragon : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.DRAGON;
        public override string Nombre { get; } = "Garra Dragón";
        public override int Daño { get; } = 80;
        public override int PP { get; } = 4;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 100;
    }
}