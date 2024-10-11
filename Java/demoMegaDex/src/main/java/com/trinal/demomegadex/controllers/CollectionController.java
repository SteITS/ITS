package com.trinal.demomegadex.controllers;

import com.trinal.demomegadex.entities.Card;
import com.trinal.demomegadex.entities.Collection;
import com.trinal.demomegadex.entities.CollectionId;
import com.trinal.demomegadex.entities.User;
import com.trinal.demomegadex.services.CardService;
import com.trinal.demomegadex.services.CollectionService;
import com.trinal.demomegadex.services.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/")
public class CollectionController {
    @Autowired
    private CollectionService collectionService;
    @Autowired
    private UserService userService;

    @PostMapping("collection")
    public ResponseEntity<Collection> addCollection(@RequestBody Collection collectionRequest) {
        // Recupera l'utente dal database usando l'ID passato nella richiesta
        User user = userService.getUser(collectionRequest.getId().getIdUser())
                .orElseThrow(() -> new RuntimeException("User not found with ID: " + collectionRequest.getId().getIdUser()));

        // Crea la nuova Collection e associa l'utente
        Collection collection = new Collection();
        System.out.println(user.toString());
        collection.setUser(user);  // Associa l'utente
        // Setta altri campi di Collection come necessario

        // Salva la collection
        Collection savedCollection = collectionService.saveCollection(collection);
        return ResponseEntity.ok(savedCollection);
//        Collection savedCollection = collectionService.saveCollection(collection);
//        return ResponseEntity.ok(savedCollection);
    }

}
