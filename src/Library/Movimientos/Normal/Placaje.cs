using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Normal;

public class Placaje: MovimientoSimple
{
    public Placaje()
    {
        Tipo = ETipos.NORMAL;
        Nombre = "Placaje";
        Daño = 25;
        PP = 15;
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}