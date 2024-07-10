package controller;

import model.Impiegato;

public class azienda {
	
	private Impiegato[] impiegati;
	private int numeroMax;
	private int numeroAttuale;
	public azienda(int numeroMax) {
		this.numeroMax = numeroMax;
		this.impiegati = new Impiegato [this.numeroMax];
		this.numeroAttuale = 0;
	}
	
	public void addImpiegato(Impiegato i) {
		if (this.numeroAttuale < this.numeroMax) {
			this.impiegati[this.numeroAttuale] = i; //aggiungo l'impiegato i all'array numeroattuale
			this.numeroAttuale++;
			
			System.out.println("c'è ancora posto ");
		} else {
			System.out.println("posti esauriti");
		}
	}
	
	public int calcolaStipendioTot() {
		int totale = 0;
		for (Impiegato impiegato : impiegati) {
			if(impiegato != null)
				totale += impiegato.getStipendio();
		}
		return totale;
	}
	public String getDipendenti() {
		StringBuilder sb = new StringBuilder();
		for (Impiegato impiegato : impiegati) {
			sb.append(impiegato);
			sb.append("\n");
		}
		return sb.toString();
	}
}
