using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Fuego;

public class Lanzallamas: IMovimiento
{
    public ETipos Tipo { get; } = ETipos.FUEGO;
        
    public string Nombre { get; } = "Lanzallamas";
        
    public int Daño { get; } = 40;
        
    public int PP { get; } = 10;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public Lanzallamas()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}