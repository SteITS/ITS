package model;

public abstract class Dipendente {
	
	private String nome;
	private String ruolo;
	private int matricola;
	private static int contatore=1;
	private double stipendio;
	
	public Dipendente(String nome) {
		super();
		this.nome = nome;
		this.matricola=contatore++;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getRuolo() {
		return ruolo;
	}

	public void setRuolo(String ruolo) {
		this.ruolo = ruolo;
	}

	public double getStipendio() {
		return stipendio;
	}

	public void setStipendio(double stipendio) {
		this.stipendio = stipendio;
	}

	public int getMatricola() {
		return matricola;
	}

	@Override
	public String toString() {
		StringBuilder builder = new StringBuilder();
		builder.append("Dipendente [nome=");
		builder.append(nome);
		builder.append(", ruolo=");
		builder.append(ruolo);
		builder.append(", matricola=");
		builder.append(matricola);
		builder.append(", stipendio=");
		builder.append(stipendio);
		builder.append("]");
		return builder.toString();
	}
	
	public abstract void calcolaStipendio();
		
		
	
}
