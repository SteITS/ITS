package db;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

import model.Film;

public class FilmDAO {
	private Connessione miaConn= new Connessione();
	
	//Contenitore di istruzioni
	private Statement istruzione;
	
	//Contenitore di risultati
	private ResultSet rs;
	
	public ArrayList<Film> getFilms(){
		ArrayList<Film> films = new ArrayList<Film>();
		
		try {
			istruzione = this.miaConn.getConn().createStatement();
			rs = istruzione.executeQuery("Select * FROM film");
			while(rs.next()) {
				Film f = new Film();
				f.setId(rs.getInt("id"));
				f.setTitolo(rs.getString("titolo"));
				f.setRegista(rs.getString("regista"));
				f.setAnno(rs.getInt("anno"));
				f.setRating(rs.getInt("rating"));
				films.add(f);
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return films;
		
	}
	
}
