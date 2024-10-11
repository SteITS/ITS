package com.astrategy.pokemine.entities;



import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

import java.util.Set;

@Getter
@Setter
@Entity
@Table(name = "cards")
public class Card {
	
	@Id
	@Column(name = "id")
	private String id;
	@Column(name = "expansion")
	private String set;
	
	private String series;
	
	private String publisher;
	
	private String generation;
	
	private String release_date;
	
	private String artist;
	
	private String name;
	
	private String set_num;
	
	private String supertype;
	
	private String levell;
	
	private String hp;
	
	private String evolves_from;
	
	private String evolves_to;
	
	private String retreat_cost;
	
	private String converted_retreat_cost;
	
	private String rarity;
	
	private String flavor_text;
	
	private String national_pokedex_numbers;
	
	private String legalities;
	
	private String rules;
	
	private String regulation_mark;
	
	private String ancient_trait;
	
	private String img;

	/*relationship between a card and its abilities by relational table*/
	@ManyToMany
	@JoinTable(
			name = "card_abilities",
			joinColumns = @JoinColumn(name = "card_id"),
			inverseJoinColumns = @JoinColumn(name = "ability_id")
	)
	private Set<Abilities> abilities;

	/*relationship between a card and its attacks by relational table*/
	@ManyToMany
	@JoinTable(
			name = "card_attacks",
			joinColumns = @JoinColumn(name = "card_id"),
			inverseJoinColumns = @JoinColumn(name = "attack_id")
	)
	private Set<Attacks> attacks;

	/*relationship between a card and its weaknesses by relational table*/
	@ManyToMany
	@JoinTable(
			name = "card_weaknesses",
			joinColumns = @JoinColumn(name = "card_id"),
			inverseJoinColumns = @JoinColumn(name = "weakness_id")
	)
	private Set<Weaknesses> weaknesses;

	/*relationship between a card and its abilities by relational table*/
	@ManyToMany
	@JoinTable(
			name = "card_resistances",
			joinColumns = @JoinColumn(name = "card_id"),
			inverseJoinColumns = @JoinColumn(name = "resistance_id")
	)
	private Set<Resistances> resistances;

	/*relationship between a card and its types by relational table*/
	@ManyToMany
	@JoinTable(
			name = "card_types",
			joinColumns = @JoinColumn(name = "card_id"),
			inverseJoinColumns = @JoinColumn(name = "type_id")
	)
	private Set<Types> types;

	/*relationship between a card and its subtypes by relational table*/
	@ManyToMany
	@JoinTable(
			name = "card_subtypes",
			joinColumns = @JoinColumn(name = "card_id"),
			inverseJoinColumns = @JoinColumn(name = "subtype_id")
	)
	private Set<Subtypes> subtypes;


}
