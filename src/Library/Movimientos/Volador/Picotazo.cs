using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Volador
{
    public class Picotazo : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.VOLADOR;
        public override string Nombre { get; } = "Picotazo";
        public override int Daño { get; } = 50;
        public override int PP { get; } = 10;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 100;
    }
}