using System;
using System.Collections.Generic;
using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Normal;

namespace Library.Pokemones;

public class Snorlax : Pokemon
{
    public Snorlax()
    {
        Nombre = "Snorlax";

        SaludTotal = 150;
        SaludActual = SaludTotal;

        ValorAtaque = 30;
        ValorDefensa = 75;
        ValorAtaqueEspecial = 35;
        ValorDefensaEspecial = 75;
        Debil = false;

        Movimientos = new List<IMovimiento> { new Placaje() };
        Tipo = new List<ETipos> { ETipos.NORMAL };
    }
}