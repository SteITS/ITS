package com.trinal.demomegadex.repos;

import com.trinal.demomegadex.entities.Card;
import com.trinal.demomegadex.entities.User;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.Optional;

@Repository
public interface CardRepository extends JpaRepository<Card, String> {
}
