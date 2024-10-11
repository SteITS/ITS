package com.astrategy.pokemine.services;

import com.astrategy.pokemine.entities.Card;
import com.astrategy.pokemine.repos.CardDAO;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class CardServiceImpl implements CardService {
    @Autowired
    private CardDAO dao;

    @Override
    public List<Card> getCards() {
        return dao.findAll();
    }

    @Override
    public Optional<Card> getCard(String id) {
        return dao.findById(id);
    }

    @Override
    public List<Card> getCardsByName(String name) {
        return dao.findByName(name);
    }

    @Override
    public List<Card> getCardsByArtist(String artist) {
        return dao.findByArtist(artist);
    }
}
