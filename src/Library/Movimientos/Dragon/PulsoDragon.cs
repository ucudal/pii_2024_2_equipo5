using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Dragon;

public class PulsoDragon : MovimientoEspecial
{ 
    public PulsoDragon()
    {
        Tipo = ETipos.DRAGON;
        Nombre = "PulsoDragón";
        Daño = 40;
        Precision = 95;
        //los PP los hereda ya que para los especiales siempre es 4
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}