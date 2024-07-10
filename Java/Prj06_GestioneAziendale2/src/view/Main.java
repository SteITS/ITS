package view;

import java.util.ArrayList;

import controller.Azienda;
import dipendenti.Dipendente;

public class Main {

	public static void main(String[] args) {
		
		Azienda a1 = new Azienda("a fuoco il pitone");
		
		a1.addDipendente("alessandro", "aliberti", "F");
		a1.addDipendente("edoardo", "bera", "F");
		a1.addDipendente("may", "totsugeki", "I");
		a1.addDipendente("gesu", "bello", "I");
		a1.addDipendente("dio", "attore", "D");
		
		ArrayList<Dipendente> dipendenti =a1.getDipendenti();
		
		for(Dipendente dipendente : dipendenti) {
			System.out.println(dipendente);
		}
	}

}
