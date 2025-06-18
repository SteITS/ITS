# Esame Finale noSQL - Stanescu Stefan

## Uso di LLM
ChatGPT è stato utilizzato per migliorare la formattazione e ristrutturare il documento, adattando il contenuto iniziale in una versione più chiara e leggibile,
 è stato usato anche per scrivere la query n. 5.

## Analisi dell'esercizio

L'esercizio richiede la creazione di un database MongoDB a partire da sei file CSV. I dati di partenza sono strutturati in modo tradizionale,
 probabilmente provenienti da un database SQL, e quindi non sono perfettamente adattati per un database NoSQL come MongoDB. 
 Il compito è ristrutturare i dati in un formato ottimizzato per una base di dati NoSQL a documenti.

### Struttura di partenza

I file CSV iniziali contengono le seguenti informazioni:

1. **utente**:
   - `id_utente`, `nome`, `cognome`, `email`, `telefono`, `data_creazione`

2. **spedizione**:
   - `id_spedizione`, `id_ordine`, `id_indirizzo`, `data_spedizione`, `stato_spedizione`, `tracking_number`

3. **ordine**:
   - `id_ordine`, `id_utente`, `data_ordine`, `stato`, `importo_totale`

4. **indirizzo_spedizione**:
   - `id_indirizzo`, `id_utente`, `destinatario_nome`, `destinatario_cognome`, `via`, `citta`, `cap`, `provincia`, `nazione`

5. **fiore**:
   - `id_fiore`, `nome`, `descrizione`, `prezzo`, `quantita_disponibile`, `data_inserimento`

6. **dettaglio**:
   - `id_ordine`, `id_fiore`, `quantita`, `prezzo_unitario`

### Struttura finale

La ristrutturazione dei dati ha portato alla seguente struttura finale del database:

1. **orders**:
   - `_id`, `id_utente`, `data_ordine`, `stato`, `importo_totale`, 
   - `dettagli` (array che contiene i dati dei fiori ordinati): 
     - `id_fiore`, `quantita`, `prezzo_unitario`, `nome` dei fiori

2. **flowers**:
   - `_id`, `id_fiore`, `nome`, `descrizione`, `prezzo`, `quantita_disponibile`, `data_inserimento`

3. **shipments**:
   - `_id`, `id_ordine`, `data_spedizione`, `stato_spedizione`, `tracking_number`, 
   - `destinatario`: 
     - `nome`, `cognome`, `via`, `citta`, `cap`, `provincia`, `nazione`

4. **users**:
   - `_id`, `nome`, `cognome`, `email`, `telefono`, `data_creazione`,
   - `indirizzi` (array che contiene i dati degli indirizzi di spedizione): 
     - `destinatario_nome`, `destinatario_cognome`, `via`, `citta`, `cap`, `provincia`, `nazione`

### Spiegazione della Ristrutturazione

1. **Fiore**:
   - La collezione `fiore` è stata rinominata in `flowers`, ma il resto della struttura è rimasto invariato.

2. **Indirizzo Spedizione**:
   - La collezione `indirizzo_spedizione` è stata embedded nella collezione `users`. In seguito, la collezione `indirizzo_spedizione` è stata eliminata.
   
3. **Dettaglio**:
   - La collezione `dettaglio` è stata embedded nella collezione `orders`, includendo informazioni dettagliate sugli articoli ordinati
    (fiori, quantità, prezzo unitario). La collezione `dettaglio` è stata quindi eliminata.

4. **Spedizione**:
   - La collezione `spedizione` è stata rinominata in `shipments` e la sua struttura è stata modificata per includere l'indirizzo
    di spedizione come campo embedded all'interno del documento di spedizione. La collezione `indirizzo_spedizione` non esiste più separatamente.

5. **Utente**:
   - La collezione `utente` è stata rinominata in `users`. Ogni documento utente ora contiene un array di indirizzi di spedizione,
    che consente di associare più indirizzi a ciascun utente. 

6. **Ordini**:
   - La collezione `ordine` è stata rinominata in `orders` e ora contiene un array di dettagli degli ordini (fiori ordinati).
    Questo permette di avere un documento ordinato con tutte le informazioni necessarie senza dover fare riferimenti a più collezioni.

### Conclusioni

La modifica strutturale dei dati è stata effettuata manualmente tramite la GUI di MongoDB Compass, sfruttando le capacità di MongoDB di
 gestire documenti embedded, al fine di ottimizzare le operazioni di lettura e scrittura in un contesto NoSQL. Con questa nuova struttura,
  le operazioni sui dati diventano più veloci e più semplici, grazie alla riduzione del numero di join necessari per recuperare informazioni
   da più tabelle.

#### NB

Sono rimaste delle ridondanze di ID ad esempio nella collezione `"flowers"`.

# Query

### Q1: Trova tutti i fiori con prezzo superiore a un valore (es. 3€) e quantità disponibile maggiore di 50

    db.flowers.find({
    prezzo: { $gt: 3 },
    quantita_disponibile: { $gt: 50 }
    })

`$match:` Filtra i fiori solo se il prezzo è maggiore di 3€ utilizzando $gt e se la quantità è maggiore a 50, sempre utilizzando $gt.

