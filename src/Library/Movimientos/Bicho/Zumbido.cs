using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Bicho;

public class Zumbido: IMovimiento
{
    public ETipos Tipo { get; } = ETipos.BICHO;
        
    public string Nombre { get; } = "Zumbido";
        
    public int Daño { get; } = 40;
        
    public int PP { get; } = 10;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public Zumbido()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}