// Clase Gato que hereda de Animal.


public class Gato : Animal
{

    // Sobrescribe el método HacerSonido para mostrar el sonido de un gato.

    public override void HacerSonido()
    {
        Console.WriteLine("Miau");
    }
}