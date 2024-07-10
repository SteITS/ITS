package controller;

import java.util.ArrayList;

import model.studente;

public class AulaCtrl {

	private ArrayList<studente> studenti;
	
	public AulaCtrl() {
		this.studenti = new ArrayList<studente>();
	}
	public void addstudente(studente s) {
		this.studenti.add(s);
	}
	
	public ArrayList<studente> getStudenti() {
		return studenti;
	}
	
	
	
}
