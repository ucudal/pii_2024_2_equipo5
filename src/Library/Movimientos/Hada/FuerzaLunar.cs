using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Hada;

public class FuerzaLunar: MovimientoEspecial
{
    public FuerzaLunar()
    {
        Tipo = ETipos.HADA;
        Nombre = "Fuerza Lunar";
        Daño = 50;
        Precision = 100;
        //los PP los hereda ya que para los especiales siempre es 4
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}