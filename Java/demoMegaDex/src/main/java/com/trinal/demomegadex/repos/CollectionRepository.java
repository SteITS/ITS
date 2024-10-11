package com.trinal.demomegadex.repos;

import com.trinal.demomegadex.entities.Collection;
import com.trinal.demomegadex.entities.CollectionId;
import org.springframework.data.jpa.repository.JpaRepository;

public interface CollectionRepository extends JpaRepository<Collection, CollectionId> {
}
