package com.astrategy.pokemine.entities;


import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

import java.util.Set;

@Getter
@Setter 
@Entity
@Table(name="abilities")
@JsonIgnoreProperties("cards")
public class Abilities{
	@Id
	private int id ;
	private String name;
	private String text;
	private String type;

	@ManyToMany(mappedBy="abilities")
	private Set<Card> cards;

	@Override
	public String toString() {
		return "Abilities{" +
				"id=" + id +
				", name='" + name + '\'' +
				", text='" + text + '\'' +
				", type='" + type + '\'' +
				", cards=" + cards +
				'}';
	}
}
