using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Volador;

public class Vuelo: MovimientoSimple
{
    public Vuelo()
    {
        Tipo = ETipos.VOLADOR;
        Nombre = "Vuelo";
        Daño = 45;
        PP = 5;
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}