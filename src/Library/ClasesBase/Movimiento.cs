using Library.Enums;
using Library.Interfaces;

namespace Library.ClasesBase
{
    public abstract class Movimiento : IMovimiento
    {
        public abstract ETipos Tipo { get; }
        public abstract string Nombre { get; }
        public abstract int Daño { get; }
        public abstract int PP { get; }
        public int CurrentPP { get; set; }
        public abstract bool Especial { get; }
        public abstract int Presicion { get; }

        protected Movimiento()
        {
            CurrentPP = PP; // Inicializa la cantidad de veces que puedes usar un movimiento.
        }
    }
}