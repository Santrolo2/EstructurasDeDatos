using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDPilaEjercicio1
{
    internal class Pila<T>
    {
        private Nodo nodoAncla;
        private Nodo nodoTrabajo;

        public Pila()
        {
            nodoAncla = new Nodo(); // ancla como cabeza vacía
        }

        // Clase interna privada
        private class Nodo
        {
            public T Valor { get; set; }
            public Nodo Siguiente { get; set; }
        }

        public void Push(T dato)
        {
            Nodo nuevoNodo = new Nodo
            {
                Valor = dato,
                Siguiente = nodoAncla.Siguiente
            };

            nodoAncla.Siguiente = nuevoNodo;
        }

        public T Pop()
        {
            if (nodoAncla.Siguiente == null)
                throw new InvalidOperationException("La pila está vacía. No se puede retirar ningún elemento.");

            nodoTrabajo = nodoAncla.Siguiente;
            T valor = nodoTrabajo.Valor;

            nodoAncla.Siguiente = nodoTrabajo.Siguiente;
            nodoTrabajo.Siguiente = null; // desconecta el nodo

            return valor;
        }

        public T Peek()
        {
            if (nodoAncla.Siguiente == null)
                throw new InvalidOperationException("La pila está vacía. No se puede ver ningún elemento.");

            return nodoAncla.Siguiente.Valor;
        }

        public bool EstaVacia()
        {
            return nodoAncla.Siguiente == null;
        }
    }
}
