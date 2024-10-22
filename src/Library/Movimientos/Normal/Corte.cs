using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Normal
{
    public class Corte : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.NORMAL;
        public override string Nombre { get; } = "Corte";
        public override int Daño { get; } = 55;
        public override int PP { get; } = 8;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 100;
    }
}