using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Bicho
{
    public class TijeraX : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.BICHO;
        public override string Nombre { get; } = "Tijera X";
        public override int Daño { get; } = 80;
        public override int PP { get; } = 6;
        public override bool Especial { get; } = false;
    }
}