# ExamplePatterBridge
Example :https://dotnettutorials.net/lesson/bridge-design-pattern/

Decorator Design Pattern in C#
The Bridge Design Pattern falls under the category of Structural Design Pattern.

favor composition over inheritance, change abstract class, interface abstraction

Colores 
Azul
Morado
Rojo 

Figuras 
Cuadrado
Circulo

# Sin el uso del patron bridge se tendria que crear  las siguientes clases (3 * 2) = 6

```
IFiguraConColor  --> Interface
CuadradoAzul
CuadradoRojo
CuadradoMorado

CirculoAzul
CirculoRojo
CirculoMorado
```

# Con el patron brige (3 +2 ) = 5
```
IColor --> Interface
Morado
Azul
Rojo
```

```
IFigura
Cuadrado
Circulo
```

# En las clases cuadrado y circulo se recibe como dependencia la abstraccion(IColor) de la clase color.
