using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Agua;

public class Burbuja: IMovimiento
{
    public ETipos Tipos { get; } = ETipos.AGUA;

    public string Nombre { get; } = "Burbuja";
        
    public int Daño { get; } = 20;
        
    public int PP { get; } = 15;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public Burbuja()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}