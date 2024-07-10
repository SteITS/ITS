package com.stwfy.repos;

import org.springframework.data.jpa.repository.JpaRepository;

import com.stwfy.entities.PokemonPics;

public interface PokemonDAO extends JpaRepository<PokemonPics, String>{
	
}
