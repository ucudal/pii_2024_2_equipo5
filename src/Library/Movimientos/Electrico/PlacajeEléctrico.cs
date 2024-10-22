using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Electrico
{
    public class PlacajeEléctrico : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.ELECTRICO;
        public override string Nombre { get; } = "Placaje eléctrico";
        public override int Daño { get; } = 100;
        public override int PP { get; } = 2;
        public override bool Especial { get; } = false;

        public override int Presicion { get; } = 95;
    }
}