using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Electrico
{
    public class BolaVoltio : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.ELECTRICO;
        public override string Nombre { get; } = "Bola Voltio";
        public override int Daño { get; } = 75;
        public override int PP { get; } = 5;
        public override bool Especial { get; } = true;
    }
}