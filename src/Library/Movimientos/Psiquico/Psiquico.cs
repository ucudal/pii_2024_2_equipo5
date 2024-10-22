using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Psiquico
{
    public class Psiquico : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.PSIQUICO;
        public override string Nombre { get; } = "Psíquico";
        public override int Daño { get; } = 90;
        public override int PP { get; } = 3;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 100;
    }
}