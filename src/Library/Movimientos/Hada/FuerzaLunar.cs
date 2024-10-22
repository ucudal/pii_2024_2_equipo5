using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Hada
{
    public class FuerzaLunar : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.HADA;
        public override string Nombre { get; } = "Fuerza Lunar";
        public override int Daño { get; } = 100;
        public override int PP { get; } = 3;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 100;
    }
}