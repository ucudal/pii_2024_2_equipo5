using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Agua;

public class Hidrobomba : IMovimiento
{
    public ETipos Tipo { get; } = ETipos.AGUA;
        
    public string Nombre { get; } = "Hidrobomba";
        
    public int Daño { get; } = 110;
        
    public int PP { get; } = 2;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public Hidrobomba()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}