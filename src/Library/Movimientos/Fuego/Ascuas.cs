using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Fuego;

public class Ascuas: MovimientoSimple
{
    public Ascuas()
    {
        ETipos Tipo = ETipos.FUEGO;
        Nombre  = "Ascuas";
        Daño = 25;
        PP = 20;
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}