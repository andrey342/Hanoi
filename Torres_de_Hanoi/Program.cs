using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Keep the console window open in debug mode.
            Console.WriteLine("Introduce I si quieres usar el algoritmo iterativo");
            Console.WriteLine("Introduce R si quieres usar el algoritmo recursivo");
            string comandoEscrito = Console.ReadLine();

            if (comandoEscrito == "I" || comandoEscrito == "R")
            {
                Console.WriteLine("Introduce el numero de discos : ");
                int numDiscos = Convert.ToInt32(Console.ReadLine());

                //Torre de Hanoi
                Hanoi hanoi = new Hanoi();

                //lista de discos
                List<Disco> Elementos = new List<Disco>();

                //pilas
                Pila ini = new Pila();
                Pila aux = new Pila();
                Pila fin = new Pila();

                //rellenar pila ini
                for (int i = numDiscos; i > 0; i--)
                {
                    ini.push(new Disco(i));
                }
                if (comandoEscrito == "I")
                { //interativo
                  //Aca empieza lo chido
                    int mov = hanoi.iterativo(numDiscos, ini, fin, aux);

                    //Formula
                    double formulaDouble = Math.Pow(2, numDiscos) - 1;
                    int formulaGucci = Convert.ToInt32(formulaDouble);

                    //Respuestas
                    Console.WriteLine("Resultado moviendo discos entre pilas: " + mov);
                    Console.WriteLine("Resultado calculado con la formula es: " + formulaGucci);
                    if (mov.Equals(formulaGucci))
                    {
                        Console.WriteLine("El resultado es CORRECTO");
                    }
                    else
                    {
                        Console.WriteLine("El resultado es INCORRECTO");
                    }


                }
                else if (comandoEscrito == "R") //recurivo
                {
                    //Aca empieza lo chido
                    int mov = hanoi.recursivo(numDiscos, ini, fin, aux);

                    //Formula
                    double formulaDouble = Math.Pow(2, numDiscos) - 1;
                    int formulaGucci = Convert.ToInt32(formulaDouble);

                    //Respuestas
                    Console.WriteLine("Resultado moviendo discos entre pilas: " + mov);
                    Console.WriteLine("Resultado calculado con la formula es: " + formulaGucci);
                    if (mov.Equals(formulaGucci))
                    {
                        Console.WriteLine("El resultado es CORRECTO");
                    }
                    else
                    {
                        Console.WriteLine("El resultado es INCORRECTO");
                    }
                }
            }
            else
            {
                Console.WriteLine(" Comando incorrecto , una I o una R");
            }
            Console.ReadKey();

        }
    }
}
