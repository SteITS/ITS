package com.trinal.demomegadex.entities;

import com.fasterxml.jackson.annotation.JsonIgnore;
import jakarta.persistence.*;

@Entity
@Table(name = "collections", schema = "dbo")
public class Collection {
    @EmbeddedId
    private CollectionId id;

    @Column(name = "quantity", nullable = false)
    private Integer quantity;

    @ManyToOne(fetch = FetchType.LAZY)
    @MapsId("idUser")
    @JoinColumn(name = "id_user", referencedColumnName = "id", nullable = false)
    private User user;

//    @ManyToOne(fetch = FetchType.LAZY)
//    @MapsId("idCard")
//    @JoinColumn(name = "id_card", referencedColumnName = "id", nullable = false)
//    private Card card;

    @Override
    public String toString() {
        return "Collection{" +
                "id=" + getId() +
                ", quantity=" + getQuantity() +
                ", user=" + user +
         //       ", card=" + card +
                '}';
    }

    public void setUser(User user) {this.user = user;}

    public CollectionId getId() {
        return id;
    }

    public void setId(CollectionId id) {
        this.id = id;
    }

    public Integer getQuantity() {
        return quantity;
    }

    public void setQuantity(Integer quantity) {
        this.quantity = quantity;
    }

}