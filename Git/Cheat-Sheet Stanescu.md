# Version Control

Piccola guida personale e a scopo di valutazione per l'utilizzo di git

## caratteristiche di git

`Repository`: Archivio del codice, puo' essere in locale o remoto

`Push`:Inviare delle modifiche al repository.

`Fetch/Pull`:Ricevere delle modifiche dal repository

`Branching model`: Git permette ed incoraggia la creazione di diverse versioni del codice che possono essere indipendenti tra loro. Per navigare, creare ed eliminare queste versioni bastano pochi secondi.

E' una struttura centralizzata che permette di sincronizzare l’accesso al repository. Impedisce che qualcuno modifichi il repo se nel mentre sono state fatte delle modifiche da altri.

Diversi dev hanno la possibilita' di creare una copia completa del repo ed operare tutti i cambiamenti che desiderano sulla loro copia. Possono chiedere al proprietario della repo di aggiornare.


## Comandi bash

- cat -> `stampa a schermo file selezionati`

- $ cat $HOME/.gitconfig -> `stampa il config globale, non della sola repo`

- cat .git/config -> `mostra il file config come username e mail`

- touch -> `crea un file vuoto; es. - touch README.md`

- ls -la -> `mostra tutti file dell directory in cui ci si trova, inclusi i file nascosti`

- cd -> `change directory`

- pwd -> `stampa il percorso in cui sei`

- mkdir -> `crea cartella`

## Comandi git

- $ git config user.email stefan.stanescu@edu.itspiemonte.it -> 
` Configura la mail `

- git config user.name Stefan Stanescu -> `Configura username`

- git init -> `Crea progetto git da 0, riempie la cartella .git`

- git status -> `Visualizza lo stato della directory di lavoro e della staging area (spammalo pure nel sonno)`

- git add file -> `Aggiungi allo staging il file selezionato, prima di committare`

- git add . -> `Aggiungi allo staging tutta la repo invece di specificare un solo file`

- git commit -> `Registra un pacchetto di informazioni, apre l'editor di testo per implementare il commento`

- git commit -m "aggiunta prima riga readme" -> `-m utilizzato per commentare direttamente dalla bash`

- git commit -amend -> `Modifica il messaggio di un commit`

- vim.txt 'or' nano.txt -> `Editor di testo in console, in alternativa` **vedi seguente**

- code file -> `Utilizza VSCode come editor di testo`

- git mv -> `Sposti o rinomini il nome di un file o directory`

- git rm file -> `'rimuovi un file' dallo staging e dalla directory di lavoro`

- git rm -cached 'file' -> `Rimuovi dallo stage dell’add il file specificato`

- git stash -> `Salva senza committare  dei cambiamenti, mette in un 'cassetto', non appare piu' in git status`

- git stash pop -> `Toglie dal 'cassetto' le modifiche salvate, possibile commitare`

- .gitignore -> `Il file .gitignore serve a escludere dai commit i file specificati all’interno`

## Comandi legati a log e branch

- git log -> `Log dei commit`

- git log --pretty=oneline -> `Log in una riga per commit`

- git log --pretty=oneline --all -graph --> `Visualizzazione dei commit in una riga ciascuno e stampa albero dei branch`

- git show ***** -> `Log dettagliato di un commit specifico`

- git diff ***** -> `Log dal commit specificato fino alla versione attuale`

- git diff ***** ***** -> `Log dal primo commit specificato fino al secondo commit spec.`

- $ git checkout -b feat/nuovoRamo -> `Crea un nuovo branch. Sono rami del main utilizzati per modificare e creare codice senza fare casino sull'originale`

- git branch -> `Stampa branch`

- git checkout ****** -> `per spostarsi tra branch` **ex: git checkout feat/nuovoRamo1**

- git merge feat/nuovoRamo1 -> `Merge del branch, unisce il branch al master, puo' creare conflitti se e' stato modificato un file gia' esistente nel main.`

- git rebase main -> ` Da utilizzare con **attenzione** quando si vuole mergiare un branch partito da un main datato`


## Comandi legati alle chiavi SSH

- $ ssh-keygen -t ed25519 -> `Crea chiave SSH`

- $ cat id_ed25519 -> `Stampa chiave SSH privata da NON condividere con nessuno`

- $ cat id_ed25519.pub -> `Stampa chiave SSH pubblica`

- ssh -T git@gitlab.com --> `per connetteri al server gitlab`

## Comandi legati a GitLab e simili

- $ git clone git@gitlab.com:stefan.stanescu1/project -> `Copia progetto da gitlab a locale utilizzando SSH o HTML`

- git remote add origin git@gitlab.com:stefan.stanescu1/il-mio-nuovo-progetto.git -> `Collega la repo locale con quella su gitlab`

- $ git push -u origin main -> `Carica la tutta repo locale sul server git`

- git push -u percorso ->  `-u Setta il percorso default dei push (funziona anche per PULL)`

- git push -f -> `Forza un push, non tiene conto dello storico 'sbagliato'. Solitamente avviene a seguito di un comando 'rebase' ma non solo.`

## Q&A

- `Come creo un progetto git?`

~Apri la bash ~Usa il comando 'ls' per vedere le directory in cui puoi muoverti ~Usa 'cd' per muoverti tra le directory ~ 'mkdir' per creare la cartella che utilizzerai per il progetto ~ 'git init' per iniizalizzare il progetto.

- `Ho un conflitto, che faccio?`

Un conflitto e' una differenza di righe dello stesso file che avviene solitamente durante i merge. Apri il file in conflitto con VScode (code file), confronta le differenze, e scegli l'alternativa migliore. Puoi anche tenerli entrambi o modificare il codice. L'importante e' cancellare i segni lasciati da git:
 					<<<<<<< 
  					=======
 					>>>>>>> 


NB: ammetto che per questa sezione pensavo di avere piu' idee...
Nel dubbio ecco il video di un gatto:
https://www.youtube.com/watch?v=QvKhtgWaNEM