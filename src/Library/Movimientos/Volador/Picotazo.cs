using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Volador;

public class Picotazo: IMovimiento
{
    public ETipos ETipos { get; } = ETipos.VOLADOR;
        
    public string Nombre { get; } = "Picotazo";
        
    public int Daño { get; } = 20;
        
    public int PP { get; } = 25;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public Picotazo()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}