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
		
		
	}
}