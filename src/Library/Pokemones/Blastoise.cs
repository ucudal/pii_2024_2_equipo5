using System;
using System.Collections.Generic;
using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Agua;
using Library.Movimientos.Normal;

namespace Library.Pokemones;

public class Blastoise : Pokemon
{


    public Blastoise()
    {
        Nombre = "Blastoise";

        SaludTotal = 135;
        SaludActual = SaludTotal;

        ValorAtaque = 55;
        ValorDefensa = 45;
        ValorAtaqueEspecial = 60;
        ValorDefensaEspecial = 50;
        Debil = false;

        Movimientos = new List<IMovimiento> { new Hidrobomba(), new Hidropulso(), new Burbuja(), new Placaje() };
        Tipo = new List<ETipos> { ETipos.AGUA };
    }


}