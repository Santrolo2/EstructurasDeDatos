using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDPilaEjercicio1
{
    public class Program
    {
        public static void Main()
        { 
            Console.Write("Ingresa una operación: ");
            string operacion = Console.ReadLine();

            if (EsOperacionValida(operacion))
                Console.WriteLine("La operación está bien formada.");
            else
                Console.WriteLine("La operación tiene errores.");

            Console.ReadKey();
        }

        static bool EsOperacionValida(string expresion)
        {
            Pila<char> pila = new Pila<char>();

            foreach (char c in expresion)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    pila.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (pila.EstaVacia()) return false;

                    char apertura = pila.Pop();

                    if ((apertura == '(' && c != ')') ||
                        (apertura == '[' && c != ']') ||
                        (apertura == '{' && c != '}'))
                    {
                        return false;
                    }
                }
            }

            return pila.EstaVacia();
        }
    }
}
