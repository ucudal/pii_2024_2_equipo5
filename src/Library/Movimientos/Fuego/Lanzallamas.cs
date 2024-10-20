using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Fuego
{
    public class Lanzallamas : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.FUEGO;
        public override string Nombre { get; } = "Lanzallamas";
        public override int Daño { get; } = 80;
        public override int PP { get; } = 10;
        public override bool Especial { get; } = true;
    }
}