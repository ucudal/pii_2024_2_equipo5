using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Normal
{
    public class AtaqueRapido : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.NORMAL;
        public override string Nombre { get; } = "Ataque rápido";
        public override int Daño { get; } = 50;
        public override int PP { get; } = 10;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 100;
    }
}