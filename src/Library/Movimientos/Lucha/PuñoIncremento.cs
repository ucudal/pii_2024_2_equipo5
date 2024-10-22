using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Lucha
{
    public class PuñoIncremento : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.LUCHA;
        public override string Nombre { get; } = "Puño incremento";
        public override int Daño { get; } = 60;
        public override int PP { get; } = 8;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 100;
    }
}