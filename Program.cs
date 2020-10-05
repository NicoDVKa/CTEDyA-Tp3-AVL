using System;

namespace AVL
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolAVL arbolAVL = new ArbolAVL(1);
            ArbolAVL hijoIzquierdo = new ArbolAVL(2);
            ArbolAVL hijoDerecho = new ArbolAVL(3);
            ArbolAVL hijoDelIzquierdo = new ArbolAVL(4);
            
            arbolAVL.agregarHijoIzquierdo(hijoIzquierdo);
            arbolAVL.agregarHijoDerecho(hijoDerecho);

            hijoIzquierdo.agregarHijoIzquierdo(hijoDelIzquierdo);

            hijoDelIzquierdo.agregarHijoIzquierdo(new ArbolAVL(5));
            hijoDelIzquierdo.agregarHijoDerecho(new ArbolAVL(6));

            //Todavia no se cumplen las propiedades de los arboles AVL.

            //Comprobacion de los metodos de los ABB

            Console.Write("Preorden: ");
            arbolAVL.preorden();//Funciona
            Console.WriteLine();
            Console.Write("Inorden: ");
            arbolAVL.inorden();//Funciona
            Console.WriteLine();
            Console.Write("Postorden: ");
            arbolAVL.postorden();//Funciona
            Console.WriteLine();
            
            
            //Incluye() todavia no funciona correctamente ya que no se cumple la propiedad de orden
            int dato = 2;
            Console.WriteLine("El dato {0} esta en el ab? {1}", dato, arbolAVL.incluye(dato));


            Console.WriteLine("Presione un tecla para salir");
            Console.ReadKey(true);
        }
    }
}
