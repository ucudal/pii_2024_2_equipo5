using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Planta
{
    public class LatigoCepa : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.PLANTA;
        public override string Nombre { get; } = "Látigo cepa";
        public override int Daño { get; } = 65;
        public override int PP { get; } = 8;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 100;
    }
}