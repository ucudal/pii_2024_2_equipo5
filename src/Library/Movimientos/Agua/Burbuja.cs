using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Agua
{
    public class Burbuja : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.AGUA;
        public override string Nombre { get; } = "Burbuja";
        public override int Daño { get; } = 50;
        public override int PP { get; } = 4;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 100;
    }
}