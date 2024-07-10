package model;

public class LibroPerBambini extends Libro {
	
	public int etaConsigliata;

	public LibroPerBambini(String titolo, String autore, int etaConsigliata) {
		super(titolo, autore);
		this.etaConsigliata=etaConsigliata;
		
	}

	@Override
	public String toString() {
		StringBuilder builder = new StringBuilder();
		builder.append("LibroPerBambini [etaConsigliata=");
		builder.append(etaConsigliata);
		builder.append("]");
		return builder.toString();
	}
	
	
	
}
