using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Agua;

public class Hidropulso : IMovimiento
{
    public ETipos Tipo { get; } = ETipos.AGUA;
        
    public string Nombre { get; } = "Hidropulso";
        
    public int Daño { get; } = 60;
        
    public int PP { get; } = 5;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public Hidropulso()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}