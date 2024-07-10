package repo;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Connessione {
	private final String URL = "jdbc:mariadb://localhost:3306/java";
	private final String USER = "root";
	private final String PASS = "";
	
	private Connection conn = null;
	
	private void connetti() {
		try {
			conn=DriverManager.getConnection(URL, USER, PASS);
			System.out.println("Sei Connesso!");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}

	public Connection getConn() {
		if (conn==null) {
			connetti();
		}
		return conn;
	}
	
}
