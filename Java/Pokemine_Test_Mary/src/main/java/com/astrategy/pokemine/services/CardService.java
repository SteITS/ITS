package com.astrategy.pokemine.services;

import com.astrategy.pokemine.entities.Card;

import java.util.List;
import java.util.Optional;


public interface CardService {
    List<Card> getCards();
    Optional<Card> getCard(String id);
    List<Card> getCardsByName(String name);
    List<Card> getCardsByArtist(String artist);
}
