using arbolsimple.clases.ArbolBinario;
using System;
using System.Collections;

namespace arbolsimple
{
    class Program
    {

        static void Main(string[] args)
        {
            try {

                ArbolBinario arbol;

                Nodo a1, a2, a;
                Stack pila = new Stack();
                a1 = ArbolBinario.nuevoArbol(null, "Maria", null);
                a2 = ArbolBinario.nuevoArbol(null, "Deyber", null);
                a = ArbolBinario.nuevoArbol(a1, "Jose", a2);
                pila.Push(a);//apilar
                a1 = ArbolBinario.nuevoArbol(null, "Andrea", null);
                a2 = ArbolBinario.nuevoArbol(null, "Abel", null);
                a = ArbolBinario.nuevoArbol(a1, "Monica", a2);
                pila.Push(a);//apilar

                a2 = (Nodo)pila.Pop();
                a1 = (Nodo)pila.Pop();

                a = ArbolBinario.nuevoArbol(a1, "Hector", a2);
                arbol = new ArbolBinario(a);
                int pausa;
                pausa = 0;




            }
            catch (Exception ex)

            {
                Console.WriteLine("ups hubo un error" + ex.Message);
            }


        }
    }
}
