using System;
using System.Collections.Generic;
using Library.Enums;
using Library.Interfaces;

namespace Library.ClasesBase
{
    public abstract class Pokemon : IPokemon
    {
        public string Nombre { get; set; }
        public int SaludTotal { get; set; }
        public int SaludActual { get; set; }
        public int ValorAtaque { get; set; }
        public int ValorDefensa { get; set; }
        public int ValorAtaqueEspecial { get; set; }
        public int ValorDefensaEspecial { get; set; }
        public List<Movimiento> Movimientos { get; set; }
        public List<ETipos> Tipo { get; set; }
        public bool Debil { get; set; }

        public void RecibirDanio(int danio)
        {
            SaludActual = Math.Max(SaludActual - danio, 0);
            if (SaludActual <= 0)
            {
                Debil = true;
            }
        }

        public void UsarMovimiento(IMovimiento movimiento)
        {
            IMovimiento MovimientoUtilizado = Movimientos.Find(f => f == movimiento);

            if (MovimientoUtilizado != null)
            {
                MovimientoUtilizado.CurrentPP -= 1; // Restamos 1 PP, ya que al usarlo se gasta.
            }
        }
    }
}