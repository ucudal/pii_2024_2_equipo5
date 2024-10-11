using System.Collections.Generic;
using Library.Enums;

namespace Library.Logica;

public class Efectividad
{
    private static readonly Dictionary<ETipos, Dictionary<ETipos, float>> _tablaEfectividad = new()
    {
        {
            ETipos.FUEGO, new Dictionary<ETipos, float>
            {
                { ETipos.PLANTA, 2.0f },
                { ETipos.AGUA, 0.5f },
                { ETipos.ROCA, 0.5f },
                { ETipos.HIELO, 2.0f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.BICHO, 2.0f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 1.0f },
                { ETipos.VOLADOR, 1.0f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 1.0f },
                { ETipos.TIERRA, 1.0f },
                { ETipos.LUCHA, 1.0f },
            }
        },
        {
            ETipos.PLANTA, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 0.5f },
                { ETipos.AGUA, 2.0f },
                { ETipos.ROCA, 1.0f },
                { ETipos.HIELO, 1.0f },
                { ETipos.VENENO, 0.5f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.BICHO, 0.5f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 1.0f },
                { ETipos.VOLADOR, 0.5f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 1.0f },
                { ETipos.TIERRA, 1.0f },
                { ETipos.LUCHA, 1.0f },
            }
        },
        {
            ETipos.AGUA, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 2.0f },
                { ETipos.PLANTA, 0.5f },
                { ETipos.ROCA, 1.0f },
                { ETipos.HIELO, 1.0f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.BICHO, 1.0f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 1.0f },
                { ETipos.VOLADOR, 1.0f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 1.0f },
                { ETipos.TIERRA, 1.0f },
                { ETipos.LUCHA, 1.0f },
            }
        },
        {
            ETipos.LUCHA, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 1.0f },
                { ETipos.PLANTA, 1.0f },
                { ETipos.AGUA, 1.0f },
                { ETipos.BICHO, 1.0f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 1.0f },
                { ETipos.VOLADOR, 0.5f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 2.0f },
                { ETipos.FANTASMA, 0.5f },
                { ETipos.ROCA, 2.0f },
                { ETipos.TIERRA, 1.0f },
                { ETipos.LUCHA, 1.0f },
                { ETipos.HIELO, 2.0f }
            }
        },
        {
            ETipos.ROCA, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 1.0f },
                { ETipos.PLANTA, 1.0f },
                { ETipos.AGUA, 1.0f },
                { ETipos.BICHO, 1.0f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 1.0f },
                { ETipos.VOLADOR, 1.0f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 1.0f },
                { ETipos.TIERRA, 2.0f },
                { ETipos.LUCHA, 0.5f },
                { ETipos.HIELO, 1.0f }
            }
        },
        {
            ETipos.TIERRA, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 1.0f },
                { ETipos.PLANTA, 1.0f },
                { ETipos.AGUA, 1.0f },
                { ETipos.BICHO, 1.0f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 1.0f },
                { ETipos.VOLADOR, 1.0f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 1.0f },
                { ETipos.ROCA, 0.5f },
                { ETipos.TIERRA, 1.0f },
                { ETipos.LUCHA, 1.0f },
                { ETipos.HIELO, 1.0f }
            }
        },
        {
            ETipos.HIELO, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 1.0f },
                { ETipos.PLANTA, 1.0f },
                { ETipos.AGUA, 1.0f },
                { ETipos.BICHO, 1.0f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.DRAGON, 2.0f },
                { ETipos.HADA, 1.0f },
                { ETipos.VOLADOR, 1.0f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 1.0f },
                { ETipos.ROCA, 1.0f },
                { ETipos.TIERRA, 1.0f },
                { ETipos.LUCHA, 0.5f },
                { ETipos.HIELO, 1.0f }
            }
        },
        {
            ETipos.SINIESTRO, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 1.0f },
                { ETipos.PLANTA, 1.0f },
                { ETipos.AGUA, 1.0f },
                { ETipos.BICHO, 0.5f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 0.5f },
                { ETipos.LUCHA, 0.5f },
                { ETipos.VOLADOR, 1.0f },
                { ETipos.PSIQUICO, 2.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 2.0f },
                { ETipos.ROCA, 1.0f },
                { ETipos.TIERRA, 1.0f },
                { ETipos.HIELO, 1.0f }
            }
        },
        {
            ETipos.FANTASMA, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 1.0f },
                { ETipos.PLANTA, 1.0f },
                { ETipos.AGUA, 1.0f },
                { ETipos.BICHO, 1.0f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 1.0f },
                { ETipos.VOLADOR, 1.0f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 1.0f },
                { ETipos.ROCA, 1.0f },
                { ETipos.TIERRA, 1.0f },
                { ETipos.LUCHA, 1.0f },
                { ETipos.HIELO, 1.0f }
            }
        },
        {
            ETipos.BICHO, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 0.5f },
                { ETipos.PLANTA, 1.0f },
                { ETipos.AGUA, 1.0f },
                { ETipos.BICHO, 1.0f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 1.0f },
                { ETipos.VOLADOR, 0.5f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 1.0f },
                { ETipos.ROCA, 1.0f },
                { ETipos.TIERRA, 1.0f },
                { ETipos.LUCHA, 2.0f },
                { ETipos.HIELO, 1.0f }
            }
        },
        {
            ETipos.DRAGON, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 1.0f },
                { ETipos.PLANTA, 1.0f },
                { ETipos.AGUA, 1.0f },
                { ETipos.BICHO, 1.0f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.DRAGON, 2.0f },
                { ETipos.HADA, 0.5f },
                { ETipos.VOLADOR, 1.0f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 1.0f },
                { ETipos.ROCA, 1.0f },
                { ETipos.TIERRA, 1.0f },
                { ETipos.LUCHA, 1.0f },
                { ETipos.HIELO, 1.0f }
            }
        },
        {
            ETipos.HADA, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 1.0f },
                { ETipos.PLANTA, 1.0f },
                { ETipos.AGUA, 1.0f },
                { ETipos.BICHO, 1.0f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 1.0f },
                { ETipos.VOLADOR, 1.0f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 1.0f },
                { ETipos.ROCA, 1.0f },
                { ETipos.TIERRA, 1.0f },
                { ETipos.LUCHA, 2.0f },
                { ETipos.HIELO, 1.0f }
            }
        },
        {
            ETipos.PSIQUICO, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 1.0f },
                { ETipos.PLANTA, 1.0f },
                { ETipos.AGUA, 1.0f },
                { ETipos.BICHO, 1.0f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 1.0f },
                { ETipos.VOLADOR, 1.0f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 1.0f },
                { ETipos.ROCA, 1.0f },
                { ETipos.TIERRA, 1.0f },
                { ETipos.LUCHA, 2.0f },
                { ETipos.HIELO, 1.0f }
            }
        },
        {
            ETipos.ELECTRICO, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 1.0f },
                { ETipos.PLANTA, 1.0f },
                { ETipos.AGUA, 2.0f },
                { ETipos.BICHO, 1.0f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 1.0f },
                { ETipos.VOLADOR, 2.0f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 1.0f },
                { ETipos.ROCA, 1.0f },
                { ETipos.TIERRA, 0.5f },
                { ETipos.HIELO, 1.0f }
            }
        },
        {
            ETipos.VENENO, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 1.0f },
                { ETipos.PLANTA, 2.0f },
                { ETipos.AGUA, 1.0f },
                { ETipos.BICHO, 1.0f },
                { ETipos.VENENO, 0.5f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 2.0f },
                { ETipos.VOLADOR, 1.0f },
                { ETipos.PSIQUICO, 0.5f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 1.0f },
                { ETipos.ROCA, 1.0f },
                { ETipos.TIERRA, 0.5f },
                { ETipos.HIELO, 1.0f }
            }
        },
        {
            ETipos.NORMAL, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 1.0f },
                { ETipos.PLANTA, 1.0f },
                { ETipos.AGUA, 1.0f },
                { ETipos.BICHO, 1.0f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 1.0f },
                { ETipos.VOLADOR, 1.0f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 0.0f }, // Sin efecto
                { ETipos.ROCA, 0.5f },
                { ETipos.TIERRA, 1.0f },
                { ETipos.LUCHA, 0.5f },
                { ETipos.HIELO, 1.0f }
            }
        },
        {
            ETipos.VOLADOR, new Dictionary<ETipos, float>
            {
                { ETipos.FUEGO, 1.0f },
                { ETipos.PLANTA, 1.0f },
                { ETipos.AGUA, 1.0f },
                { ETipos.BICHO, 2.0f },
                { ETipos.VENENO, 1.0f },
                { ETipos.NORMAL, 1.0f },
                { ETipos.DRAGON, 1.0f },
                { ETipos.HADA, 1.0f },
                { ETipos.VOLADOR, 1.0f },
                { ETipos.PSIQUICO, 1.0f },
                { ETipos.SINIESTRO, 1.0f },
                { ETipos.FANTASMA, 1.0f },
                { ETipos.ROCA, 0.5f },
                { ETipos.TIERRA, 1.0f },
                { ETipos.HIELO, 1.0f },
                { ETipos.LUCHA, 2.0f }
            }
        },
    };

    public static float ObtenerEfectividad(ETipos tipoAtaque, ETipos tipoDefensor)
    {
        if (_tablaEfectividad.TryGetValue(tipoAtaque, out var efectividades))
        {
            if (efectividades.TryGetValue(tipoDefensor, out var efectividad))
            {
                return efectividad; // Devuelve la efectividad correspondiente
            }
        }

        return 1.0f; // Retorna 1.0f si no se encuentra la efectividad
    }
}