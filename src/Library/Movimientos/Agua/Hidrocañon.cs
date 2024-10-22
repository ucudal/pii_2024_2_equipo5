using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Agua
{
    public class Hidrocañon : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.AGUA;
        public override string Nombre { get; } = "Hidrocañon";
        public override int Daño { get; } = 130;
        public override int PP { get; } = 1;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 85;
    }
}