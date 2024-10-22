using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Roca
{
    public class Pedrada : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.ROCA;
        public override string Nombre { get; } = "Pedrada";
        public override int Daño { get; } = 45;
        public override int PP { get; } = 8;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 95;
    }
}