using EDPilaEjercicio2;

public class Program
{
    public static void Main()
    {
        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine();

        if (EsPalindromo(palabra))
            Console.WriteLine("La palabra ES un palíndromo.");
        else
            Console.WriteLine("La palabra NO es un palíndromo.");

        Console.ReadKey();
    }

    static bool EsPalindromo(string texto)
    {
        Pila<char> pila = new Pila<char>();

        // Apilar todos los caracteres
        foreach (char c in texto)
        {
            pila.Push(c);
        }

        // Comparar mientras desapilamos
        foreach (char c in texto)
        {
            if (c != pila.Pop())
                return false;
        }

        return true;
    }
}
