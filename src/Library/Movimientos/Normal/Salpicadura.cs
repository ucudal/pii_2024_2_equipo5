using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Normal;

public class Salpicadura: MovimientoSimple
{
    public Salpicadura()
    {
        Tipo = ETipos.NORMAL;
        Nombre = "Salpicadura";
        Daño = 0;
        PP = 25;
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}