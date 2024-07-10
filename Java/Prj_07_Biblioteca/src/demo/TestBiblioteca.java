package demo;

import controller.Biblioteca;
import controller.EccezioneLibro;
import model.Libro;
import model.LibroPerBambini;

public class TestBiblioteca {

	public static void main(String[] args) {
		
        Libro libro = new Libro("Il signore degli anelli", "J.R.R. Tolkien");
        LibroPerBambini libroPerBambini = new LibroPerBambini("Le avventure di Pinocchio", "Carlo Collodi", 8);
        Biblioteca biblioteca = new Biblioteca();

        biblioteca.addLibro(libro);
        biblioteca.addLibro(libroPerBambini);
        
        for (Libro l : biblioteca.getLibriBib()) {
			System.out.println(l.getDescrizione());
		}
        	try {
        		 biblioteca.prestato(libro);
                 biblioteca.prestato(libroPerBambini);
                 biblioteca.prestato(libroPerBambini);
        	}catch (EccezioneLibro e) {
        		System.out.println("Errore: " + e.getMessage());
        	}

	
	}
}