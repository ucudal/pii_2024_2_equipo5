using System;
using System.Collections.Generic;
using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Electrico;
using Library.Movimientos.Normal;

namespace Library.Pokemones;

public class Pikachu : Pokemon
{
    public Pikachu()
    {
        Nombre = "Pikachu";

        SaludTotal = 100;
        SaludActual = SaludTotal;

        ValorAtaque = 50;
        ValorDefensa = 35;
        ValorAtaqueEspecial = 55;
        ValorDefensaEspecial = 35;
        Debil = false;

        Movimientos = new List<IMovimiento> { new Impactrueno(), new AtaqueRapido(), new Rayo(), new BolaVoltio() };
        Tipo = new List<ETipos> { ETipos.ELECTRICO };
    }
    
}