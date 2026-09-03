# Ejercicio 3: Herencia Simple

## Planteamiento
Crea una clase base Vehiculo que tenga los métodos Arrancar() y Detener(). Luego, crea una clase derivada Coche que herede de Vehiculo y añada un método Conducir(). Asegúrate de que el Coche pueda usar los métodos heredados de Vehiculo y su propio método Conducir().

## Desarrollo
Se construyó una clase base llamada `Vehiculo` que contiene la lógica general en los métodos `Arrancar()` y `Detener()`. Posteriormente, se creó la clase `Coche` aplicando herencia simple mediante la sintaxis `class Coche : Vehiculo`. Dentro de esta clase derivada, se añadió el método específico `Conducir()`. Finalmente, en la clase `Program`, se instanció un objeto de tipo `Coche` para demostrar que este puede ejecutar tanto los métodos heredados de la clase padre como su propio método de manera secuencial.