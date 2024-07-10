package controller;

import java.util.ArrayList;

import model.Libro;
import model.LibroPerBambini;

public class Biblioteca {

	private ArrayList<Libro> libriBib = new ArrayList<Libro>();
	
	public void addLibro(Libro l) {
			libriBib.add(l);
	}

	public ArrayList<Libro> getLibriBib() {
		return libriBib;
	}
	
	public boolean inBiblioteca(Libro l) {
		return l.isInPrestito();
	}
	public void prestato(Libro l) throws EccezioneLibro {
        if (!inBiblioteca(l)) {
            throw new EccezioneLibro("Non in biblioteca");
        } else if (l.isInPrestito()) {
            throw new EccezioneLibro("In Biblioteca");
        } else {
            l.setInPrestito(true);
        }
    }
	
	
	public void restituito(Libro l) {
		l.setInPrestito(false);
	}
	public int totInPrestito() {
		int i=0;
		for (Libro libro : libriBib) {
			if(libro.isInPrestito()==true) {
				i++;
			}
			
		}
		return i;
	}
	public boolean nessunPrestito() {
		boolean Vuoto= false;
		if(totInPrestito()==0) {
			Vuoto = true;
		}
		return Vuoto;
	}
	
	public int perBambini(int etaMax){
		int i=0;
		for(Libro l: libriBib) {
			if(l instanceof LibroPerBambini) {
				LibroPerBambini lBambino = (LibroPerBambini) l;
                if (lBambino.etaConsigliata <= etaMax) {
                    i++;
        }
			}
				}
	return i;
	}


}
