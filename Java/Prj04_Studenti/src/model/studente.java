package model;

public class studente {
	
	//proprietà della classe studente
	private static int counter = 1;
	
	//attributi degli oggetti
	private int id;
	private String nome;
	private String cognome;
	
	public studente(String nome, String cognome) {
		this.nome = nome;
		this.cognome = cognome;
		this.id = studente.counter++;
		
	}

	public static int getCounter() {
		return counter;
	}

	public static void setCounter(int counter) {
		studente.counter = counter;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getCognome() {
		return cognome;
	}

	public void setCognome(String cognome) {
		this.cognome = cognome;
	}

	public int getId() {
		return id;
	}

	@Override
	public String toString() {
		return "studente [id=" + id + ", nome=" + nome + ", cognome=" + cognome + "]";
	}
	
	
}
