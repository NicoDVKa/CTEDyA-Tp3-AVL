using System;

namespace AVL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ahora si se cumplen las propiedades de los arboles AVL.

            
            //Comprobacion del metodo agreger y las rotaciones simples.
            ArbolAVL arbolAVL = new ArbolAVL(null);

            arbolAVL.agregar(50);
            arbolAVL.agregar(25);
            arbolAVL.agregar(1);
            arbolAVL.agregar(0);
            arbolAVL.agregar(-1);
            arbolAVL.agregar(-10);
            arbolAVL.agregar(-20);
            arbolAVL.agregar(75);
            arbolAVL.agregar(100);
            arbolAVL.agregar(125);
            arbolAVL.agregar(150);
            arbolAVL.agregar(175);


            //Incluye() funciona correctamente
            int dato = 2;
            Console.WriteLine("El dato {0} esta en el ab? {1}", dato, arbolAVL.incluye(dato));

            Console.Write("Preorden: ");
            arbolAVL.preorden();//Funciona
            Console.WriteLine();

            Console.WriteLine("Presione un tecla para salir");
            Console.ReadKey(true);
        }
    }
}
