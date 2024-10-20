using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Agua
{
    public class Hidropulso : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.AGUA;
        public override string Nombre { get; } = "Hidropulso";
        public override int Daño { get; } = 65;
        public override int PP { get; } = 5;
        public override bool Especial { get; } = true;
    }
}