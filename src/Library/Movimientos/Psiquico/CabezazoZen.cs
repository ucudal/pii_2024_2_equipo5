using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Psiquico
{
    public class CabezazoZen : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.PSIQUICO;
        public override string Nombre { get; } = "Cabezazo zen";
        public override int Daño { get; } = 80;
        public override int PP { get; } = 5;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 90;
    }
}