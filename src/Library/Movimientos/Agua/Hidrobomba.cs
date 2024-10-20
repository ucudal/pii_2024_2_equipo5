using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Agua
{
    public class Hidrobomba : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.AGUA;
        public override string Nombre { get; } = "Hidrobomba";
        public override int Daño { get; } = 110;
        public override int PP { get; } = 2;
        public override bool Especial { get; } = true;
    }
}