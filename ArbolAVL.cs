using System;

namespace AVL
{

	public class ArbolAVL{
		
		private IComparable dato;
		private ArbolAVL hijoIzquierdo;
		private ArbolAVL hijoDerecho;
		private int altura;
		
		public ArbolAVL(IComparable dato){
			this.dato = dato;
		}
		
		public IComparable getDatoRaiz(){
			return this.dato;
		}
		
		public ArbolAVL getHijoIzquierdo(){
			return this.hijoIzquierdo;
		}
		
		public ArbolAVL getHijoDerecho(){
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolAVL hijo){
			this.hijoIzquierdo=hijo;
		}

		public void agregarHijoDerecho(ArbolAVL hijo){
			this.hijoDerecho=hijo;
		}
		
		public void eliminarHijoIzquierdo(){
			this.hijoIzquierdo=null;
		}
		
		public void eliminarHijoDerecho(){
			this.hijoDerecho=null;
		}

		//Para agregar un elemento se va a tener que chequer la altura, para ver si hay desbalanceo o no

		//Calcula la altura del arbol. Similar al retardoReenvio() del arbol binario.
		public int alturaAVL()
		{
			int alturaMaxima = 0;
			int alturaIzquierda = 0;
			int alturaDerecha = 0;
			int alturaTemporal = 0;

			if (this.getHijoIzquierdo() == null && this.getHijoDerecho() == null)
			{
				return 0;
			}

			if (this.getHijoIzquierdo() != null)
			{

				alturaTemporal += 1;
				alturaTemporal += this.getHijoIzquierdo().alturaAVL();
				if (alturaTemporal > alturaIzquierda) alturaIzquierda = alturaTemporal;
			}

			if (this.getHijoDerecho() != null)
			{
				alturaTemporal = 0;
				alturaTemporal += 1;
				alturaTemporal += this.getHijoDerecho().alturaAVL();
				if (alturaTemporal > alturaDerecha) alturaDerecha = alturaTemporal;
			}

			if (alturaIzquierda >= alturaDerecha) alturaMaxima = alturaIzquierda;
			if (alturaIzquierda < alturaDerecha) alturaMaxima = alturaDerecha;

			return alturaMaxima;
		}

		public bool hayDesbalanceo()
        {
			if (this.getHijoIzquierdo() == null && this.getHijoDerecho()==null)
            {
				return false;
            }
			else
            {
				int alturaIzquierda = 1;  
				int alturaDerecha = 1;
				
				if (this.getHijoIzquierdo() != null)
                {
					alturaIzquierda += this.getHijoIzquierdo().alturaAVL();

                }
                else
                {
					alturaIzquierda = 0;

				}

                if (this.getHijoDerecho() != null)
                {
					alturaDerecha += this.getHijoDerecho().alturaAVL();
                }
                else
                {
					alturaDerecha = 0;
				}
				
				if (alturaIzquierda>alturaDerecha)
                {
					return alturaIzquierda - alturaDerecha > 1;
                }
                else
                {
					return alturaDerecha - alturaIzquierda > 1;
                }
			}
        }
		
		public void agregar(IComparable elem) {


		}
		

		public void rotacionSimpleDerecha() {
			
		}
		
		public void rotacionSimpleIzquierda() {
		
		}
		
		public void rotacionDobleDerecha() {
		
		}
		
				
		public void rotacionDobleIzquierda() {
		
		}

		//Metodos del Arbol Binario de Busqueda
		//Metodo Incluye() del ABB
		public bool incluye(IComparable elemento)
		{
			bool verificar = false;

			if (this.dato == null)
			{
				return false;
			}
			else
			{
				if (int.Parse(elemento.ToString()) == int.Parse(this.dato.ToString()))
				{
					return true;
				}
				else
				{
					if (int.Parse(elemento.ToString()) > int.Parse(this.dato.ToString()))
					{
						if (this.getHijoDerecho() == null) return false;
						verificar = this.getHijoDerecho().incluye(elemento);

					}
					else
					{
						if (this.getHijoIzquierdo() == null) return false;
						verificar = this.getHijoIzquierdo().incluye(elemento);

					}
				}
			}

			return verificar;
		}

		//Recorridos. son los mismos que en los Arboles Binarios de Busqueda
		public void preorden()
		{
			//Primero la raiz y luego los hijos izquierdos y derechos

			Console.Write(this.getDatoRaiz() + " ");

			if (this.getHijoIzquierdo() != null)
			{
				this.getHijoIzquierdo().preorden();
			}

			if (this.getHijoDerecho() != null)
			{
				this.getHijoDerecho().preorden();
			}
		}

		public void inorden()
		{
			//Primero el hijo izquierdo luego la raiz y por ultimo el hijo derecho
			if (this.getHijoIzquierdo() != null)
			{
				this.getHijoIzquierdo().inorden();
			}

			Console.Write(this.getDatoRaiz() + " ");

			if (this.getHijoDerecho() != null)
			{
				this.getHijoDerecho().inorden();
			}
		}


		public void postorden()
		{
			//Primero los hijos, izquierdo y derecho, y luego la raiz
			if (getHijoIzquierdo() != null)
			{
				this.getHijoIzquierdo().postorden();
			}

			if (this.getHijoDerecho() != null)
			{
				this.getHijoDerecho().postorden();
			}

			Console.Write(this.getDatoRaiz() + " ");
		}

	}
}