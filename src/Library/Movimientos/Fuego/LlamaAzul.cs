using Library.Enums;
using Library.ClasesBase;

namespace Library.Movimientos.Fuego
{
    public class LlamaAzul : Movimiento
    {
        public override ETipos Tipo { get; } = ETipos.FUEGO;
        public override string Nombre { get; } = "Llama azul";
        public override int Daño { get; } = 130;
        public override int PP { get; } = 1;
        public override bool Especial { get; } = true;

        public override int Presicion { get; } = 90;
    }
}