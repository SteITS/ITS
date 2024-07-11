package com.stanescu.interfacce;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

/*class ComparatoreTitoloLibri  implements Comparator<Libro>{

	@Override
	public int compare(Libro o1, Libro o2) {
		return o1.titolo.compareTo(o2.titolo);
	}
	
}
*/
public class InterfacceDemo{
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
		
		Comparator<Libro> ctl = new Comparator<>(){

			@Override
			public int compare(Libro o1, Libro o2) {
				// TODO Auto-generated method stub
				return o1.titolo.compareTo(o2.titolo);
			}
		};
		Collections.sort(libri,(o1,o2) -> o1.titolo.compareTo(o2.titolo));
		
		libri
		.stream()
		.filter(l -> l.pagine >50)
		.sorted((ll1,ll2)-> ll1.titolo.compareTo(ll2.titolo))
		.forEach(l -> System.out.println(l.titolo));
		System.out.println("-------------------");
		List<Libro> libriFiltrati = libri
		.stream()
		.filter(l -> l.pagine < 50)
		.filter(l -> l.titolo.startsWith("Z"))
		.sorted((ll1,ll2)-> ll2.titolo.compareTo(ll1.titolo))
		.limit(3)
		//.forEach(l -> System.out.println(l.titolo));
		.collect(Collectors.toList());
		for (Libro libro : libri) {
			System.out.println(libro.titolo);
		}
	}

}
