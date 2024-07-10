package model;

import java.time.LocalDate;
import java.util.List;

public interface TodoDAO1 {
	
	//proprietà public final per definizione
	String FIND_ALL = "SELECT * FROM todo";
	String ADD = "INSERT INTO todo (descrizione,data,done) values (?,?,?)";

	//metodi public e abstrac per definizione
	void addTodo(String desc, LocalDate data, boolean done);
	List<Todo> getAll();
}
