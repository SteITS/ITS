package com.trinal.demomegadex.services;

import com.trinal.demomegadex.entities.Card;
import com.trinal.demomegadex.entities.User;
import com.trinal.demomegadex.repos.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class UserService {
    @Autowired
    private UserRepository userRepository;

    public List<User> getAllUsers() {
        return userRepository.findAll();
    }

    public Optional<User> getUser(int idUser) {
        return userRepository.findById(idUser);
    }
}