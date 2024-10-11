package com.astrategy.pokemine.entities;


import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import jakarta.persistence.*;

import lombok.Getter;
import lombok.Setter;

import java.util.Set;

@Getter
@Setter
@Entity
@Table(name="types")
@JsonIgnoreProperties("cards")

public class Types {
	@Id
	private int id;
	private String name;
	@ManyToMany(mappedBy="types")
	private Set<Card> cards;

	@Override
	public String toString() {
		return "Types{" +
				"id=" + id +
				", name='" + name + '\'' +
				", cards=" + cards +
				'}';
	}
}
