package com.avdiu.services;

import java.util.List;

import com.avdiu.entities.Country;

public interface CountryService {
	
	Country findByFlagTrain(String name);
	Country findByCapitalTrain(String capital);
	List<Country> findCountries();
	List<Country> findRandomCountries();
	

}
