using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Veneno
{
    public class Eructo : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.VENENO;
        public override string Nombre { get; } = "Eructo";
        public override int Daño { get; } = 125;
        public override int PP { get; } = 1;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 95;
    }
}