package com.stwfy.repos;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import com.stwfy.entities.Country;

public interface CountryDAO extends JpaRepository<Country, String> {

	Country findByName(String name);
	Country findByCapital(String capital);
	List<Country> findByPopulation(int population);
	
	@Query(value = "SELECT * FROM countriesv2 ORDER BY RAND() LIMIT 3", nativeQuery = true)
    List<Country> findRandomCountries();
}
