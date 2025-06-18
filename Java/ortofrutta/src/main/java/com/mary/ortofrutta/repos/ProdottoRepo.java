package com.mary.ortofrutta.repos;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.mary.ortofrutta.entities.Prodotto;

@Repository
public interface ProdottoRepo extends JpaRepository<Prodotto, Integer> {
    // Questo repository estende JpaRepository per fornire operazioni CRUD su Prodotto
    // Non sono necessari metodi aggiuntivi poiché JpaRepository fornisce già le operazioni di base 


}
