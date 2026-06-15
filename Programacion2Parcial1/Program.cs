//Proyecto Programacion 2 - Parcial 1

using System;
using System.Collections.Generic;

//Clase Persona
// Esta clase le da nombre y edad a una persona

public class Persona
{
    //Aqui se almacena el nombre
    public string Nombre { get; set; }

    //Aqui se almacena la edad
    public int Edad { get; set; }

    //Ahora se crea el constructor de la clase Persona
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    } 

    //Aqui se crea el Metodo de la clase Persona
    public void Presentacion()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //1.Sintaxis basica y variables

        Console.WriteLine("/////////////////////////////////////////////////");
        Console.WriteLine(" Les damos la bienvenida a nuestro proyecto parcial 1 ");
        Console.WriteLine(" Integrantes: Angel Morillo, Eddy Valdez, Alberto Rosario ");
        Console.WriteLine("/////////////////////////////////////////////////");
        Console.WriteLine();

        //Aqui declaramos los tipos de variables
        int integrantes = 3;
        string materia = "Programacion 2";
        double calificacion = 100.0;
        bool proyectogrupal = true;

        //Aqui se muestran las variables en pantalla
        Console.WriteLine("Informacion del proyecto");
        Console.WriteLine($"Materia: {materia}");
        Console.WriteLine($"Cantidad de integrantes: {integrantes}");
        Console.WriteLine($"Calificacion minima: {calificacion}");
        Console.WriteLine($"Este es un proyecto grupal?: {proyectogrupal}");
        Console.WriteLine();

        //2.Estructuras de control

        Console.WriteLine("////////////////////////////////////////////////////");
        Console.WriteLine(" Estructuras de control ");
        Console.WriteLine("////////////////////////////////////////////////////");
        Console.WriteLine();

        //Aqui se solicita un numero
        Console.WriteLine("Ingrese un numero:");
        int numero = Convert.ToInt32(Console.ReadLine());

        //Aqui se verifica si el numero es par o impar
         if (numero % 2 == 0)
        {
            Console.WriteLine($"El número {numero} es par.");
        }
        else
        {
            Console.WriteLine($"El número {numero} es impar.");
        }

        Console.WriteLine();

        //Aqui se imprimen los numeros del 1 al 10
        Console.WriteLine("Numeros del 1 al 10: ");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();

        //3. Clases y objetos

        Console.WriteLine("////////////////////////////////////////////////////");
        Console.WriteLine(" Clases y objetos ");
        Console.WriteLine("////////////////////////////////////////////////////");
        Console.WriteLine();

        //Aqui se crean los 3 objetos de persona con los integrantes del grupo
        Persona persona1 = new Persona("Angel", 24);
        Persona persona2 = new Persona("Eddy", 29);
        Persona persona3 = new Persona("Alberto", 19);

        persona1.Presentacion();
        persona2.Presentacion();
        persona3.Presentacion();

        Console.WriteLine();
    }

    //4. Herencia

    Console.WriteLine("////////////////////////////////////////////////////");
Console.WriteLine(" Herencia ");
Console.WriteLine("////////////////////////////////////////////////////");
Console.WriteLine();

// Se crean objetos de las clases Perro y Gato.

Perro perro = new Perro();
    Gato gato = new Gato();

    // Se llama al método HacerSonido de cada objeto.


    perro.HacerSonido();
gato.HacerSonido();

Console.WriteLine();

//5. Polimorfismo

Console.WriteLine("////////////////////////////////////////////////////");
Console.WriteLine(" Polimorfismo ");
Console.WriteLine("////////////////////////////////////////////////////");
Console.WriteLine();
// Lista que almacena objetos de diferentes clases derivadas de Animal.

List<Animal> animales = new List<Animal>();

// Se agregan objetos Perro y Gato a la lista.


    animales.Add(new Perro());
animales.Add(new Gato());

// Se recorre la lista y se ejecuta el método correspondiente a cada objeto.
// Esto demuestra el uso del polimorfismo.

foreach (Animal animal in animales)
{
    animal.HacerSonido();
}

Console.WriteLine();
}



