# Struttura Database

### Made By: Stanescu Stefan

`File di partenza:`
- customers_relational.csv
- dishes_relational.csv
- orders_relational.csv
- restaurants_relational.csv

`Annotazioni:`
- [1] I file provengono da un `database relazionale` che seppur supportati in MongoDB riducono le performance dovendo utilizzare comandi `$lookup`.
- [2] In `orders_relational.csv` sono da deserializzare ed embeddare le voci "dish_id", "restaurant_id" e "customer_id". Il tutto per semplificare le query di ricerca e migliorare le performance in un database NoSQL. 
- [3] In `customers` e `restaurants` sono da embeddare gli indirizzi sempre per sfruttare un sistema NoSQL.

`Svolgimento`:

- Importato i file csv così come sono inizialmente con comando:

        mongoimport --db restaurant_db --collection dishes --type csv --headerline --file dishes_relational.csv

- Per ottimizzare il tempo a disposizione è stato richiesto a una `LLM` uno script per il punto [2](#2) dalle annotazioni. La domanda è stata:

        I'd like a python script to embbed customers,restaurants and dishes in the "orders" collection

   che ha generato un codice che è stato salavato in un file `embbed_orders.py` che troverà nella consegna e che ha avuto l'effetto sperato.

- Partendo dallo script generato nel punto precedente, è stato modificato a mano per svolgere il punto [3](#3) delle annotazioni. Gli script utilizzati sono nella consegna con i seguenti file: `embbed_customers.py` e `embbed_restaurants.py`.


## Esempio di struttura finale:

`customers`:

        {
        "_id": "c1",
        "name": "Mario Rossi",
        "email": "mario.rossi@example.com",
        "delivery_address": {
            "street": "Via Verdi 20",
            "city": "Milano",
            "zip": 20122
        }
        }

`dishes`:

        {
        "_id": "d1",
        "restaurant_id": "r1",
        "name": "Pizza Margherita",
        "description": "Classic pizza with tomato, mozzarella, and basil",
        "price": 8.5,
        "vegetarian": "True"
        }

`orders`:

        {
        "_id": {
            "$oid": "677fd9da764f046be4159b07"
        },
        "customer": {
            "name": "Mario Rossi",
            "email": "mario.rossi@example.com",
            "delivery_address": {
            "street": "Via Verdi 20",
            "city": "Milano",
            "zip": 20122
            }
        },
        "restaurant": {
            "name": "La Bella Italia",
            "address": {
            "street": "Via Roma 10",
            "city": "Milano",
            "zip": 20100
            },
            "cuisine": "Italian"
        },
        "dishes": [
            {
            "name": "Pizza Margherita",
            "description": "Classic pizza with tomato, mozzarella, and basil",
            "price": 8.5,
            "quantity": 2
            }
        ],
        "order_date": "2024-01-01T12:00:00Z",
        "status": "delivered",
        "total_cost": 17
        }

`restaurants`:

        {
        "_id": "r2",
        "name": "Sushi World",
        "cuisine": "Japanese",
        "delivery_address": {
            "street": "Akihabara 3",
            "city": "Tokyo",
            "zip": 10100
        }
        }


# Queries
`Q1: Trova tutti i ristoranti che offrono cucina italiana e hanno almeno un piatto vegetariano nel menu.`

        db.restaurants.aggregate([
        {
            $lookup: {
            from: "dishes",
            localField: "_id",
            foreignField: "restaurant_id",
            as: "menu"
            }
        },
        {
            $match: {
            cuisine: "Italian",
            "menu.vegetarian": "True"
            }
        },
        {
            $project: {
            _id: 0,
            name: 1,
            cuisine: 1
            }
        }
        ]);

`$lookup:` Collega la collezione restaurants con la collezione dishes, creando un campo menu contenente tutti i piatti del ristorante.<br>
`$match:` Filtra i ristoranti con cucina italiana  e controlla se nel campo menu c'è almeno un piatto vegetariano.<br>
`$project:` Seleziona i campi desiderati, ovvero il nome del ristorante, il tipo di cucina ottenuti usando $filter.

`Q2: Elenca tutti gli ordini effettuati da un cliente specifico (dato il suo ID) negli ultimi 30 giorni.`

    db.orders.aggregate([
    {
        $match: {
        "customer._id": "ID_CLIENTE", // Sostituisci con l'ID del cliente
        order_date: {
            $gte: { $dateSubtract: { startDate: "$$NOW", unit: "day", amount: 30 } }
        }
        }
    },
    {
        $project: {
        _id: 0,
        order_date: 1,
        status: 1,
        total_cost: 1,
        dishes: 1,
        restaurant: "$restaurant.name"
        }
    }
    ]);

`$match:`
    Filtra gli ordini in base all'ID del cliente specificato.
    Filtra gli ordini con una data (order_date) maggiore o uguale a 30 giorni fa.
<br>
`$project:`
    Specifica i campi da includere nel risultato.



`Q3: Calcola il numero totale di ordini effettuati per ciascun ristorante.`

        db.orders.aggregate([
        {
            $group: {
            _id: "$restaurant.name", // Raggruppa per nome del ristorante
            total_orders: { $sum: 1 } // Conta il numero totale di ordini
            }
        },
        {
            $sort: { total_orders: -1 } // Ordina in ordine decrescente di numero di ordini
        }
        ]);



`Q4: Aggiorna lo stato di un ordine (dato il suo ID) a "consegnato".`

        db.orders.updateOne(
        { _id: ObjectId("677fd9da764f046be4159b0a") }, // Sostituisci con l'ID dell'ordine
        { $set: { status: "delivered" } }
        );



`Q5: Trova i clienti che hanno effettuato ordini con un costo totale superiore a 100€ nell'ultimo mese.`

        db.orders.aggregate([
        {
            $match: {
            order_date: {
                $gte: { $dateSubtract: { startDate: "$$NOW", unit: "day", amount: 30 } }
            },
            total_cost: { $gt: 100 }
            }
        },
        {
            $group: {
            _id: "$customer.email", // Raggruppa per email del cliente
            name: { $first: "$customer.name" }, // Prendi il nome del cliente
            total_spent: { $sum: "$total_cost" } // Somma il costo totale degli ordini
            }
        },
        {
            $sort: { total_spent: -1 } // Ordina in base alla spesa totale in ordine decrescente
        }
        ]);

`$match:`
  Filtra gli ordini effettuati negli ultimi 30 giorni e confronta la data di ordine con $gte (maggiore o uguale).
  Seleziona solo gli ordini con total_cost superiore a 100.

`$group:`
    Raggruppa i documenti per il campo $customer.email per ogni cliente.
    Utilizza $first per ottenere il nome del cliente.
    Calcola la somma totale delle spese di ciascun cliente usando $sum.

`$sort:`
    Ordina i risultati in base alla spesa totale in ordine decrescente.


## P.S.

- Potenzialmente si potrebbe anche embeddare i piatti (dishes) dentro a restaurant e eliminare così la collezione dishes.