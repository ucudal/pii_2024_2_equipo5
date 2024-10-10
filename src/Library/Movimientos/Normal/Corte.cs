using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Normal;

public class Corte: iMovimiento
{
    public Tipos Tipos { get; } = Tipos.NORMAL;

    public string Nombre { get; } = "Corte";

    public int Daño { get; } = 18;

    public int PP { get; } = 25;

    public int CurrentPP { get; set; }

    public bool Especial { get; } = false;


    public Corte()
    {
        CurrentPP = PP; // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}