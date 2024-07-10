package principale;

import java.awt.print.Printable;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

import model.studente;

public class Main {

	public static void main(String[] args) {
		
		File f = new File("files/studenti.txt");
		File destinazione = new File("files/studenti_tostring.html");
		
		try (Scanner input = new Scanner(f)) {
			PrintWriter pennarello = new PrintWriter(destinazione);
			
			pennarello.println("<h1>Studenti</h1>");
			
			pennarello.println("<ul>");
			
			while(input.hasNextLine()) {
				String riga = input.nextLine();
				
				String[] parole = riga.split(",");
				
				String nome = parole[0];
				String cognome = parole[1];
				
				studente s = new studente(nome,cognome);
				pennarello.println("<li>" + s.getCognome() + s.getNome() + "</li>");
				System.out.println(s);
			}
			pennarello.println("</ul>");
			pennarello.close();
			
		} catch (FileNotFoundException e) {
			System.err.println("Mi dispiace, il fine non è raggiungibile");
			
			System.err.println(e.getMessage());
		}
		

	}

}
