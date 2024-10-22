using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Volador
{
    public class Vuelo : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.VOLADOR;
        public override string Nombre { get; } = "Vuelo";
        public override int Daño { get; } = 90;
        public override int PP { get; } = 3;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 95;
    }
}