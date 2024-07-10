package repo;

import java.io.File;
import java.io.FileNotFoundException;
import java.time.LocalDate;
import java.util.Scanner;

import model.TodoDAO;

public class ProvaConnessione {

	public static void main(String[] args) {
		
		//Connessione connessione=new Connessione();
		//connessione.getConn();
		TodoDAO dao=new TodoDAO();
		dao.addToDo("Delphox",LocalDate.now(),true);
		
		File f= new File("C:\\Javing\\pokemon.csv");
		try {
			Scanner s= new Scanner(f);
			while(s.hasNextLine()) {
				String riga=s.nextLine();
				//System.out.println(riga);
				String[] split = riga.split(",");
				if(!riga.startsWith("#")) {
					System.out.println(split[1]);
					dao.addToDo(split[1], LocalDate.now(), true);
				}
			}
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
