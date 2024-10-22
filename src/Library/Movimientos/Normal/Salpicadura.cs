using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Normal
{
    public class Salpicadura : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.NORMAL;
        public override string Nombre { get; } = "Salpicadura";
        public override int Daño { get; } = 0;
        public override int PP { get; } = 12;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 100;
    }
}