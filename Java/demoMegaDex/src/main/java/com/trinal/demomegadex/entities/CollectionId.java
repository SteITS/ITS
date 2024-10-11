package com.trinal.demomegadex.entities;

import jakarta.persistence.Column;
import jakarta.persistence.Embeddable;
import jakarta.persistence.ManyToOne;
import org.hibernate.Hibernate;
import org.hibernate.annotations.Nationalized;

import java.io.Serializable;
import java.util.Objects;

@Embeddable
public class CollectionId implements Serializable {
    private static final long serialVersionUID = -1271955463288281287L;

    @Column(name = "id_user", nullable = false)
    private int idUser;

    @Nationalized
    @Column(name = "id_card", nullable = false, length = 50)
    private String idCard;

    public int getIdUser() {
        return idUser;
    }

    public void setIdUser(int idUser) {
        this.idUser = idUser;
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
        CollectionId entity = (CollectionId) o;
        return Objects.equals(this.idUser, entity.idUser) &&
                Objects.equals(this.idCard, entity.idCard);
    }

    @Override
    public int hashCode() {
        return Objects.hash(idUser, idCard);
    }

}