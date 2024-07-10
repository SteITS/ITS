package com.stanescu.interfacce;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.List;

public class InterfacceDemo {
	public static void main(String[] args) {
	//	ProvaZero pz = new ProvaZero();
	//	ZeroMethod pz2 = new ZeroMethod();
		
//		Contratto c1 = new ContrattoImpl();
//		c1.regola1();
	//	ContrattoImpl c2 = new ContrattoImpl();
		//c2.miaRegolaCustom();
		
		//Contratto cc = () -> System.out.println("pippo");
		
		Libro l1 = new Libro();
		l1.titolo = "io robot";
		l1.pagine = 123;
		
		Libro l2 = new Libro();
		l2.titolo = "zanna bianca";
		l2.pagine = 23;
		
		Libro l3 = new Libro();
		l3.titolo = "baciami piccina";
		l3.pagine = 75;
				List<Libro> of = List.of(l1,l2,l3);
		List<Libro> libri =new ArrayList<>(of);
		
		Collections.sort(libri,(ll1,ll2) -> ll1.titolo.compareTo(ll2.titolo));
		
		for (Libro libro : libri) {
			System.out.println(libro.titolo);
		}
	}
}
