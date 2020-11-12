# Azure Bot Service

## QnA Maker
### 1. Intro
##### 1.1. Wstępne przedstawienie serwisu
QnA Maker – umożliwia utworzenie bazy wiedzy, rozszerzoną o funkcje przetwarzania języka naturalnego.

##### 1.2. Opis serwisu
QnA Maker korzysta z bazy wiedzy, która składa się z par pytań i odpowiedzi. Usługa potrafi dopasować odpowiednie pytanie do odpowiedzi. QnA Maker zwraca odpowiedzi w formacie Json. Im bardziej baza wiedzy jest rozbudowana tym usługa lepiej dopasowuje odpowiedź do pytania.  

### 2. Use Cases
* Usługa może być wykorzystywany do zarządzania konwersacją np. 
* Bot wspomagający działanie przychodni medycznej, który odpowiada nowym pacjentom na często powtarzające się pytania np. jakie testy alergiczne można wykonać w placówce
* Bot wspomagający działanie gry komputerowej, który prowadzi użytkownika krok po kroku jak w instrukcji


### 3. How to
##### 3.1. Użycie serwisu
* możliwość storzenia bota bez znajomości programowania np. bot wykorzytywany przy umawiania spotkań, bot 
* możliość stosunkowo szybkiego stowrzenia bota np. bot dla biu Podróży, w którym możemy dopytać się o szczegóły wycieczki, bot pomagający złożyć zamówienie w sklepie

W celu skorzystania z usługi, należy utworzyć odpowiednie zasoby i wygenerować klucz. Usługę można uruchomić za pomocą API, umieszczająć w headerze  Ocp-Apim-Subscription-Key z wygenerowanym kluczem.
##### 3.2. Opłaty
Możemy wyróżnić 2 modele: free oraz standard <br/>
* free - max 3 zapytania na sekundę, każdy dokument o rozmiarze do 1 MB do 100 transakcji na minutę, do 50 000 transakcji na miesiąc <br/>
* standard - max 3 zapytania na sekundę, do 100 transakcji na minutę, €8,433 dla nieograniczonej liczby zarządzanych dokumentów<br/>


## Bot Framework Composer

### 1. Intro
##### 1.1. Wstępne przedstawienie serwisu
Bot Framework Composer umożliwia łatwe tworzenie bota bez konieczności pisania kodu.
##### 1.1. Opis serwisu
Bot Framework Composer jest open-sourcowy. Integruje się z takimi serwisami jak LUIS i QnA Maker. jest płótno kompozytora, na którym można projektować boty. Serwis posiada wiele zalet: wizualna powierzchnia projektowa, uproszczone tworzenie bota, co wiąże się z oszczędnością czasu. 

### 2. Use Cases


### 3. How to
##### 3.1. Użycie serwisu
Aby korzystać Bot Framework Composer trzeba zainstalować  .NET Core, Bot Framework Composer oraz Bot Framework Emulator. W celu stworzenia bota należy uruchomić Bot Composer. Za pomocą diagramu można stworzyć ścieżkę dialogu. Bot może mieć wiele okienek. Okno dialogowe powinno zawiera co najmniej jeden wyzwalacz. Wyzwalacz składa się z akcji. Akcje to zbióry instrukcji, które wykonuje bot. Za pomocą emultora można przetestować funkcjonalność bota. 

##### 3.2. Opłaty
Aplikacja jest opensource darmowa. Usługa jest bezpłatna
