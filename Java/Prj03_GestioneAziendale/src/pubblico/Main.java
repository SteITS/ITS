package pubblico;

import controller.azienda;
import model.Impiegato;

public class Main {

	public static void main(String[] args) {
		
		azienda toyota = new azienda (4);
		azienda mercedes = new azienda (3);
		
		Impiegato i1 = new Impiegato("paolo","rossi",2000);
		toyota.addImpiegato(i1);
		Impiegato i2 = new Impiegato("mario","rossi",2002);
		toyota.addImpiegato(i2);
		Impiegato i3 = new Impiegato("maria","rossi",2001);
		i3.setStipendio(1500);
		toyota.addImpiegato(i3);
		
		toyota.addImpiegato(new Impiegato("giovanna", "darco", 1998));
		toyota.addImpiegato(new Impiegato("giuseppe", "mazzini", 2010));
		toyota.addImpiegato(new Impiegato("francesco", "totti", 1995));
		
		System.out.println(toyota.getDipendenti());
		System.out.println("Totale ");
		System.out.println(toyota.calcolaStipendioTot());
	}

}
