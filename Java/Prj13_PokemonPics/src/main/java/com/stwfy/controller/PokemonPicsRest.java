package com.stwfy.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import com.stwfy.entities.PokemonPics;
import com.stwfy.services.PokemonPicsService;
import org.springframework.web.bind.annotation.RequestParam;


@RestController
public class PokemonPicsRest {
	@Autowired
	private PokemonPicsService service;
	
	@GetMapping("all")
	List<PokemonPics> get(){
		
		return service.getPokemonPics();
		
	}
	
	@GetMapping("nome")
	public PokemonPics getbyname(@RequestParam String param) {
		return service.getPokemonPicByName(param);
	}
	
}
