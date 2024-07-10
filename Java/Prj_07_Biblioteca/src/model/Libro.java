package model;

public class Libro {
	
	private String titolo;
	private String autore;
	private boolean inPrestito;
	
	
	public Libro(String titolo, String autore) {
		super();
		this.titolo = titolo;
		this.autore = autore;
		this.inPrestito = false;
	}

	public boolean isInPrestito() {
		return inPrestito;
	}
	
	public void setInPrestito(boolean inPrestito) {
		this.inPrestito = inPrestito;
	}
	
	

	public String getDescrizione() {
		StringBuilder builder = new StringBuilder();
		builder.append("Libro [titolo=");
		builder.append(titolo);
		builder.append(", autore=");
		builder.append(autore);
		builder.append("]");
		return builder.toString();
	}
	
}
	
