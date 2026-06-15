// Clase base Animal
// Contiene un método que podrá ser sobrescrito por las clases hijas.
public class Animal
{
    // Método virtual que permite ser modificado por las clases derivadas.

    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}