package com.stwfy.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.stwfy.entities.PokemonPics;
import com.stwfy.repos.PokemonDAO;
@Service
public class PokemonPicsServiceImp implements PokemonPicsService{
	@Autowired
	PokemonDAO dao;

	@Override
	public List<PokemonPics> getPokemonPics() {
		return dao.findAll();
	}

	@Override
	public PokemonPics getPokemonPicByName(String name) {
		for(PokemonPics pic: dao.findAll())
			if(pic.getName().equals(name))
				return pic;
		return null;
	}
	
	

	
}
