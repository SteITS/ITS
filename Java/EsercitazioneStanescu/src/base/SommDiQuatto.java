package base;

import java.util.Scanner;

/**Scrivere un programma SommaProdotto che chiede all’utente di inserire due 
 * valori interi e ne calcola la somma 
 */
public class SommDiQuatto {

	public static void main(String[] args) {
		
		int somma = 0;
		
		final int cicli = 4;
		
		for(int i = 0; i<cicli; i++) {
			somma += chiediNumero();
		}
		
		System.out.println("La somma dei 44 numeri interi è; " + somma);
		
		//int numeroRichiesto = chiediNumero();

	}

	private static int chiediNumero() {
		
		System.out.println("Inserisci un numero intero.");
		Scanner epson = new Scanner(System.in);
		
		return epson.nextInt();
	}

}
