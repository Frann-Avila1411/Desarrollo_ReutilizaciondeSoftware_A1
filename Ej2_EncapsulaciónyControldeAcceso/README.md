# Ejercicio 2: Encapsulación y Control de Acceso

## Planteamiento
Crea una clase Empleado que tenga dos atributos privados: nombre y edad. Implementa encapsulación para acceder a estos atributos a través de propiedades. Asegúrate de que la edad solo pueda ser modificada a través de un valor válido (mayor que 0 y menor que 100).

## Desarrollo
Se definió la clase `Empleado` con los atributos privados `nombre` (inicializado para evitar advertencias de valores nulos) y `edad`. Se aplicó encapsulación exponiendo estos atributos mediante las propiedades públicas `Nombre` y `Edad`. En el bloque `set` de la propiedad `Edad`, se integró una validación condicional que verifica que el valor ingresado sea mayor a 0 y menor a 100, rechazando cualquier asignación fuera de este rango mediante un mensaje de consola.