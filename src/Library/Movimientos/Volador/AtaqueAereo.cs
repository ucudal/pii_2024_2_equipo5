using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Volador
{
    public class AtaqueAereo : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.VOLADOR;
        public override string Nombre { get; } = "Ataque aéreo";
        public override int Daño { get; } = 130;
        public override int PP { get; } = 2;
        public override bool Especial { get; } = false;
        
        public override int Presicion { get; } = 80;
    }
}