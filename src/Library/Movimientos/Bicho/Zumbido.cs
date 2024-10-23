using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Bicho;

public class Zumbido: MovimientoEspecial
{ 
    public Zumbido()
    {
        Tipo = ETipos.BICHO;
        Nombre = "Zumbido";
        Daño = 40;
        Precision = 100;
        //los PP los hereda ya que para los especiales siempre es 4
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}