using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Fuego
{
    public class Ascuas : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.FUEGO;
        public override string Nombre { get; } = "Ascuas";
        public override int Daño { get; } = 50;
        public override int PP { get; } = 4;
        public override bool Especial { get; } = true;
        
        public override int Presicion { get; } = 100;
    }
}