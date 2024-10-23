using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Fuego;

public class Lanzallamas: MovimientoEspecial
{
    public Lanzallamas()
    {
        Tipo = ETipos.FUEGO;
        Nombre = "Lanzallamas";
        Daño = 40;
        Precision = 100;
        //los PP los hereda ya que para los especiales siempre es 4
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}