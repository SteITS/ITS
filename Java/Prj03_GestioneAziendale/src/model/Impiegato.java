package model;

import util.Segreteria;

public class Impiegato {
	
	private String nome, cognome, id;
	private int annoNascita, stipendio;
	
	public Impiegato(String nome, String cognome, int annoNascita) {
		super(); //super() chiamata implicita al costruttore di Object()
		this.nome = nome;
		this.cognome = cognome;
		this.annoNascita = annoNascita;
		this.stipendio = 1000;	
		this.id = Segreteria.creaId(this.nome, this.cognome,this.annoNascita);
	}

	public int getStipendio() {
		return stipendio;
	}

	public void setStipendio(int stipendio) {
		this.stipendio = stipendio;
	}

	public String getNome() {
		return nome;
	}

	public String getCognome() {
		return cognome;
	}

	public String getId() {
		return id;
	}

	public int getAnnoNascita() {
		return annoNascita;
	}

	@Override
	public String toString() {
		return "Impiegato [nome=" + nome + ", cognome=" + cognome + ", id=" + id + ", annoNascita=" + annoNascita
				+ ", stipendio=" + stipendio + "]";
	}
	
	

}
