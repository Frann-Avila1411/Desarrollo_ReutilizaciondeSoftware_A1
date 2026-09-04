# Ejercicio 1: Implementación de Abstracción de Datos

## Planteamiento
Crea una clase CuentaBancaria que represente una cuenta bancaria. Utiliza abstracción de datos para ocultar el detalle de la implementación del saldo y solo permite el acceso a través de los métodos públicos. Los métodos deben permitir realizar operaciones como depositar, retirar y consultar el saldo.

## Desarrollo
Se creó la clase `CuentaBancaria` utilizando un atributo privado `saldo` para ocultar los detalles internos. Se implementaron los métodos públicos `Depositar(decimal monto)`, `Retirar(decimal monto)` y `ObtenerSaldo()`. Para asegurar la integridad de los datos, se agregaron validaciones dentro de los métodos de depósito y retiro, comprobando que los montos ingresados sean positivos y que exista saldo suficiente antes de efectuar un retiro.