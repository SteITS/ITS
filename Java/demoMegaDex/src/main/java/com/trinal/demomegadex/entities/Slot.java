package com.trinal.demomegadex.entities;

import jakarta.persistence.*;
import org.hibernate.annotations.Nationalized;

@Entity
@Table(name = "slots", schema = "dbo")
public class Slot {
    @EmbeddedId
    private SlotId id;

    @Nationalized
    @Column(name = "quantity", nullable = false, length = 10)
    private String quantity;

    @ManyToOne(fetch = FetchType.LAZY)
    @MapsId("idUser")
    @JoinColumn(name = "id_deck", referencedColumnName = "id", nullable = false)
    private Deck deck;

    public SlotId getId() {
        return id;
    }

    public void setId(SlotId id) {
        this.id = id;
    }

    public String getQuantity() {
        return quantity;
    }

    public void setQuantity(String quantity) {
        this.quantity = quantity;
    }

}