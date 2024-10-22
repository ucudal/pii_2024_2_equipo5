using System;
using System.Collections.Generic;
using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Bicho;
using Library.Movimientos.Normal;
using Library.Movimientos.Psiquico;

namespace Library.Pokemones;

public class Vivilion : Pokemon
{
    public Vivilion()
    {
        Nombre = "Vivillion";

        SaludTotal = 109;
        SaludActual = SaludTotal;

        ValorAtaque = 55;
        ValorDefensa = 40;
        ValorAtaqueEspecial = 60;
        ValorDefensaEspecial = 55;
        Debil = false;

        Movimientos = new List<IMovimiento> { new Zumbido(), new Placaje(), new TijeraX(), new Psicoonda() };
        Tipo = new List<ETipos> { ETipos.BICHO };
    }
}