package com.stwfy.controllers;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

import com.stwfy.entities.Country;
import com.stwfy.services.CountryService;

@RestController
public class CountryRest {

	@Autowired
	private CountryService service;
	
	@GetMapping("countries")
	public ResponseEntity<List<Country>> getCountries(){
		return new ResponseEntity<List<Country>>(service.getCountries(),HttpStatus.OK);
	}
	@GetMapping("countries/{capital}")
	public Country getCountryByCapital(@PathVariable String capital){
		return service.getCountryByCapital(capital);
	}
	@GetMapping("name/{name}")
	public Country  getCountryByName(@PathVariable String name) {
		return service.getCountryByName(name);
	}
/*	@GetMapping("random")
	public List<Country> getRandomCountry() {
		List<Country> list = new ArrayList<>();
		for (int i = 0; i < 3; i++) {
			rand.next
		}
		return service.getCountries();
	}*/
	@GetMapping("quiz")
	public List<Country> getRandomCountries() {
		List<Country> Paesi = service.findRandomCountries();
		Country corretto = Paesi.get(0);
		Collections.shuffle(Paesi);
		System.out.println(corretto.toString());
		return Paesi;
	}
}
