using System;
using System.Collections.Generic;
using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Dragon;
using Library.Movimientos.Fuego;
using Library.Movimientos.Volador;

namespace Library.Pokemones;

public class Charizard : Pokemon
{
    public Charizard()
    {
        Nombre = "Charizard";

        SaludTotal = 130;
        SaludActual = SaludTotal;

        ValorAtaque = 58;
        ValorDefensa = 43;
        ValorAtaqueEspecial = 65;
        ValorDefensaEspecial = 50;
        Debil = false;

        Movimientos = new List<IMovimiento> { new Lanzallamas(), new Vuelo(), new GarraDragon(), new PulsoDragon() };
        Tipo = new List<ETipos> { ETipos.FUEGO, ETipos.VOLADOR };
    }
}