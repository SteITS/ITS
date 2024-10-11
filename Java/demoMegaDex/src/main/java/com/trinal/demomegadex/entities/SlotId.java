package com.trinal.demomegadex.entities;

import jakarta.persistence.Column;
import jakarta.persistence.Embeddable;
import org.hibernate.Hibernate;
import org.hibernate.annotations.Nationalized;

import java.io.Serializable;
import java.util.Objects;

@Embeddable
public class SlotId implements Serializable {
    private static final long serialVersionUID = 626333674840303834L;
    @Column(name = "id_deck", nullable = false)
    private Integer idDeck;

    @Nationalized
    @Column(name = "id_card", nullable = false, length = 50)
    private String idCard;

    public Integer getIdDeck() {
        return idDeck;
    }

    public void setIdDeck(Integer idDeck) {
        this.idDeck = idDeck;
    }

    public String getIdCard() {
        return idCard;
    }

    public void setIdCard(String idCard) {
        this.idCard = idCard;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || Hibernate.getClass(this) != Hibernate.getClass(o)) return false;
        SlotId entity = (SlotId) o;
        return Objects.equals(this.idCard, entity.idCard) &&
                Objects.equals(this.idDeck, entity.idDeck);
    }

    @Override
    public int hashCode() {
        return Objects.hash(idCard, idDeck);
    }

}