using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Veneno;

public class CargaToxica: MovimientoEspecial
{
    public CargaToxica()
    {
        Tipo = ETipos.VENENO;
        Nombre = "CargaTóxica";
        Daño = 40;
        //los PP los hereda ya que para los especiales siempre es 4
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}