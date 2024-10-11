package com.stwfy.repos;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import com.stwfy.entities.Card;

public interface CardDAO extends JpaRepository<Card, String>{

	List<Card> findAll();
	List<Card> findByName(String name);
}
