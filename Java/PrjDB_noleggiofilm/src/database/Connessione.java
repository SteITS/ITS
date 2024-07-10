package database;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Connessione {

	private final String URL="jdbc:mariadb://localhost:3306/video_store_database";
	private final String USER="root";
	private final String PASS="";
	
	private Connection conn;
	
	public Connection getConn() {
		return conn;
	}

	public void connetti(){
		try {
			this.conn=DriverManager.getConnection(URL, USER, PASS);
			System.out.println("Sei connesso!");
		} catch (SQLException e) {
			System.err.println("Connessione non riuscita"+e.getMessage());
		}
	}
	
}
