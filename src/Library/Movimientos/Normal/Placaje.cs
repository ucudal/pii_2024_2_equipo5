using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Normal
{
    public class Placaje : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.NORMAL;
        public override string Nombre { get; } = "Placaje";
        public override int Daño { get; } = 55;
        public override int PP { get; } = 12;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 100;
    }
}