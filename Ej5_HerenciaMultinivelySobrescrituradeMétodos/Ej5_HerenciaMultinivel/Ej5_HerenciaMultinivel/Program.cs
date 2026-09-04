using Ej5_HerenciaMultinivel;

Animal animal = new Animal();
Mamifero mamifero = new Mamifero();
Perro perro = new Perro();

Console.WriteLine("Animal:");
animal.HacerSonido();

Console.WriteLine("\nMamífero:");
mamifero.HacerSonido();
mamifero.Alimentar();

Console.WriteLine("\nPerro:");
perro.HacerSonido();
perro.Alimentar();


Console.ReadKey();