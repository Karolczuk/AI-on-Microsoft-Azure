# Azure Bot Service

## QnA Maker
### 1. Intro
##### 1.1. Wstępne przedstawienie serwisu
QnA Maker – umożliwia utworzenie bazy wiedzy, rozszerzonej o funkcje przetwarzania języka naturalnego.

##### 1.2. Opis serwisu
QnA Maker korzysta z bazy wiedzy, która składa się z par pytań i odpowiedzi. Usługa potrafi dopasować odpowiednie pytanie do odpowiedzi. QnA Maker zwraca odpowiedzi w formacie Json. Im bardziej baza wiedzy jest rozbudowana tym usługa lepiej dopasowuje odpowiedź do pytania.  

### 2. Use Cases
* Usługa może być wykorzystywana do zarządzania konwersacją np. bot dla stacji informacyjej, w której możemy dopytać się o najnowsze informacje
* Bot wspomagający działanie przychodni medycznej, który odpowiada nowym pacjentom na często powtarzające się pytania np. jakie testy alergiczne można wykonać w placówce
* Bot wspomagający działanie gry komputerowej, który prowadzi użytkownika krok po kroku jak w instrukcji


### 3. How to
##### 3.1. Użycie serwisu
Na początku trzeba stworzyć bazę wiedzy, zawierającą pytania i odpowiedzi. Pytania i odpowiedzi mogą być: wygenerowane na podstawie istniejącego dokumentu lub strony internetowej z często zadawanymi pytaniami czy też wprowadzone ręcznie. Następnym krokiem jest trenowanie bazy i opublikowanie jej. Bazę można wykorzystywać poprzez REST. 
##### 3.2. Opłaty
Możemy wyróżnić 2 modele: free oraz standard <br/>
* free - max 3 zapytania na sekundę, każdy dokument o rozmiarze do 1 MB do 100 transakcji na minutę, do 50 000 transakcji na miesiąc <br/>
* standard - max 3 zapytania na sekundę, do 100 transakcji na minutę, €8,433 dla nieograniczonej liczby zarządzanych dokumentów<br/>


## Bot Framework Composer

### 1. Intro
##### 1.1. Wstępne przedstawienie serwisu
Bot Framework Composer umożliwia łatwe tworzenie bota bez konieczności pisania kodu.
##### 1.1. Opis serwisu
Bot Framework Composer jest open-sourcowy. Integruje się z takimi serwisami jak LUIS i QnA Maker.Serwis posiada wiele zalet takich jak  wizualna powierzchnia projektowa, uproszczone tworzenie bota, co wiąże się z oszczędnością czasu. 

### 2. Use Cases
* możliwość storzenia bota bez znajomości programowania np. bot wykorzytywany przy umawiania spotkań
* możliość stosunkowo szybkiego stowrzenia bota np. bot dla biura podróży, w którym możemy dopytać się o szczegóły wycieczki, bot pomagający złożyć zamówienie w sklepie

### 3. How to
##### 3.1. Użycie serwisu
Aby korzystać Bot Framework Composer trzeba zainstalować  .NET Core, Bot Framework Composer oraz Bot Framework Emulator. W celu stworzenia bota należy uruchomić Bot Composer. Za pomocą diagramu można stworzyć ścieżkę dialogu. Bot może mieć wiele okienek. Okno dialogowe powinno zawiera co najmniej jeden wyzwalacz. Wyzwalacz składa się z akcji. Akcje to zbiór instrukcji, które wykonuje bot. Za pomocą emultora można przetestować funkcjonalność bota. 

##### 3.2. Opłaty
Aplikacja jest opensourcowa. Usługa jest bezpłatna.
