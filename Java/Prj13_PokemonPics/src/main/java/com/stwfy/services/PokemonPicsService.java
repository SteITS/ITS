package com.stwfy.services;

import java.util.List;

import com.stwfy.entities.PokemonPics;

public interface PokemonPicsService {

	List<PokemonPics> getPokemonPics();
	PokemonPics getPokemonPicByName(String name);
}
