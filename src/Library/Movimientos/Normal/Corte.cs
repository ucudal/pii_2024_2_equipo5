using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Normal;

public class Corte: MovimientoSimple
{
    public Corte()
    {
        Tipo = ETipos.NORMAL;
        Nombre = "Corte";
        Daño = 18;
        PP = 25;
        Precision = 100;
        CurrentPP = PP; // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}