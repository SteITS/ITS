package com.avdiu.controller;

import java.util.Collections;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.RestController;

import com.avdiu.entities.Country;
import com.avdiu.services.CountryService;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("api")
public class CountryREST {
	
	@Autowired
	private CountryService service;
	
	@GetMapping("/training/capital/{capital}")
	public Country getCapital(@PathVariable String capital) {
		return service.findByCapitalTrain(capital);
	}
	
	@GetMapping("/training/nome/{nome}")
	public Country getFlag(@PathVariable String nome) {
		return service.findByFlagTrain(nome);
	}
	
	@GetMapping("countries")
	public ResponseEntity<List<Country>> getAll() {
		return new ResponseEntity<List<Country>>(service.findCountries(), HttpStatus.OK);
	}
	
	@GetMapping("quiz")
	public List<Country> getRandomCountries() {
		List<Country> Paesi = service.findRandomCountries();
		Country corretto = Paesi.get(0);
		Collections.shuffle(Paesi);
		System.out.println(corretto.toString());
		return Paesi;
	}
}
