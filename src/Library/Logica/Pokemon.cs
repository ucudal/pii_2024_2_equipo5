using Library.Enums;
using Library.Interfaces;

namespace Library.Logica;

public class Pokemon : IPokemon
{
    p string Nombre;
    public int SaludTotal { get; set; }
    public int SaludActual { get; set; }
    public bool Debil { get; set; }
    public int ValorAtaque { get; set; }
    public int ValorDefensa { get; set; }
    public int ValorAtaqueEspecial { get; set; }
    public int ValorDefensaEspecial { get; set; }
    public List<ETipos> Tipo { get; set; }
    public List<IMovimiento> Movimientos { get; set; }
    public void RecibirDanio(int dañoRecibido)
    {
        throw new NotImplementedException();
    }

    public void UsarMovimiento(IMovimiento movimiento)
    {
        throw new NotImplementedException();
    }
}