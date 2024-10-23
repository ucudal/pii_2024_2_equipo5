using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Electrico;

public class Rayo: MovimientoEspecial
{
    public Rayo()
    {
        Tipo = ETipos.ELECTRICO;
        Nombre = "Rayo";
        Daño = 45;
        Precision = 100;
        //los PP los hereda ya que para los especiales siempre es 4
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}