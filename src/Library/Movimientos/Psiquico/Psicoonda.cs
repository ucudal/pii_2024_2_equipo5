using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Psiquico
{
    public class Psicoonda : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.PSIQUICO;
        public override string Nombre { get; } = "Psicoonda";
        public override int Daño { get; } = 65;
        public override int PP { get; } = 4;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 100;
    }
}