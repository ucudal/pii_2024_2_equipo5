using System;
using System.Collections.Generic;
using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Dragon;
using Library.Movimientos.Normal;
using Library.Movimientos.Volador;

namespace Library.Pokemones;

public class Dragonite : Pokemon
{
    public Dragonite()
    {
        Nombre = "Dragonite";

        SaludTotal = 125;
        SaludActual = SaludTotal;

        ValorAtaque = 55;
        ValorDefensa = 45;
        ValorAtaqueEspecial = 63;
        ValorDefensaEspecial = 55;
        Debil = false;

        Movimientos = new List<IMovimiento> { new Corte(), new Vuelo(), new GarraDragon(), new PulsoDragon() };
        Tipo = new List<ETipos> { ETipos.DRAGON };
    }
}