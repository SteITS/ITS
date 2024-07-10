package com.stwfy.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.stwfy.entities.Prodotto;
import com.stwfy.repos.ProdottoDAO;

@Service

public class ProdottoServicesImp implements ProdottoService {

	@Autowired
	private ProdottoDAO dao;
	
	@Override
	public List<Prodotto> get_Prodotti() {
		
		return dao.findAll();
	}

	@Override
	public Prodotto addProdotto(Prodotto p) {
		
		return dao.save(p);
	}

}
