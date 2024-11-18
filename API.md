# Documentazione API

## Indice
1. [Richieste GET](#richieste-get)
    1. [Pagina Home (`/index`)](#pagina-home)
    2. [Redirect alla Home (`/`)](#redirect-alla-home)
    3. [Mostra Form di Registrazione (`/register`)](#mostra-form-di-registrazione)
    4. [Messaggio di Successo (`/success`)](#messaggio-di-successo)
    5. [Lista degli Utenti (`/users`)](#lista-degli-utenti)
    6. [Pagina di Login (`/login`)](#pagina-di-login)
    7. [Recupera Carte Filtrate (`/cards`)](#recupera-carte-filtrate)
    8. [Recupera Tutti gli Utenti (`/api/deb/users`)](#recupera-tutti-gli-utenti)
    9. [Recupera Utente Autenticato (`/api/auth/authUser`)](#recupera-utente-autenticato)

2. [Richieste POST](#richieste-post)
    1. [Registrazione Utente (`/register/save`)](#registrazione-utente)
    2. [Recupera Mazzi per ID Utente (`/api/auth/decksByUser`)](#recupera-mazzi-per-id-utente)
    3. [Aggiungi Mazzo (`/api/auth/addDeck`)](#aggiungi-mazzo)
    4. [Rimuovi Mazzo (`/deb/removeDeck`)](#rimuovi-mazzo)
    5. [Valida Mazzo (`/deb/validateDeck`)](#valida-mazzo)
    6. [Recupera Valutazioni per Mazzo (`/deb/getRatingsByDeck`)](#recupera-valutazioni-per-mazzo)
    7. [Recupera Tutte le Valutazioni (`/deb/ratings`)](#recupera-tutte-le-valutazioni)
    8. [Aggiorna Valutazione (`/api/auth/updateRating`)](#aggiorna-valutazione)
    9. [Rimuovi Valutazione (`/api/auth/removeRating`)](#rimuovi-valutazione)
    10. [Aggiorna Sleeve (`/api/auth/updateSleeve`)](#aggiorna-sleeve)
    11. [Rimuovi Sleeve (`/api/auth/removeSleeve`)](#rimuovi-sleeve)
    12. [Aggiorna Slot (`/api/auth/updateSlot`)](#aggiorna-slot)
    13. [Rimuovi Slot (`/api/auth/removeSlot`)](#rimuovi-slot)
    14. [Salva Slot (`/api/auth/saveSlots`)](#salva-slot)

---

## Richieste GET

### 1. Pagina Home
**Endpoint**: `/index`  
**Metodo**: GET  
**Descrizione**: Restituisce la pagina home.  
**Controller**: `AuthController`  

```java
@GetMapping("/index")
public String home(){
    return "index";
}
```
### 2. Mostra Form di Registrazione
**Endpoint**: `/register`  
**Metodo**: GET  
**Descrizione**: Mostra il form per la registrazione dell'utente.  
**Controller**: `AuthController`  

```java
@GetMapping("/register")
public String showRegistrationForm(Model model){
    UserDto user = new UserDto();
    model.addAttribute("user", user);
    return "register";
}
```
### 3. Lista degli Utenti
**Endpoint**: `/users`  
**Metodo**: GET  
**Descrizione**: Mostra una lista di tutti gli utenti registrati. 
**Controller**: `AuthController`  

```java
@GetMapping("/users")
public String users(Model model){
    List<UserDto> users = userService.findAllUsers();
    model.addAttribute("users", users);
    return "community";
}
```
### 4. Pagina di Login
**Endpoint**: `/login`  
**Metodo**: GET  
**Descrizione**: Restituisce la pagina di login.
**Controller**: `AuthController`  

```java
@GetMapping("/login")
public String login(){
    return "login";
}
```
### 5. Pagina di Login
**Endpoint**: `/cards`  
**Metodo**: GET  
**Descrizione**: Restituisce una lista di carte con filtri opzionali come Id, nome, supertype, tipo, subtype, set, e opzioni di paginazione.
**Controller**: `CardController`  

```java
@GetMapping("/cards")
public ResponseEntity<CardDto> getFilteredCards(
    @RequestParam(required = false) String Id,
    @RequestParam(required = false) String name,
    @RequestParam(required = false) String supertype,
    @RequestParam(required = false) String type,
    @RequestParam(required = false) String subtype,
    @RequestParam(required = false) String set,
    @RequestParam(defaultValue = "1") int page,
    @RequestParam(defaultValue = "Id") String orderBy,
    @RequestParam(defaultValue = "asc") String direction) 
{
    CardDto response = service.getFilteredCards(Id, name, supertype, type, subtype, set, page, orderBy, direction);
    return new ResponseEntity<>(response, HttpStatus.OK);
}
```

### 6. Recupera Tutti gli Utenti
**Endpoint**: `/api/deb/users`  
**Metodo**: GET  
**Descrizione**: Restituisce una lista di tutti gli utenti.
**Controller**: `UserController`  

```java
@GetMapping("deb/users")
public List<User> getAllUsers() {
    return userService.getAllUsers();
}
```
### 7. Recupera Tutti gli Utenti
**Endpoint**: `/api/auth/authUser`  
**Metodo**: GET  
**Descrizione**: Recupera l'utente attualmente autenticato.
**Controller**: `UserController`  

```java
@GetMapping("auth/authUser")
public ResponseEntity<User> getCurrentUser() {
    return ResponseEntity.ok(userService.getAuthenticatedUser());
}
```

## Richieste POST

### 1. Registrazione Utente
**Endpoint**: `/register/save`  
**Metodo**: POST 
**Descrizione**: Gestisce la registrazione dell'utente salvando i dati.
**Controller**: `AuthController`  

```java
@PostMapping("/register/save")
public String registration(@Valid @ModelAttribute("user") UserDto userDto,
                           BindingResult result,
                           Model model){
    User existingUser = userService.findUserByEmail(userDto.getEmail());

    if(existingUser != null && existingUser.getEmail() != null && !existingUser.getEmail().isEmpty()){
        result.rejectValue("email", null,
                "Esiste già un account registrato con lo stesso indirizzo email");
    }

    if(result.hasErrors()){
        model.addAttribute("user", userDto);
        return "/register";
    }

    userService.saveUser(userDto);
    return "redirect:/register?success";
}
```

### 2. Recupera Mazzi per ID Utente
**Endpoint**: `/api/auth/decksByUser`  
**Metodo**: POST 
**Descrizione**: Recupera i mazzi associati all'utente specificato tramite userId.
**Controller**: `DeckController`  

```java
@PostMapping("/auth/decksByUser")
public ResponseEntity<List<Deck>> getDecksByUserId(@RequestBody Map<String, Integer> requestBody) {
    int userId = requestBody.get("userId");

    User user = userService.findUserById(userId)
            .orElseThrow(() -> new RuntimeException("Utente non trovato con ID: " + userId));

    List<Deck> decks = deckService.getDecksByUser(user);

    return ResponseEntity.ok(decks);
}
```

### 3. Aggiungi Mazzo
**Endpoint**: `/api/auth/addDeck`  
**Metodo**: POST 
**Descrizione**: Aggiunge un nuovo mazzo o aggiorna un mazzo esistente per l'utente autenticato.
**Controller**: `DeckController`  

```java
@PostMapping("/auth/addDeck")
public ResponseEntity<Deck> addDeck(@RequestBody Deck deck){
    User user = userService.getAuthenticatedUser();
    deck.setUser(user);

    if(deckService.getDeckById(deck.getId()).isPresent()){
        if(deckService.getDeckById(deck.getId()).get().getUser() != user){
            throw new RuntimeException("ID Mazzo non corrisponde al proprietario");
        }
        deck.setSlots(deckService.getDeckById(deck.getId()).get().getSlots());
    }

    Deck newDeck = deckService.saveDeck(deck);
    return ResponseEntity.ok(newDeck);
}
```

### 3. Aggiungi Mazzo
**Endpoint**: `/deb/removeDeck`  
**Metodo**: POST 
**Descrizione**: Rimuove un mazzo di proprietà dell'utente autenticato.
**Controller**: `DeckController`  

```java
@PostMapping("/deb/removeDeck")
public ResponseEntity<String> removeDeck(@RequestBody Deck deck){
    User user = userService.getAuthenticatedUser();
    deck.setUser(user);

    if(deckService.getDeckById(deck.getId()).isPresent()
            && deckService.getDeckById(deck.getId()).get().getUser() != user){
        throw new RuntimeException("ID Mazzo non corrisponde al proprietario");
    }

    try {
        deckService.removeDeck(deck);
    } catch (Exception e) {
        throw new RuntimeException("Errore durante la rimozione del mazzo");
    }

    return ResponseEntity.ok("Mazzo rimosso con successo");
}
```