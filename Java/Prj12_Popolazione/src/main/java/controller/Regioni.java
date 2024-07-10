package controller;

import java.io.IOException;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import services.PopService;
import services.PopServiceImp;

@WebServlet("/regioni")
public class Regioni extends HttpServlet{

	private PopService service = new PopServiceImp();
	
	
	
	public Regioni() {
		System.out.println("Serve regioni");
	}
	
	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		System.out.println("Hai chiamato il metodo Get");
		//resp.getWriter().print("Hai chiamato il metodo Get");
		
		req.setAttribute("Titolo", "La mia pagina è bellissima");
		
		req.setAttribute("Regioni", service.getRegioni());
		
		req.getRequestDispatcher("regions.jsp").forward(req, resp);
		
		
	}
}
	
	