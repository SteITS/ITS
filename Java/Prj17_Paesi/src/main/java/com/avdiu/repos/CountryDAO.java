package com.avdiu.repos;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import com.avdiu.entities.Country;

public interface CountryDAO extends JpaRepository<Country, String> {
	
	Country findByName(String id);//trova per bandiera
	Country findByCapital(String capital);//trova per capitale
	
	@Query(value = "SELECT * FROM countriesv2 ORDER BY RAND() LIMIT 3", nativeQuery = true)
    List<Country> findRandomCountries();
}
