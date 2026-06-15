using System;
//Aquí estamos obligando a la clase Carro a usar los métodos asignados a la interfaz IVehiculo
//Sin estos métodos, el programa lanzaría error
public class Motocicleta : IVehiculo
{
    public void Encender()
    {
        Console.WriteLine("La motocicleta ha sido encendida.");
    }

    public void Apagar()
    {
        Console.WriteLine("La motocicleta ha sido apagada.");
    }
}