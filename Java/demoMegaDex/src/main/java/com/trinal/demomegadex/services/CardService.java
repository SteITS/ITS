package com.trinal.demomegadex.services;

import com.trinal.demomegadex.entities.Card;
import com.trinal.demomegadex.entities.User;
import com.trinal.demomegadex.repos.CardRepository;
import com.trinal.demomegadex.repos.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class CardService {
    @Autowired
    private CardRepository cardRepository;

    public List<Card> getAllCards() {
        return cardRepository.findAll();
    }

    public Optional<Card> getCard(String idCard) {
        return cardRepository.findById(idCard);
    }
}