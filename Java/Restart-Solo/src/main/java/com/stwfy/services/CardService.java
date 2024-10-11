package com.stwfy.services;

import java.util.List;

import com.stwfy.entities.Card;

public interface CardService {

	List<Card> getCardsByName(String name);
	
	List<Card> getCards();
}
