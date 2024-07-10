package controller;

import java.io.IOException;
import java.util.ArrayList;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import model.Dipendente;
import model.Fattorino;

@WebServlet("/dipendenti")
public class AziendaController extends HttpServlet{
	private ArrayList<Dipendente> dipendentes = new ArrayList<Dipendente>();
	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		Fattorino f = new Fattorino("Niccolo");
		dipendentes.add(f);
		resp.getWriter().print(dipendentes);
	}
	

}
