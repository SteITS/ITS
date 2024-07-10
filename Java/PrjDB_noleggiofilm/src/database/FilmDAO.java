package database;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

import model.Film;

public class FilmDAO {

	private Connessione c;
	
	private Statement stat;
	
	private ResultSet rs;

	public FilmDAO() {
		this.c= new Connessione();
		c.connetti();
	}
	
	public ArrayList<Film> getFilm() {
		ArrayList<Film> films=new ArrayList<>();
		try {
			this.stat= c.getConn().createStatement();
			this.rs=this.stat.executeQuery("SELECT * FROM film");
			while(this.rs.next()) {
				Film f = new Film();
				f.setId(rs.getInt("film_id"));
				f.setTitle(rs.getString("title"));
				f.setReleaseYear(rs.getInt("release_year"));
				f.setDescription(rs.getString("description"));
				f.setLanguageId(rs.getInt("Language_id"));
				f.setGenreId(rs.getInt("genre_id"));
				System.out.println(f);
				films.add(f);
			}
		} catch (SQLException e) {
			throw new RuntimeException(e);
		}
		return films;
	}
	public static void main(String[] args) {
		FilmDAO dao = new FilmDAO();
		dao.getFilm();
		}
}
