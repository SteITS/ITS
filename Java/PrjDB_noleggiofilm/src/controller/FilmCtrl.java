package controller;

import java.util.ArrayList;

import database.FilmDAO;
import model.Film;

public class FilmCtrl {

	FilmDAO dao= new FilmDAO();
	
	public ArrayList<Film> getFilm(){
		return dao.getFilm();
	}
	
	public ArrayList<Film> getFilmsByGenre(int genreId){
		
		ArrayList<Film> filmByGenre=new ArrayList<>(); //creazione Array list vuoto
		for(Film f : dao.getFilm()) {		//ciclo for per tutti i film
			if(f.getGenreId()==genreId) {	//se il genere del film corrisponde al genere passato
				filmByGenre.add(f);			//aggiungo film corrente all'Arraylist nuovo
			}
		}
		return filmByGenre;					//return Arraylist nuovo
		
		//return dao.getFilm().stream().filter(film -> film.getGenreId()==genreId).toList();
	}
	
}
