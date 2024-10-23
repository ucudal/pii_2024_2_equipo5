using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Psiquico;

public class Psicoonda: MovimientoEspecial
{
    public Psicoonda()
    {
        Tipo = ETipos.PSIQUICO;
        Nombre = "Psicoonda";
        Daño = 30;
        Precision = 100;
        //los PP los hereda ya que para los especiales siempre es 4
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}