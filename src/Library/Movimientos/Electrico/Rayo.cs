using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Electrico
{
    public class Rayo : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.ELECTRICO;
        public override string Nombre { get; } = "Rayo";
        public override int Daño { get; } = 90;
        public override int PP { get; } = 3;
        public override bool Especial { get; } = true;
    }
}