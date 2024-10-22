using System;
using System.Collections.Generic;
using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Hada;
using Library.Movimientos.Normal;

namespace Library.Pokemones;

public class Sylveon : Pokemon
{
    public Sylveon()
    {
        Nombre = "Sylveon";

        SaludTotal = 115;
        SaludActual = SaludTotal;

        ValorAtaque = 59;
        ValorDefensa = 43;
        ValorAtaqueEspecial = 63;
        ValorDefensaEspecial = 49;
        Debil = false;

        Movimientos = new List<IMovimiento> { new FuerzaLunar(), new AtaqueRapido(), new Placaje() };
        Tipo = new List<ETipos> { ETipos.HADA };
    }
}