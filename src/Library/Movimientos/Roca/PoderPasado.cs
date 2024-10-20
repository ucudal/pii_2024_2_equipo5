using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Roca;

public class PoderPasado: IMovimiento
{
    public ETipos Tipo { get; } = ETipos.ROCA;
        
    public string Nombre { get; } = "Poder Pasado";
        
    public int Daño { get; } = 65;
        
    public int PP { get; } = 15;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public PoderPasado()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}