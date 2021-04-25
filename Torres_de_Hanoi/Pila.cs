using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; } //getter & setter
        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        public int Top { get; set; }
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */
        public List<Disco> Elementos { get; set; } //getter & setter

        /* TODO: Implementar métodos */

        public Pila()
        { //constructor por defecto

            Elementos = new List<Disco>();
            Size = 0;
            Top = 0;
        }

        public Pila(List<Disco> elementos)
        { //constructor con parametros

            Elementos = elementos; //guardo la lista en Elementos
            Size = elementos.Count; //tamanyo de la lista
            Top = elementos.Last().Tamanyo; //guardo el tamanyo del ultimo disco en Top
        }

        public void push(Disco d)
        {
            Elementos.Add(d); // add disco a la pila
            Size++;// aumenta el tamanyo
            Top = d.Tamanyo; //se guarda el tamanyo del ultimo disco introducido
        }

        public Disco pop()
        {
            Disco extraer = Elementos.Last(); //guardo el ultimo disco de la pila
            Elementos.Remove(extraer); //borro el ultimo disco de la pila
            Size--; // se reduce el size por eliminar el disco
            if (isEmpty().Equals(false))
            { // la lista no esta vacia
                Disco newUltimo = Elementos.Last();//se guarda el nuevo ultimo elemento
                Top = newUltimo.Tamanyo; //se guarda en Top el tamanyo del nuevo ultimo elemento
            }
            else //si la lista esta vacia
            {
                Top = 0; //en top no hay nada
            }
            return extraer; //se devuelve el disco que se ha eliminado
        }

        public bool isEmpty()
        {
            if (Elementos.Count.Equals(0))
            { //si la pila esta vacia
                return true; //devuelve verdadero
            }
            else
            {//si no
                return false;// devuelve falso 
            }

        }

    }
}
