# Estructuras de Datos

Las **estructuras de datos** son formas organizadas de almacenar y administrar información en la memoria de un computador, permitiendo realizar operaciones de manera eficiente. Su objetivo principal es optimizar el acceso, la modificación y la manipulación de los datos.

---

## Clasificación General

Las estructuras de datos se dividen en dos grandes grupos:

### 1. **Estructuras de Datos Simples**
Son aquellas que almacenan un solo tipo de dato por elemento.
- **Ejemplos:** enteros, caracteres, reales, booleanos.

### 2. **Estructuras de Datos Compuestas**
Agrupan múltiples valores o elementos.
- **Ejemplos:** arreglos, registros, listas, pilas, colas, árboles y grafos.

---

## Conceptos Fundamentales

- **Dato:** Unidad mínima de información.
- **Elemento:** Conjunto de datos que representan una entidad.
- **Campo:** Subdivisión de un elemento.
- **Registro:** Conjunto de campos relacionados.
- **Estructura:** Organización lógica de los datos.

---

## Tipos de Estructuras de Datos

| Tipo de Estructura | Descripción | Ejemplo de Uso |
|--------------------|--------------|----------------|
| **Lineales** | Los elementos se almacenan uno tras otro. | Listas, Pilas, Colas |
| **No Lineales** | Los elementos se organizan jerárquicamente o en redes. | Árboles, Grafos |
| **Estáticas** | Tienen tamaño fijo en memoria. | Arreglos |
| **Dinámicas** | Pueden crecer o reducirse en tiempo de ejecución. | Listas enlazadas |

---

# Pilas

## Definición
Una **pila** es una estructura de datos **lineal y dinámica** que sigue el principio **LIFO** (*Last In, First Out*), es decir, el último elemento en entrar es el primero que sale

## Operaciones Principales

| Operación | Descripción |
|------------|--------------|
| **Push** | Inserta un elemento en la parte superior (tope) de la pila. |
| **Pop** | Elimina el elemento superior de la pila. |
| **Peek / Top** | Consulta el valor del elemento superior sin eliminarlo. |
| **VerificarVacio** | Verifica si la pila está vacía. |



# Filas

## Definición
Una **cola** es una estructura **lineal** que sigue el principio **FIFO** (*First In, First Out*), donde el primer elemento en entrar es el primero en salir.

## Operaciones Principales

| Operación | Descripción |
|------------|--------------|
| **Enqueue** | Inserta un elemento al final de la cola. |
| **Dequeue** | Elimina el elemento al frente de la cola. |
| **Front / Peek** | Devuelve el elemento al frente sin eliminarlo. |
| **EstaVacia** | Verifica si la cola está vacía. |




# Listas

## Definición
Una **lista** es una colección **ordenada** de elementos, en la que cada elemento conoce su sucesor (y en algunos casos, su predecesor). A diferencia de los arreglos, las listas pueden crecer o reducirse dinámicamente.

## Tipos de Listas

| Tipo | Características |
|------|------------------|
| **Lista Simplemente Enlazada** | Cada nodo tiene un dato y un enlace al siguiente nodo. |
| **Lista Doblemente Enlazada** | Cada nodo tiene enlaces al nodo anterior y al siguiente. |
| **Lista Circular** | El último nodo apunta al primero, formando un ciclo. |

## Operaciones Principales

| Operación | Descripción |
|------------|--------------|
| **Insertar** | Agrega un elemento en la lista (inicio, medio o fin). |
| **Eliminar** | Suprime un elemento de la lista. |
| **Buscar** | Localiza un nodo según su valor. |
| **Recorrer** | Permite visitar cada nodo de la lista. |



