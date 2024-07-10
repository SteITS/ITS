package model;

public class Film {

	private int id;
	private String titolo;
	private int anno;
	private int rating;
	private String regista;
	
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getTitolo() {
		return titolo;
	}
	public void setTitolo(String titolo) {
		this.titolo = titolo;
	}
	public int getAnno() {
		return anno;
	}
	public void setAnno(int anno) {
		this.anno = anno;
	}
	public int getRating() {
		return rating;
	}
	public void setRating(int rating) {
		this.rating = rating;
	}
	public String getRegista() {
		return regista;
	}
	public void setRegista(String regista) {
		this.regista = regista;
	}
	
	@Override
	public String toString() {
		StringBuilder builder = new StringBuilder();
		builder.append("Film [id=");
		builder.append(id);
		builder.append(", titolo=");
		builder.append(titolo);
		builder.append(", anno=");
		builder.append(anno);
		builder.append(", rating=");
		builder.append(rating);
		builder.append(", regista=");
		builder.append(regista);
		builder.append("]");
		return builder.toString();
	}
	
	
}
