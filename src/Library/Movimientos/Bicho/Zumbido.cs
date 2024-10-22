using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Bicho
{
    public class Zumbido : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.BICHO;
        public override string Nombre { get; } = "Zumbido";
        public override int Daño { get; } = 90;
        public override int PP { get; } = 4;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 100;
    }
}