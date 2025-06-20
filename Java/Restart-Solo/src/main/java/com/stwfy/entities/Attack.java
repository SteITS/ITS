package com.stwfy.entities;

import java.util.Set;

import com.fasterxml.jackson.annotation.JsonBackReference;

import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.ManyToMany;
import jakarta.persistence.Table;

@Entity
@Table(name="attacks")
public class Attack {
	
	@Id
	private int id;

	private String attack_name;
	
	private String cost;
	
	private String damage;
	
	private int converted_energy_cost;
	
	private String text;
	
	@ManyToMany(mappedBy="attacks")
	@JsonBackReference
	private Set<Card> cards;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getAttack_name() {
		return attack_name;
	}

	public void setAttack_name(String attack_name) {
		this.attack_name = attack_name;
	}

	public String getCost() {
		return cost;
	}

	public void setCost(String cost) {
		this.cost = cost;
	}

	public String getDamage() {
		return damage;
	}

	public void setDamage(String damage) {
		this.damage = damage;
	}

	public int getConvertedEnergyCost() {
		return converted_energy_cost;
	}

	public void setConvertedEnergyCost(int convertedEnergyCost) {
		this.converted_energy_cost = convertedEnergyCost;
	}

	public String getText() {
		return text;
	}

	public void setText(String text) {
		this.text = text;
	}

	
}
