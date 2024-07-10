package dipendenti;

public class Fattorino extends Dipendente{
	
	private int numeroConsegne;

	public Fattorino(String nome, String cognome) {
		super(nome, cognome);
		// TODO Auto-generated constructor stub
		this.ruolo="Fattorino";
	}

	@Override
	public double calcolaStipendio() {
		// TODO Auto-generated method stub
		return numeroConsegne*pagaBase;
	}

	public int getNumeroConsegne() {
		return numeroConsegne;
	}

	public void setNumeroConsegne(int numeroConsegne) {
		this.numeroConsegne = numeroConsegne;
	}

	
}
