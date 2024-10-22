using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Veneno
{
    public class LanzaMugre : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.VENENO;
        public override string Nombre { get; } = "Lanza mugre";
        public override int Daño { get; } = 120;
        public override int PP { get; } = 2;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 85;
    }
}