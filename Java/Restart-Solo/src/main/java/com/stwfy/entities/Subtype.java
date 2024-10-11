package com.stwfy.entities;

import java.util.Set;

import com.fasterxml.jackson.annotation.JsonBackReference;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.ManyToMany;
import jakarta.persistence.Table;

@Entity
@Table(name = "subtypes")
public class Subtype {

	@Id
	@Column(name = "id")
	private int id;
	
	private String name;

	@ManyToMany(mappedBy="subtypes")
	@JsonBackReference
	private Set<Card> cards;
	
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getId() {
		return id;
	}
	
	
}
