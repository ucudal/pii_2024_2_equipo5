using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Agua;

public class Hidrobomba : MovimientoEspecial
{
    public Hidrobomba()
    {
        Tipo = ETipos.AGUA;
        Nombre = "Hidrobomba";
        Daño = 50;
        //los PP los hereda ya que para los especiales siempre es 4
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
   
}