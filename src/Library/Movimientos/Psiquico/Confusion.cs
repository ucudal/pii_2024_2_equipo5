using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Psiquico
{
    public class Confusion : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.PSIQUICO;
        public override string Nombre { get; } = "Confusión";
        public override int Daño { get; } = 55;
        public override int PP { get; } = 4;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 100;
    }
}