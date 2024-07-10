package com.stwfy.services;

import java.util.List;

import com.stwfy.entities.Prodotto;

public interface ProdottoService {
	
	List<Prodotto> get_Prodotti();
	Prodotto addProdotto(Prodotto p);
	
}
