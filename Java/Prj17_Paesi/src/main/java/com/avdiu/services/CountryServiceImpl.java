package com.avdiu.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.avdiu.entities.Country;
import com.avdiu.repos.CountryDAO;

@Service
public class CountryServiceImpl implements CountryService{

	@Autowired
	private CountryDAO dao;
	
	@Override
	public Country findByFlagTrain(String name) {
		return dao.findByName(name);
	}

	@Override
	public Country findByCapitalTrain(String capital) {
		return dao.findByCapital(capital);
	}
	@Override
	public List<Country> findCountries(){
		return dao.findAll();
	}
	
	@Override
	public List<Country> findRandomCountries(){
		return dao.findRandomCountries();
	}

}
