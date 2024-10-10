using Library.Enums;

namespace Library.Interfaces;

public interface IPokemon
{
    string Nombre { get; set; }
    int SaludTotal { get; set; }
    int SaludActual { get; set; }
    bool Debil { get; set; }
    int ValorAtaque { get; set; }
    int ValorDefensa { get; set; }
    int ValorAtaqueEspecial { get; set; }
    int ValorDefensaEspecial { get; set; }
    List<ETipos> Tipo { get; set; } 
    List<IMovimiento> Movimientos { get; set; }
    void RecibirDanio(int dañoRecibido);
    void UsarMovimiento(IMovimiento movimiento);
}