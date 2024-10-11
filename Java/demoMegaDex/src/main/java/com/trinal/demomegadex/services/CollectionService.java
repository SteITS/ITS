package com.trinal.demomegadex.services;

import com.trinal.demomegadex.entities.Collection;
import com.trinal.demomegadex.repos.CollectionRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CollectionService {
    @Autowired
    private CollectionRepository collectionRepository;

    public Collection saveCollection(Collection collection) {
        return collectionRepository.save(collection);
    }
}
