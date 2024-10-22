using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Agua
{
    public class AcuaCola : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.AGUA;
        public override string Nombre { get; } = "Acua Cola";
        public override int Daño { get; } = 90;
        public override int PP { get; } = 3;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 95;
    }
}