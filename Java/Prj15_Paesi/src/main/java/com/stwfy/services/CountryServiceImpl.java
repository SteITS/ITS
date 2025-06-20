package com.stwfy.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.stwfy.entities.Country;
import com.stwfy.repos.CountryDAO;
@Service
public class CountryServiceImpl implements CountryService {
	
	@Override
	public List<Country> getCountries() {
		// TODO Auto-generated method stub
		return dao.findAll();
	}
	
	@Autowired
	private CountryDAO dao;
	
	@Override
	public Country getCountryByName(String name) {
		// TODO Auto-generated method stub
		return dao.findByName(name);
	}

	@Override
	public Country getCountryByCapital(String capital) {
		// TODO Auto-generated method stub
		return dao.findByCapital(capital);
	}

	@Override
	public List<Country> getCountryByPopulation(int population) {
		// TODO Auto-generated method stub
		return dao.findByPopulation(population);
	}

	@Override
	public Country getCountryById(String id) {
		// TODO Auto-generated method stub
		return dao.findById(id).get();
	}
	
	@Override
	public List<Country> findRandomCountries(){
		return dao.findRandomCountries();
	}

	@Override
	public List<String> getNames() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<Country> getCapitals() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<String> getPopulations() {
		// TODO Auto-generated method stub
		return null;
	}

}
