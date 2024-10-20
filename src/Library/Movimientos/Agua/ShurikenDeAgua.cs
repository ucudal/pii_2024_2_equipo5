using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Agua
{
    public class ShurikenDeAgua : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.AGUA;
        public override string Nombre { get; } = "Shuriken de agua";
        public override int Daño { get; } = 25;
        public override int PP { get; } = 5;
        public override bool Especial { get; } = true;
    }
}