using System.Collections;
using UnityEngine;

public class QueuesYStacks : MonoBehaviour
{
  // STACK
  /*
   *  LIFO - LAST IN, FIRST OUT. ULTIMO EN ENTRAR, PRIMERO EN SALIR, COMO EN UN MAZO DE CARTAS
   *  new Stack(); - using System.Collections;
   *
   *    .Push() añade cualquier tipo de dato
   *    .Pop() devuelve el ultimo valor, y lo elimina del stack
   *    .Peek() devuelve el ultimo valor, pero no lo borra
   *
   *    Usos: Mazo de cartas, volver en el tiempo, deshacer acciones, call stack?
   */
  
  // QUEUE
  /*
   *    FIFO - FIRST IN FIRST OUT, PRIMERO EN ENTRAR, PRIMERO EN SALIR, COMO UNA FILA DEL SUPER
   *    new Queue(); - using System.Collections;
   *
   *    .Enqueue() añade un elemento a la cola
   *    .Dequeue() devuelve y elemina el primer elemento de la cola
   *    .Peek() devuelve el primer elemento de la cola
   *
   *    Usos: una fila, que un objeto repita las acciones de otro
   */
    Stack pila = new Stack();
    Queue fila =  new Queue();
    
}
