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

            arbolAVL.agregar(5);
            arbolAVL.agregar(3);
            arbolAVL.agregar(14);
            arbolAVL.agregar(8);
            arbolAVL.agregar(15);
            arbolAVL.agregar(10);
            arbolAVL.agregar(4);
            arbolAVL.agregar(11);
            arbolAVL.agregar(12);
            arbolAVL.agregar(13);

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
