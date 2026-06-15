using System;
//Aquí estamos obligando a la clase Carro a usar los métodos asignados a la interfaz IVehiculo
//Sin estos métodos, el programa lanzaría error
public class Carro : IVehiculo
{
    public void Encender()
    {
        Console.WriteLine("El carro ha sido encendido.");
    }

    public void Apagar()
    {
        Console.WriteLine("El carro ha sido apagado.");
    }
}