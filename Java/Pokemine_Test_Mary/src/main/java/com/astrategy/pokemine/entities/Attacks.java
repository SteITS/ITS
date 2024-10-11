package com.astrategy.pokemine.entities;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.ManyToMany;
import jakarta.persistence.Table;
import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

import java.util.Set;

@Getter
@Setter
@Entity
@Table(name="attacks")

@JsonIgnoreProperties("cards")
public class Attacks {
	
	
	@Id
	private int id;
	private String attack_name;
	private String cost;
	private String damage;
	private int convertedEnergyCost;
	private String text;


	@ManyToMany(mappedBy="attacks")
	private Set<Card> cards;

	@Override
	public String toString() {
		return "Attacks{" +
				"id=" + id +
				", attack_name='" + attack_name + '\'' +
				", cost='" + cost + '\'' +
				", damage=" + damage +
				", convertedEnergyCost=" + convertedEnergyCost +
				", text='" + text + '\'' +
				'}';
	}
}
