package com.stwfy.services;

import java.util.List;

import com.stwfy.entities.Country;

public interface CountryService {

	Country getCountryByName(String name);
	Country getCountryByCapital(String capital);
	List<Country> getCountryByPopulation(int population);
	Country getCountryById(String id);
	
	List<String> getNames();
	List<Country> getCapitals();
	List<String> getPopulations();
	List<Country> getCountries();
	
}
