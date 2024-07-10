package model;

import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.time.LocalDate;

import repo.Connessione;

public class TodoDAO /*implements TodoDAO1*/{
	
	private Connessione conn=new Connessione();
	private Statement statement;
	private PreparedStatement ps;
	private ResultSet resultSet;
	
	public void addToDo(String descrizione, LocalDate data, Boolean done) {
		try {
			ps = conn
					.getConn()
					.prepareStatement("insert into todo (descrizione,data,done) values (?, ?, ?)");
			
			ps.setString(1, descrizione);
			ps.setDate(2, Date.valueOf(data));
			ps.setBoolean(3, done);
			ps.execute();
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
