using System;
using System.Collections.Generic;
using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Hada;
using Library.Movimientos.Psiquico;

namespace Library.Pokemones;

public class Gardevoir : Pokemon
{
    public Gardevoir()
    {
        Nombre = "Gardevoir";

        SaludTotal = 120;
        SaludActual = SaludTotal;

        ValorAtaque = 55;
        ValorDefensa = 40;
        ValorAtaqueEspecial = 70;
        ValorDefensaEspecial = 50;
        Debil = false;

        Movimientos = new List<IMovimiento> { new FuerzaLunar(), new Psiquico(), new Confusion() };
        Tipo = new List<ETipos> { ETipos.HADA };
    }
    
}