### Q2: Elenca gli ordini effettuati da un determinato utente (dato il suo _id o la sua email) negli ultimi 30 giorni
    db.orders.aggregate([
    { 
        $match: { 
        data_ordine: { 
            $gte: new ISODate(new Date().setDate(new Date().getDate() - 30))
        },
        $or: [ // Cerca per _id utente o email
            { "id_utente": USER_ID }, // Sostituisci USER_ID con l'ID dell'utente
            { "email": "USER_EMAIL" } // Sostituisci USER_EMAIL con l'email dell'utente
        ]
        }
    }
    ])
`$match:` data_ordine: Filtra gli ordini effettuati negli ultimi 30 giorni, utilizza l'operatore $gte con la data corrente meno 30 giorni ,  `$or` per cercare gli ordini che appartengono a un determinato utente.

### Q3: Calcola il numero totale di ordini  per ciascun fiore
    db.orders.aggregate([
    {
        $unwind: "$dettagli" // "Unwind" il campo dettagli per separare ogni fiore ordinato
    },
    {
        $group: { 
        _id: "$dettagli.id_fiore",
        total_orders: { $sum: "$dettagli.quantita" } 
        }
    },
    {
        $lookup: { 
        from: "flowers",
        localField: "_id",
        foreignField: "id_fiore",
        as: "flower_details"
        }
    },
    {
        $unwind: "$flower_details"
    },
    {
        $project: {
        _id: 0,
        id_fiore: "$_id", 
        nome: "$flower_details.nome",
        total_orders: 1
        }
    }
    ])

`$unwind`: Separiamo l'array dettagli in modo che ogni fiore ordinato venga trattato come un documento separato.

`$group`: Raggruppiamo i documenti in base al campo dettagli.id_fiore (l'ID del fiore). Poi, utilizziamo l'operatore $sum per sommare la quantità ordinata di ciascun fiore.

`$lookup`: Eseguiamo un'operazione di join con la collezione flowers per ottenere i dettagli del fiore. Usiamo l'operatore $lookup per collegare i dati dei fiori usando l'ID del fiore.

`$unwind`: Unwind per ottenere i dettagli del fiore come un singolo oggetto anziché un array.

`$project`: Per selezionare i campi che vogliamo visualizzare nel risultato finale.

### Q4: Aggiorna lo stato di un ordine (dato l’ID) a “consegnato”.

    db.orders.updateOne(
    { "_id": ORDER_ID }, // Cerca l'ordine con il dato _id
    { 
        $set: { "stato": "consegnato" } // Imposta lo stato dell'ordine a "consegnato"
    }
    )

`updateOne()`: Aggiorna un singolo documento che corrisponde al criterio di ricerca. In questo caso, l'_id.

`$set`: Viene utilizzato per aggiornare il valore di un campo esistente. In questo caso, stato a "consegnato".

### Q5: Trova gli utenti che hanno effettuato ordini con un importo totale superiore a 100€ nell’ultimo mese.

    db.orders.aggregate([
    {
        $addFields: {
        data_ordine_date: { 
            $dateFromString: { 
            dateString: "$data_ordine", // Converti la stringa in formato data
            format: "%Y-%m-%d %H:%M:%S" // Specifica il formato della data nella stringa
            }
        }
        }
    },
    {
        $match: {
        data_ordine_date: { 
            $gte: new Date(new Date().setMonth(new Date().getMonth() - 1)) // Ordini degli ultimi 30 giorni
        },
        importo_totale: { $gt: 100 } // Ordini con importo superiore a 100€
        }
    },
    {
        $group: {
        _id: "$id_utente", // Raggruppa per id_utente
        total_spent: { $sum: "$importo_totale" } // Somma degli importi totali per ciascun utente
        }
    },
    {
        $match: {
        total_spent: { $gt: 100 } // Considera solo gli utenti che hanno speso più di 100€
        }
    },
    {
        $lookup: {
        from: "users", // Unisci con la collezione "users" per ottenere i dettagli dell'utente
        localField: "_id", // Unisci con id_utente
        foreignField: "_id", // Confronta con _id della collezione users
        as: "user_details" // Dettagli dell'utente come array
        }
    },
    {
        $unwind: "$user_details" // Unwind per ottenere i dettagli dell'utente
    },
    {
        $project: {
        _id: 0, // Escludi _id
        id_utente: "$_id", // Mostra l'id_utente
        nome: "$user_details.nome", // Mostra il nome dell'utente
        cognome: "$user_details.cognome", // Mostra il cognome
        email: "$user_details.email", // Mostra l'email
        total_spent: 1 // Mostra il totale speso
        }
    }
    ])



`$addFields`:
    Usiamo $addFields per aggiungere un nuovo campo, data_ordine_date, che converte la stringa contenente la data in un oggetto data, utilizzando $dateFromString.
    Il formato specificato è %Y-%m-%d %H:%M:%S, che corrisponde al formato della data nel tuo campo data_ordine.

`$match`:
    Dopo aver aggiunto il campo data_ordine_date, confrontiamo questo nuovo campo con la data attuale, utilizzando $gte per selezionare gli ordini effettuati negli ultimi 30 giorni.
    Filtriamo anche gli ordini con un importo_totale maggiore di 100€.

`$group`:
    Raggruppiamo gli ordini per id_utente e sommiamo il importo_totale per ciascun utente.

`$match`:
    Filtriamo ulteriormente gli utenti che hanno speso più di 100€ in totale.

`$lookup`:
    Eseguiamo un join con la collezione users per ottenere i dettagli dell'utente (nome, cognome, email).

`$unwind`:
    Usiamo $unwind per ottenere i dettagli dell'utente come oggetti separati.



