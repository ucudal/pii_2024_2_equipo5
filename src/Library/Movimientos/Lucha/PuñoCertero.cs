using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Lucha
{
    public class PuñoCertero : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.LUCHA;
        public override string Nombre { get; } = "Puño certero";
        public override int Daño { get; } = 120;
        public override int PP { get; } = 2;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 100;
    }
}