using System;
using System.Collections.Generic;
using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Normal;
using Library.Movimientos.Planta;
using Library.Movimientos.Veneno;

namespace Library.Pokemones;

public class Venasaur : Pokemon
{
    public Venasaur()
    {
        Nombre = "Venasaur";

        SaludTotal = 130;
        SaludActual = SaludTotal;

        ValorAtaque = 50;
        ValorDefensa = 55;
        ValorAtaqueEspecial = 50;
        ValorDefensaEspecial = 60;
        Debil = false;

        Movimientos = new List<IMovimiento> { new LatigoCepa(), new HojaMagica(), new CargaToxica(), new Placaje() };
        Tipo = new List<ETipos> { ETipos.VENENO };
    }
}