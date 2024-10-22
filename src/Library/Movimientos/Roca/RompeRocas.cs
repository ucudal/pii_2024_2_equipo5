using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Roca
{
    public class RompeRocas : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.ROCA;
        public override string Nombre { get; } = "Rompe rocas";
        public override int Daño { get; } = 80;
        public override int PP { get; } = 6;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 90;
    }
}