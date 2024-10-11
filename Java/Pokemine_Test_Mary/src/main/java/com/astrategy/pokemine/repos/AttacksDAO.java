package com.astrategy.pokemine.repos;

import com.astrategy.pokemine.entities.Attacks;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface AttacksDAO extends JpaRepository<Attacks, Integer> {
    List<Attacks> findAll();
    List<Attacks> findAllById(int id);
}
