using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Veneno;

public class LanzaMugre: MovimientoSimple
{
    public LanzaMugre()
    {
        Tipo = ETipos.VENENO;
        Nombre = "Lanza Mugre";
        Daño = 45;
        PP = 5;
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }  
}