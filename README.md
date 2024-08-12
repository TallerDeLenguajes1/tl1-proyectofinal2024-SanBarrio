# THE DUNGEON

**Trata sobre un juego de rol, basado en el mundo de Calabozos y Dragones (D&D, por sus siglas en ingles). En el que puedes escoger a un aventurero para adentrarte a una mazmorra en la Ciudad Rivenshire y vencer a su jefe final, se utiliza la probabilidad y su combate es por turnos automaticos**

---

## Jugabilidad
*El juego consiste en 5 niveles y un nivel final, en cada nivel debes escoger una de 3 puertas que te llevará a cierta sala, las cuales 2 de ellas son malas y una es buena:.*

**Sala buena:** Contiene un cofre con una recompensa, dicha recompesa es mejorar alguna estadistica (vida, fuerza, armadura).

**Sala mala:** Contiene una batalla contra un enemigo aleatorio, al finalizar dicho combate el aventurero recibe una recompensa parecida a la del cofre, pero con una opcion mas (curarse por completo). Las dificultades para cada enemigo son:

**Ejambre de insectos:** Dificultad (Baja). 

**Araña Gigante:** Dificultad (Media). 

Para el nivel final te enfrentas contra el **Lich** Dificultad (Alta).

---
## Información Adicional

*Los graficos del juego están inspirados en el estilo de diseño del juego **Stone Story: Game**, para mas información de dicho juego, consulte su sitio web [aqui](https://stonestoryrpg.com/)*  

*Para el tema de cambiar fotogramas entre los sprites sin utilizar ``` Console.Clear() ```, debido a que esto generaba un parpadeo entre cambio de sprites, lo que se hizo fue "resetear" los valores por un muro de espacios en blanco, que tuviera igual o mayor tamaño que del sprite. Asi logrando un cambio de sprite mas fluido. 
```

    //Crea el sprite
    WriteAt("*", x + 3, y - 3, ConsoleColor.White);
    WriteAt("O |", x + 1, y - 2, ConsoleColor.White);
    WriteAt("/|¯¯", x, y - 1, ConsoleColor.White);
    WriteAt("/ \\", x, y, ConsoleColor.White);
    
    //Cambio el sprite por un muro de espacios en blanco
    WriteAt("                    ", x - 4, y - 4, ConsoleColor.White);
    WriteAt("                    ", x - 4, y - 3, ConsoleColor.White);
    WriteAt("                    ", x - 4, y - 2, ConsoleColor.White);
    WriteAt("                    ", x - 4, y - 1, ConsoleColor.White);
    WriteAt("                    ", x - 4, y, ConsoleColor.White);

    //Agrego el siguiente sprite y así hasta que termine de realizar la animacion.
    WriteAt("*", x + 1, y - 4, ConsoleColor.White);
    WriteAt("\\", x + 2, y - 3, ConsoleColor.White);
    WriteAt("O/", x + 1, y - 2, ConsoleColor.White);
    WriteAt("/|", x, y - 1, ConsoleColor.White);
    WriteAt("/ \\", x, y, ConsoleColor.White);

```

---

## Requisitos:

*1. Sistema Operativo Windows (para que todo funcione correctamente). Este proyecto no es compatible con linux ya que usa ciertas funciones que no son interpretadas en dicho sistema operativo.*  
*2. Tener instalado .Net versión 8.0 en su PC. Si no lo tiene descargado puede hacerlo desde [aqui](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)*  
*3. Clonar el repositorio actual desde una terminal de VisualStudioCode o desde la Bash de Git con el siguiente comando:*  
``` bash
git clone https://github.com/TallerDeLenguajes1/tl1-proyectofinal2024-SanBarrio
``` 
*De esta forma se descargará todo el juego en una carpeta con el nombre tl1-proyectofinal2024-SanBarrio*  

*Ahora te dirigiras a la carpeta ..\bin\Debug\net8.0 y ejecutaras el archivo 'Proyecto-Final.exe'*
---
(En caso de que no exista dicho ejecutable)
*Luego debe abrir dicha carpeta con VisualStudioCode, abrir una nueva terminal y ejecutar el siguiente comando:*  
``` bash
    dotnet build
```


