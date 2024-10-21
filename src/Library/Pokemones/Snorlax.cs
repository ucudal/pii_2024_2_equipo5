using System;
using System.Collections.Generic;
using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Normal;
using Library.ClasesBase;

namespace Library.Pokemones;

public class Snorlax : Pokemon
{
    public string Nombre { get; set; }
    public int SaludTotal { get; set; }
    public int SaludActual { get; set; }
    public int ValorAtaque { get; set; }
    public int ValorDefensa { get; set; }
    public int ValorAtaqueEspecial { get; set; }
    public int ValorDefensaEspecial { get; set; }
    public List<IMovimiento> Movimientos { get; set; }
    public List<ETipos> Tipo { get; set; }


    public Snorlax()
    {
        Nombre = "Snorlax";

        SaludTotal = 165;
        SaludActual = SaludTotal;

        ValorAtaque = 30;
        ValorDefensa = 75;
        ValorAtaqueEspecial = 35;
        ValorDefensaEspecial = 75;
        Debil = false;

        Movimientos = new List<IMovimiento> { new Placaje() };
        Tipo = new List<ETipos> { ETipos.NORMAL };
    }

    public void RecibirDanio(int danio)
    {
        SaludActual = Math.Max(SaludActual - danio, 0);
        if (SaludActual <= 0)
        {
            Debil = true;
        }
    }

    public bool Debil { get; set; }

    public void UsarMovimiento(IMovimiento movimiento)
    {
        IMovimiento MovimientoUtilizado = Movimientos.Find(f => f == movimiento);

        if (MovimientoUtilizado != null)
        {
            MovimientoUtilizado.CurrentPP -= 1;
        } // Restamos 1 PP, ya que al usarlo se gasta.
    }
}