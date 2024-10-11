## Decisiones de diseño

### Con respecto a los tipos de Pokemon
En este sentido fue la primera decisión del grupo escribir interfaces vacías para cada tipo y asignarlas a cada Pokemon en vistas de calcular la efectividad de la siguiente manera:

```csharp
// TODO ESTO ES HORRIBLE Y ESTÁ MAL 
if (ataque is IFuego && defensor is IAgua)
        {
            return 0.5; // Fuego es menos efectivo contra agua
        }
        
        if (ataque is IFuego && defensor is IElectrico)
        {
            return 1.25; // Fuego es neutral contra eléctrico
        }

        if (ataque is IElectrico && defensor is IAgua)
        {
            return 2.0; // Eléctrico es muy efectivo contra agua
        }
```
Esta implementación es terriblemente ineficiente.

Avanzando con el proyecto se generó un consenso acerca de la inconveniencia de esta implementación. Las desventajas presentadas fueron:

- El cálculo de la efectividad visto más arriba no permite calcular la efectividad de múltiples tipos con respecto a otros.
- La cantidad de tipos hubiera requerido de una cantidad excesiva de interfaces.
- Es mucho menos extensible
- Hubieran sido necesarias demasiadas condicionales para tratar con la relación de efectividad entre cada tipo.

Es así que avanzamos hacia la utilización de **Enums** para representar los tipos. El uso de un diccionario de Enums sirvió para calcular la efectividad de manera muy simple como puede observarse en la clase Efectividad. Esto permite agregar varios tipos a los pokemones como una lista de Tipos.

### Interfaces

Decidimos crear una clase para cada Pokemon porque en futuras instancias podría ser posible agregar comportamientos específicos a cada uno de ellos y porque el uso de una interfaz IPokemon nos permite tratar con cada pokemon de forma genérica de una manera más razonable.

Del mismo modo creamos una clase para cada ataque haciendo uso de una interfaz IMovimiento por la iguales razones. 

### La clase Batalla y Entrenador

En esta clase procuramos incluir como única responsabilidad la de gestionar la batalla entre los dos entrenadores, cumpliendo con el principio SRP. 

Esta se encarga de atacar debido a que es la clase experta en cuanto a que conoce a los dos entrenadores, permite la selección de pokemones porque es la única que cuenta con la lista completa de pokemones, etc.

Creemos que cumple con el principio de inversión de dependencias **(DIP)** porque Batalla depende de abstracciones como IMovimiento, IPokemon. Es decir que no depende de implementaciones específicas, sino de abstracciones. 

Esto mismo podemos decirlo de la clase Entrenador, que en este contexto hace que la clase sea fácil de modificar o reutilizar con diferentes implementaciones de Pokemon y Movimiento, sin cambiar la lógica de la clase Entrenador.
