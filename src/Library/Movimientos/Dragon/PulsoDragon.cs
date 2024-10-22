using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Dragon
{
    public class PulsoDragon : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.DRAGON;
        public override string Nombre { get; } = "Pulso Dragón";
        public override int Daño { get; } = 85;
        public override int PP { get; } = 4;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 95;
    }
}