package com.stwfy.services;

import java.util.List;

import com.stwfy.entities.Brawler;

public interface BrawlerService {

	List<Brawler> getBrawlers();
	List<Brawler> getBrawlersByRarity(String rarity);
	List<Brawler> getBrawlersByCarattere(String carattere);
	Brawler getBrawlerById(int id);
	
	List<String> getRarities();
	List<String> getCaratteri();
}
