using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Electrico
{
    public class Impactrueno : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.ELECTRICO;
        public override string Nombre { get; } = "Impactrueno";
        public override int Daño { get; } = 55;
        public override int PP { get; } = 4;
        public override bool Especial { get; } = true;

        public override int Presicion { get; } = 100;
    }
}