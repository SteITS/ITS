package model;

public class Film {
	private int id;
	private String title;
	private String description;
	private int releaseYear;
	private int languageId;
	private int genreId;
	
	
	public int getReleaseYear() {
		return releaseYear;
	}
	public void setReleaseYear(int i) {
		this.releaseYear = i;
	}
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getTitle() {
		return title;
	}
	public void setTitle(String title) {
		this.title = title;
	}
	public String getDescription() {
		return description;
	}
	public void setDescription(String description) {
		this.description = description;
	}
	public int getLanguageId() {
		return languageId;
	}
	public void setLanguageId(int i) {
		this.languageId = i;
	}
	public int getGenreId() {
		return genreId;
	}
	public void setGenreId(int genreId) {
		this.genreId = genreId;
	}
	
	@Override
	public String toString() {
		StringBuilder builder = new StringBuilder();
		builder.append("Film [id=");
		builder.append(id);
		builder.append(", title=");
		builder.append(title);
		builder.append(", release:");
		builder.append(releaseYear);
		builder.append(", description=");
		builder.append(description);
		builder.append(", languageId=");
		builder.append(languageId);
		builder.append(", genreId=");
		builder.append(genreId);
		builder.append("]");
		return builder.toString();
		
	}

	
}
