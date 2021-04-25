using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            Disco mover = new Disco(0); //var donde almacenamos los discos que vamos a mover

            //si en la pila a hay discos 
            if (a.isEmpty().Equals(false))
            {
                if (b.isEmpty().Equals(true))
                { //si la pila b esta vacia
                    mover = a.pop(); //get y borrar el ultimo disco de la pila
                    b.push(mover); //mover a la pila b
                }
                else // si en la pila b hay discos
                {
                    if (a.Top < b.Top) //si el ultimo disco de a es mas pequenyo que el disco de b.
                    {
                        mover = a.pop();//get y borrar el ultimo disco de la pila
                        b.push(mover);//mover a la pila b
                    }
                    else
                    {
                        mover = b.pop();//get y borrar el ultimo disco de la pila b
                        a.push(mover);//mover b la pila a
                    }
                }
            }
            else if (b.isEmpty().Equals(false))
            {
                if (a.isEmpty().Equals(true))
                {
                    mover = b.pop(); //get y borrar el ultimo disco de la pila
                    a.push(mover); //mover a la pila a
                }
                else
                { //si en la pila a hay discos

                    if (b.Top < a.Top) //comprobamos si podemos mover el disco
                    {
                        mover = b.pop();//get y borrar el ultimo disco de la pila
                        a.push(mover);//mover b la pila a
                    }
                    else
                    {
                        mover = a.pop();//get y borrar el ultimo disco de la pila b
                        b.push(mover);//mover a la pila b
                    }
                }
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
