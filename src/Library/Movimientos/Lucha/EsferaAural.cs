using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Lucha
{
    public class EsferaAural : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.LUCHA;
        public override string Nombre { get; } = "Esfera aural";
        public override int Daño { get; } = 80;
        public override int PP { get; } = 4;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 90;
    }
}