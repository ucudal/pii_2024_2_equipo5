using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Fuego;

public class Ascuas: iMovimiento
{
    public Tipos Tipos { get; } = Tipos.FUEGO;
        
    public string Nombre { get; } = "Ascuas";
        
    public int Daño { get; } = 25;
        
    public int PP { get; } = 20;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public Ascuas()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}