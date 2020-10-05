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
            hijoIzquierdo.agregarHijoDerecho(new ArbolAVL(9));

            hijoDelIzquierdo.agregarHijoIzquierdo(new ArbolAVL(5));
            hijoDelIzquierdo.agregarHijoDerecho(new ArbolAVL(6));

           hijoDerecho.agregarHijoDerecho(new ArbolAVL(7));

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

            //Comprobacion del metodo altura()
            Console.WriteLine("La altura del arbol AVL es de: {0}",arbolAVL.alturaAVL());

            Console.WriteLine("La altura del subArbol Izquierdo es de: {0}", hijoIzquierdo.alturaAVL());

            Console.WriteLine("La altura del subArbol Derecho es de: {0}", hijoDerecho.alturaAVL());

           //Comprobacion del metodo hayDesbalanceo()
            Console.WriteLine("Hay desbanlaceo en el arbol AVL? {0}",arbolAVL.hayDesbalanceo());
            
            Console.WriteLine("Hay desbanlaceo en el subArbol Izquierdo? {0}", hijoIzquierdo.hayDesbalanceo());

            Console.WriteLine("Hay desbanlaceo en el subArbol Derecho? {0}", hijoDerecho.hayDesbalanceo());

            
            Console.WriteLine("Presione un tecla para salir");
            Console.ReadKey(true);
        }
    }
}
