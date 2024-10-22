using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Fantasma
{
    public class BolaSombra : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.FANTASMA;
        public override string Nombre { get; } = "Bola Sombra";
        public override int Daño { get; } = 85;
        public override int PP { get; } = 3;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 95;
    }
}