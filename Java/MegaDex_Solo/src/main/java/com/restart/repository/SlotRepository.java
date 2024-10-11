package com.restart.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.restart.entity.Slot;
import com.restart.entity.SlotId;

public interface SlotRepository extends JpaRepository<Slot	, SlotId> {

}
