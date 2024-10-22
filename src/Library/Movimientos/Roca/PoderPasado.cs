using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Roca
{
    public class PoderPasado : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.ROCA;
        public override string Nombre { get; } = "Poder pasado";
        public override int Daño { get; } = 75;
        public override int PP { get; } = 3;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 100;
    }
}