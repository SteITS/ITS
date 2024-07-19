package com.stwfy.controllers;

import java.util.Collections;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import com.stwfy.entities.Country;
import com.stwfy.services.CountryService;
@Controller
public class CountryController {

	@Autowired
	private CountryService service;


	private Country correctCountry;
	
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
	/*@GetMapping("quiz")
	public List<Country> getRandomCountries() {
		List<Country> Paesi = service.findRandomCountries();
		Country corretto = Paesi.get(0);
		Collections.shuffle(Paesi);
		System.out.println(corretto.toString());
		return Paesi;
	}*/
	
	
	@GetMapping("/quiz")
	public String getQuiz(Model model) {
	    List<Country> countries = service.findRandomCountries();
	    Collections.shuffle(countries); // Shuffle the list of countries

	    correctCountry = countries.get(0); // Select a new correct country
	    Collections.shuffle(countries); // Shuffle again to mix the options

	    model.addAttribute("correctCountry", correctCountry);
	    model.addAttribute("countries", countries);

	    return "quiz";
	}
	
	@PostMapping("/selectCountry")
    public String selectCountry(@RequestParam String countryId, Model model) {
        Country selectedCountry = service.getCountryById(countryId);

        if (selectedCountry.getId().equals(correctCountry.getId())) {
            model.addAttribute("result", "Correct!");
        } else {
            model.addAttribute("result", "Incorrect. The correct answer was " + correctCountry.getCapital());
        }

        return "result"; // Return a view to display the result
    }
}
	

