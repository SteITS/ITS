package demo;

import java.util.ArrayList;

import javax.swing.plaf.synth.SynthOptionPaneUI;

import model.Figura;
import model.Punto;
import model.Quadrato;
import model.Rettangolo;
import model.Segmento;
import model.Triangolo;

public class ProvaGeometria {

	public static void main(String[] args) {
		
		System.out.println("Programma Geometria Piana");
		
		Punto a = new Punto (3,2);
		Punto b = new Punto (7,2);
		Punto c = new Punto (3,5);
		
		Segmento ab = new Segmento(a,b);
		Segmento ac = new Segmento(a,c);
		Segmento bc = new Segmento(b,c);
		
		Figura r = new Rettangolo(ab, ac);
		System.out.println(r);
		
		Figura q = new Quadrato(ab);
		System.out.println(q);
		
		Figura t = new Triangolo(a, b, c);
		System.out.println(t);
		
		ArrayList<Figura> figure = new ArrayList<>();
		
		figure.add(t);
		figure.add(r);
		figure.add(q);
		
		for(Figura figura : figure) {
			if(figura instanceof Quadrato) {
				System.out.println("è un quadrato!!!");
				((Quadrato)figura).area();
			}
			System.out.println(figura);
		}
//		System.out.println(ab);
//		System.out.println(ac);
//		System.out.println(bc);
		
		
//		System.out.println("Il valore di x: " + a.getX());
//		System.out.println("Il valore di y: " + a.getY());
//		a.setY(7);
//		System.out.println("Il valore di y: " + a.getY());
//		System.out.println(a);
	}

}
