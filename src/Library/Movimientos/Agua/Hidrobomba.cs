using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Agua;

public class Hidrobomba : IMovimiento
{
    public ETipos Tipos { get; } = ETipos.AGUA;
        
    public string Nombre { get; } = "Hidrobomba";
        
    public int Daño { get; } = 50;
        
    public int PP { get; } = 3;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public Hidrobomba()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}