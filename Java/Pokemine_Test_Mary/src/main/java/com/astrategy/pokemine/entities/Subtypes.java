package com.astrategy.pokemine.entities;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.ManyToMany;
import jakarta.persistence.Table;
import lombok.Getter;
import lombok.Setter;

import java.util.Set;

@Getter
@Setter
@Entity
@Table(name="subtypes")
@JsonIgnoreProperties("cards")

public class Subtypes {
	@Id
	private int id;
	private String name;

	@ManyToMany(mappedBy = "subtypes")
	private Set<Card> cards;

	@Override
	public String toString() {
		return "Subtypes{" +
				"id=" + id +
				", name='" + name + '\'' +
				", cards=" + cards +
				'}';
	}
}
