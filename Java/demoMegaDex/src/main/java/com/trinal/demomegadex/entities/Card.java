package com.trinal.demomegadex.entities;

import jakarta.persistence.*;
import org.hibernate.annotations.Nationalized;

import java.util.LinkedHashSet;
import java.util.Set;

@Entity
@Table(name = "cards", schema = "dbo")
public class Card {
    @Id
    @Nationalized
    @Column(name = "id", nullable = false, length = 50)
    private String id;

    @Nationalized
    @Column(name = "\"set\"", nullable = false, length = 50)
    private String set;

    @Nationalized
    @Column(name = "series", nullable = false, length = 50)
    private String series;

    @Nationalized
    @Column(name = "publisher", nullable = false, length = 50)
    private String publisher;

    @Nationalized
    @Column(name = "generation", nullable = false, length = 50)
    private String generation;

    @Nationalized
    @Column(name = "release_date", nullable = false, length = 50)
    private String releaseDate;

    @Nationalized
    @Column(name = "artist", length = 50)
    private String artist;

    @Nationalized
    @Column(name = "name", nullable = false, length = 100)
    private String name;

    @Nationalized
    @Column(name = "set_num", nullable = false, length = 50)
    private String setNum;

    @Nationalized
    @Column(name = "supertype", nullable = false, length = 100)
    private String supertype;

    @Nationalized
    @Column(name = "\"level\"", length = 3)
    private String level;

    @Column(name = "hp")
    private Integer hp;

    @Nationalized
    @Column(name = "evolves_from", length = 50)
    private String evolvesFrom;

    @Nationalized
    @Column(name = "evolves_to", length = 100)
    private String evolvesTo;

    @Nationalized
    @Column(name = "retreat_cost", length = 100)
    private String retreatCost;

    @Nationalized
    @Column(name = "converted_retreat_cost", length = 50)
    private String convertedRetreatCost;

    @Nationalized
    @Column(name = "rarity", length = 50)
    private String rarity;

    @Nationalized
    @Lob
    @Column(name = "flavor_text")
    private String flavorText;

    @Nationalized
    @Column(name = "national_pokedex_numbers", length = 50)
    private String nationalPokedexNumbers;

    @Nationalized
    @Lob
    @Column(name = "legalities", nullable = false)
    private String legalities;

    @Nationalized
    @Lob
    @Column(name = "rules")
    private String rules;

    @Nationalized
    @Column(name = "regulation_mark", length = 1)
    private String regulationMark;

    @Nationalized
    @Lob
    @Column(name = "ancient_trait")
    private String ancientTrait;

    @Nationalized
    @Lob
    @Column(name = "img")
    private String img;

    public String getId() {
        return id;
    }

    public void setId(String id) {
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

    public String getReleaseDate() {
        return releaseDate;
    }

    public void setReleaseDate(String releaseDate) {
        this.releaseDate = releaseDate;
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

    public String getSetNum() {
        return setNum;
    }

    public void setSetNum(String setNum) {
        this.setNum = setNum;
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

    public Integer getHp() {
        return hp;
    }

    public void setHp(Integer hp) {
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