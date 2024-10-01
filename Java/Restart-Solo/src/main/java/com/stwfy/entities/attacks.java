package com.stwfy.entities;

import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.Table;

@Entity
@Table(name="attacks")
public class attacks {
	
@Id
	private int id;

	private String attack_name;
	
	private String cost;
	
	private String damage;
	
	private String convertedEnergyCost;
	
	private String text;

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

	public String getConvertedEnergyCost() {
		return convertedEnergyCost;
	}

	public void setConvertedEnergyCost(String convertedEnergyCost) {
		this.convertedEnergyCost = convertedEnergyCost;
	}

	public String getText() {
		return text;
	}

	public void setText(String text) {
		this.text = text;
	}

	
}
