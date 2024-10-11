package com.stwfy.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.stwfy.entities.Card;
import com.stwfy.repos.CardDAO;
@Service
public class CardServiceImpl implements CardService{

	@Autowired
	private CardDAO dao;
	
	
	@Override
	public List<Card> getCardsByName(String name) {
		return dao.findByName(name);
	}

	@Override
	public List<Card> getCards() {
		return dao.findAll();
	}

	
}
