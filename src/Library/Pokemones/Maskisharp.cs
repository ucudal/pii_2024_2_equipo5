using System;
using System.Collections.Generic;
using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Normal;

namespace Library.Pokemones;

public class Maskisharp : Pokemon
{
    public Maskisharp()
    {
        Nombre = "Mashikarp";

        SaludTotal = 95;
        SaludActual = SaludTotal;

        ValorAtaque = 25;
        ValorDefensa = 40;
        ValorAtaqueEspecial = 30;
        ValorDefensaEspecial = 40;
        Debil = false;

        Movimientos = new List<IMovimiento> { new Salpicadura(), new Placaje() };

        Tipo = new List<ETipos> { ETipos.NORMAL };
    }
}