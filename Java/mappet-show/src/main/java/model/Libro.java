package model;

public class Libro {

	private static int counter = 1;
	private int id;
	
	private String titolo;
	private int pagine;
	private double prezzo;
	
	public Libro() {
		this.id=counter++;
	}

	public Libro(String titolo) {
		this();
		this.titolo = titolo.toUpperCase();
	}

	public Libro(String titolo, int pagine) {
		this(titolo);
		this.pagine = pagine;
	}

	public Libro(String titolo, int pagine, double prezzo) {
		this(titolo,pagine);
		this.prezzo = prezzo;
	}

	
	
	
	
	public static int getCounter() {
		return counter;
	}

	public static void setCounter(int counter) {
		Libro.counter = counter;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getTitolo() {
		return titolo;
	}

	public void setTitolo(String titolo) {
		this.titolo = titolo;
	}

	public int getPagine() {
		return pagine;
	}

	public void setPagine(int pagine) {
		this.pagine = pagine;
	}

	public double getPrezzo() {
		return prezzo;
	}

	public void setPrezzo(double prezzo) {
		this.prezzo = prezzo;
	}
	
	
	
	
}
