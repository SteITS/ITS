package com.astrategy.pokemine.repos;

import com.astrategy.pokemine.entities.Card;
import lombok.NonNull;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;
import java.util.Optional;

@Repository
public interface CardDAO extends JpaRepository<Card, String> {
    List<Card> findAll();
    Optional<Card> findById(@NonNull String id);
    List<Card> findByName(String name);

    List<Card> findByArtist(String artist);

}
