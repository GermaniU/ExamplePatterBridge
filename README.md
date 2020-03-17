# ExamplePatterBridge

# Patron Bridge
El patrón de diseño bridge se incluye en la categoría de patrón de diseño estructural

favorecer la composición sobre la herencia, cambiar la clase abstracta(Se usa una interfaz , y no una clase abstracta para las figuras).

```
# Colores
Azul
Morado
Rojo 
```
```
# Figuras 
Cuadrado
Circulo
```

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

IFigura
Cuadrado
Circulo
```

# En las clases cuadrado y circulo se recibe como dependencia la abstraccion(IColor) de la clase color.
