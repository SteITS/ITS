package presentation;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;

import controller.FilmCtrl;
import model.Film;

public class Noleggio {

	public static void main(String[] args) {
		
		FilmCtrl controller = new FilmCtrl();
		//controller.getFilm();
		File miofile = new File("C:\\Users\\icts23-25.097\\Desktop\\film.html");
		try {
			PrintWriter output = new PrintWriter(miofile);
			output.println("<table>");
			output.println("<tr>");
			output.println("<th>Film</th>");
			output.println("<th>Descrizione</th>");
			output.println("<th>Anno di pubblicazione</th>");
			output.println("</tr>");
			
			for(Film f : controller.getFilmsByGenre(3)) {
				output.println("<tr>");
				output.println("<td><a target='_blank' href='https://www.google.com/search?q="+f.getTitle()+"'>"+f.getTitle()+"</a></td>");
				output.println("<td>"+f.getDescription()+"</td>");
				output.println("<td>"+f.getReleaseYear()+"</td>");
				output.println("</tr>");
			}
			
			output.println("</table>");
			output.close();
			
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}

}
