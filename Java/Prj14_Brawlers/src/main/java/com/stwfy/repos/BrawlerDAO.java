package com.stwfy.repos;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import com.stwfy.entities.Brawler;

public interface BrawlerDAO extends JpaRepository<Brawler, Integer> {

	List<Brawler> findByRarity(String rarity); //derived query
	List<Brawler> findByCarattere(String carattere); //derived query
	
	
}
