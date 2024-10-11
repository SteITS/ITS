package com.stwfy.entities;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.Table;
@Entity
@Table(name = "cards")
public class Cards {

	@Id
	@Column(name = "id")
	private int id;
	@Column(name = "set")
	private String set;
	@Column(name="")
	private String series;
	
	private String publisher;
	
	private String generation;
	
	private String release_date;
	
	private String artist;
	
	private String name;
	
	private String set_num;
	
	private String supertype;
	
	private String level;
	
	private String hp;
	
	private String evolvesFrom;
	
	private String evolvesTo;
	
	private String retreatCost;
	
	private String convertedRetreatCost;
	
	private String rarity;
	
	private String flavorText;
	
	private String nationalPokedexNumbers;
	
	private String legalities;
	
	private String rules;
	
	private String regulationMark;
	
	private String ancientTrait;
	
	private String img;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getSet() {
		return set;
	}

	public void setSet(String set) {
		this.set = set;
	}

	public String getSeries() {
		return series;
	}

	public void setSeries(String series) {
		this.series = series;
	}

	public String getPublisher() {
		return publisher;
	}

	public void setPublisher(String publisher) {
		this.publisher = publisher;
	}

	public String getGeneration() {
		return generation;
	}

	public void setGeneration(String generation) {
		this.generation = generation;
	}

	public String getRelease_date() {
		return release_date;
	}

	public void setRelease_date(String release_date) {
		this.release_date = release_date;
	}

	public String getArtist() {
		return artist;
	}

	public void setArtist(String artist) {
		this.artist = artist;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getSet_num() {
		return set_num;
	}

	public void setSet_num(String set_num) {
		this.set_num = set_num;
	}

	public String getSupertype() {
		return supertype;
	}

	public void setSupertype(String supertype) {
		this.supertype = supertype;
	}

	public String getLevel() {
		return level;
	}

	public void setLevel(String level) {
		this.level = level;
	}

	public String getHp() {
		return hp;
	}

	public void setHp(String hp) {
		this.hp = hp;
	}

	public String getEvolvesFrom() {
		return evolvesFrom;
	}

	public void setEvolvesFrom(String evolvesFrom) {
		this.evolvesFrom = evolvesFrom;
	}

	public String getEvolvesTo() {
		return evolvesTo;
	}

	public void setEvolvesTo(String evolvesTo) {
		this.evolvesTo = evolvesTo;
	}

	public String getRetreatCost() {
		return retreatCost;
	}

	public void setRetreatCost(String retreatCost) {
		this.retreatCost = retreatCost;
	}

	public String getConvertedRetreatCost() {
		return convertedRetreatCost;
	}

	public void setConvertedRetreatCost(String convertedRetreatCost) {
		this.convertedRetreatCost = convertedRetreatCost;
	}

	public String getRarity() {
		return rarity;
	}

	public void setRarity(String rarity) {
		this.rarity = rarity;
	}

	public String getFlavorText() {
		return flavorText;
	}

	public void setFlavorText(String flavorText) {
		this.flavorText = flavorText;
	}

	public String getNationalPokedexNumbers() {
		return nationalPokedexNumbers;
	}

	public void setNationalPokedexNumbers(String nationalPokedexNumbers) {
		this.nationalPokedexNumbers = nationalPokedexNumbers;
	}

	public String getLegalities() {
		return legalities;
	}

	public void setLegalities(String legalities) {
		this.legalities = legalities;
	}

	public String getRules() {
		return rules;
	}

	public void setRules(String rules) {
		this.rules = rules;
	}

	public String getRegulationMark() {
		return regulationMark;
	}

	public void setRegulationMark(String regulationMark) {
		this.regulationMark = regulationMark;
	}

	public String getAncientTrait() {
		return ancientTrait;
	}

	public void setAncientTrait(String ancientTrait) {
		this.ancientTrait = ancientTrait;
	}

	public String getImg() {
		return img;
	}

	public void setImg(String img) {
		this.img = img;
	}
	
}
