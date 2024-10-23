using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Agua;

public class Burbuja: MovimientoEspecial
{
    public Burbuja()
    {
        Tipo = ETipos.AGUA;
        Nombre = "Burbuja";
        Daño = 20;
        Precision = 100;
        //los PP los hereda ya que para los especiales siempre es 4
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}