using System;
using System.Collections.Generic;
using System.Text;

namespace arbolsimple.clases.ArbolBinario
{
    class Nodo
    {
        protected object dato;
        protected Nodo izquierda; //aca estamos creando el nodo 
        protected Nodo derecha; 


        public Nodo (object valor)
        {
            dato = valor;      // estos son constructores 
            izquierda = null;
            derecha = null;             // estamos mandado el valor 
        }

        public Nodo (Nodo ramaIzquierda, object valor, Nodo ramaDerecha)
        {
            dato = valor;           //estos son constructures 
            izquierda = ramaIzquierda; // estamos mandado valor a las ramas 
            derecha = ramaDerecha;
        }


        public object valorNodo()
        {
            return dato;
        }

        public Nodo subarbolDerecho()
        {
            return derecha;
        }

        public Nodo subarbolIzquierda()
        {
            return izquierda;
        }


        public void nuevoValor(object nv)
        {
            dato = nv;
        }

        public void ramaIzquierda (Nodo n)
        {
            izquierda = n;
        }

        public void ramaDerecha (Nodo n)
        {
            derecha = n;
        }






    }

}
