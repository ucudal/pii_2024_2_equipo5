using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Tierra
{
    public class Terremoto : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.TIERRA;
        public override string Nombre { get; } = "Terremoto";
        public override int Daño { get; } = 100;
        public override int PP { get; } = 2;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 100;
    }
}