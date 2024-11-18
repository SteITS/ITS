# Documentazione API

## Indice
1. [Chiamate GET](#chiamate-get)
   - [/index](#1-index)
   - [/](#2-root)
   - [/register](#3-register)
   - [/success](#4-success)
   - [/users](#5-users)
   - [/login](#6-login)
   - [/cards](#7-cards)
   - [/api/deb/users](#8-apidebusers)
   - [/api/auth/authUser](#9-apiauthauthuser)
2. [Chiamate POST](#chiamate-post)
   - [/register/save](#1-registersave)
   - [/api/auth/decksByUser](#2-apiauthdecksbyuser)
   - [/api/auth/addDeck](#3-apiauthadddeck)
   - [/api/deb/removeDeck](#4-apidebremovedeck)
   - [/api/deb/validateDeck](#5-apidebvalidatedeck)
   - [/api/deb/getRatingsByDeck](#6-apidebgetratingsbydeck)
   - [/api/deb/ratings](#7-apidebratings)
   - [/api/auth/updateRating](#8-apiauthupdaterating)
   - [/api/auth/removeRating](#9-apiauthremoverating)
   - [/api/auth/updateSleeve](#10-apiauthupdatesleeve)
   - [/api/auth/removeSleeve](#11-apiauthremovesleeve)
   - [/api/auth/updateSlot](#12-apiauthupdateslot)
   - [/api/auth/removeSlot](#13-apiauthremoveslot)
   - [/api/auth/saveSlots](#14-apiauthsaveslots)
3. [Chiamate DELETE](#chiamate-delete)
   - [/api/auth/deleteDeck/{id}](#1-apiauthdeletedeckid)

---

## Chiamate GET

### 1. `/index`
- **Descrizione:** Restituisce la vista della home page.
- **Metodo:** `GET`
- **Risposta:** Restituisce la vista della pagina "index".

---

### 2. `/`
**Descrizione:** Reindirizza alla home page.

**Metodo:** `GET`

**Risposta:** Esegue un redirect verso `/index`.

---

### 3. `/register`
**Descrizione:** Mostra il form di registrazione utente.

**Metodo:** `GET`

**Risposta:** Restituisce il form di registrazione.

---

### 4. `/success`
**Descrizione:** Mostra un messaggio di successo per l'autenticazione.

**Metodo:** `GET`

**Risposta:** Restituisce un oggetto `User` autenticato come `ResponseEntity`.

---

### 5. `/users`
**Descrizione:** Mostra la lista degli utenti registrati.

**Metodo:** `GET`

**Risposta:** Restituisce la vista della pagina "community" con la lista degli utenti.

---

### 6. `/login`
**Descrizione:** Restituisce la vista per il login.

**Metodo:** `GET`

**Risposta:** Restituisce la vista della pagina di login.

---

### 7. `/cards`
**Descrizione:** Recupera una lista filtrata di carte. Può essere filtrata utilizzando parametri opzionali come `Id`, `name`, `supertype`, `type`, `subtype`, `set`, `page`, `orderBy`, e `direction`.

**Metodo:** `GET`

**Parametri:**
- `Id` (opzionale)
- `name` (opzionale)
- `supertype` (opzionale)
- `type` (opzionale)
- `subtype` (opzionale)
- `set` (opzionale)
- `page` (default = 1)
- `orderBy` (default = "Id")
- `direction` (default = "asc")

**Risposta:** Restituisce un oggetto `CardDto` contenente le carte filtrate.

---

### 8. `/api/deb/users`
**Descrizione:** Recupera la lista di tutti gli utenti registrati.

**Metodo:** `GET`

**Risposta:** Restituisce una lista di oggetti `User`.

---

### 9. `/api/auth/authUser`
**Descrizione:** Recupera i dati dell'utente autenticato.

**Metodo:** `GET`

**Risposta:** Restituisce l'oggetto `User` autenticato come `ResponseEntity`.

---

## Chiamate POST

### 1. `/register/save`
**Descrizione:** Registra un nuovo utente.

**Metodo:** `POST`

**Body:**
- `UserDto` con i dati dell'utente.

**Risposta:** Reindirizza al form di registrazione con un messaggio di successo o di errore.

---

### 2. `/api/auth/decksByUser`
**Descrizione:** Recupera i mazzi associati a un utente specifico in base al suo ID.

**Metodo:** `POST`

**Body:**
- Un oggetto `Map<String, Integer>` contenente l'ID dell'utente.

**Risposta:** Restituisce una lista di oggetti `Deck` associati all'utente.

---

### 3. `/api/auth/addDeck`
**Descrizione:** Aggiunge un nuovo mazzo per l'utente autenticato.

**Metodo:** `POST`

**Body:**
- Un oggetto `Deck` con i dati del mazzo.

**Risposta:** Restituisce l'oggetto `Deck` appena aggiunto.

---

### 4. `/api/deb/removeDeck`
**Descrizione:** Rimuove un mazzo esistente.

**Metodo:** `POST`

**Body:**
- Un oggetto `Deck` con i dati del mazzo da rimuovere.

**Risposta:** Restituisce un messaggio di conferma della rimozione.

---

### 5. `/api/deb/validateDeck`
**Descrizione:** Valida un mazzo secondo le regole di gioco.

**Metodo:** `POST`

**Body:**
- Una lista di oggetti `Slot` che rappresentano le carte del mazzo.

**Risposta:** Restituisce un oggetto `DeckPass` con i risultati della validazione.

---

### 6. `/api/deb/getRatingsByDeck`
**Descrizione:** Recupera i voti associati a un mazzo specifico.

**Metodo:** `POST`

**Body:**
- Un oggetto `Deck` contenente l'ID del mazzo.

**Risposta:** Restituisce una lista di oggetti `Rating`.

---

### 7. `/api/deb/ratings`
**Descrizione:** Recupera tutti i voti presenti.

**Metodo:** `POST`

**Risposta:** Restituisce una lista di oggetti `Rating`.

---

### 8. `/api/auth/updateRating`
**Descrizione:** Aggiorna o aggiunge un voto per un mazzo.

**Metodo:** `POST`

**Body:**
- Un oggetto `Rating` con i dati del voto.

**Risposta:** Restituisce l'oggetto `Rating` aggiornato.

---

### 9. `/api/auth/removeRating`
**Descrizione:** Rimuove un voto associato a un mazzo.

**Metodo:** `POST`

**Body:**
- Un oggetto `Rating` con i dati del voto da rimuovere.

**Risposta:** Restituisce un messaggio di conferma della rimozione.

---

### 10. `/api/auth/updateSleeve`
**Descrizione:** Aggiorna o rimuove una `Sleeve` (una protezione delle carte).

**Metodo:** `POST`

**Body:**
- Un oggetto `Sleeve` con i dati della protezione.

**Risposta:** Restituisce l'oggetto `Sleeve` aggiornato o conferma la rimozione.

---

### 11. `/api/auth/removeSleeve`
**Descrizione:** Rimuove una `Sleeve` esistente.

**Metodo:** `POST`

**Body:**
- Un oggetto `Sleeve` con i dati della protezione da rimuovere.

**Risposta:** Restituisce un messaggio di conferma della rimozione.

---

### 12. `/api/auth/updateSlot`
**Descrizione:** Aggiunge o rimuove uno `Slot` (una posizione nel mazzo per una carta specifica).

**Metodo:** `POST`

**Body:**
- Un oggetto `Slot` con i dati dello slot.

**Risposta:** Restituisce l'oggetto `Slot` aggiornato o conferma la rimozione.

---

### 13. `/api/auth/removeSlot`
**Descrizione:** Rimuove uno `Slot` esistente.

**Metodo:** `POST`

**Body:**
- Un oggetto `Slot` con i dati dello slot da rimuovere.

**Risposta:** Restituisce un messaggio di conferma della rimozione.

---

### 14. `/api/auth/saveSlots`
**Descrizione:** Aggiunge una lista di `Slot`.

**Metodo:** `POST`

**Body:**
- Una lista di oggetti `Slot` da aggiungere.

**Risposta:** Restituisce la lista degli slot aggiunti.

---

## Chiamate DELETE

### 1. `/api/auth/deleteDeck/{id}`
**Descrizione:** Elimina un mazzo specifico in base al suo ID.

**Metodo:** `DELETE`

**Parametri:**
- `id` (richiesto): l'ID del mazzo da eliminare.

**Risposta:** Restituisce un messaggio di conferma dell'eliminazione del mazzo.