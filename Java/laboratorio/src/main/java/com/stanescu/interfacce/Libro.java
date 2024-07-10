package com.stanescu.interfacce;

public class Libro implements Comparable<Libro>{

	public String titolo;
	public int pagine;
	@Override
	public int compareTo(Libro altroLibro) {
		
		return this.pagine - altroLibro.pagine;
	}
	
}
