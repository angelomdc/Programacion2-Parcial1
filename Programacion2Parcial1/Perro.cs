// Clase Perro que hereda de Animal.
public class Perro : Animal
{

    // Sobrescribe el método HacerSonido para mostrar el sonido de un perro.

    public override void HacerSonido()
    {
        Console.WriteLine("Guau, guau");
    }
}