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

W celu skorzystania z usługi, należy utworzyć odpowiednie zasoby i wygenerować klucz. Usługę można uruchomić za pomocą API, umieszczająć w headerze  Ocp-Apim-Subscription-Key z wygenerowanym kluczem.
##### 3.2. Opłaty
Możemy wyróżnić 2 modele: free oraz standard <br/>
Free – pozwala wykonać maksymalnie 5000 zapytań w miesiącu <br/>
Standard – cennik jest rozbity na:<br/>
* Od 0 do 1 mln transakcji - €0,844 za 1 000 transakcji
* Od 1 mln do 5 mln transakcji - €0,633 za 1 000 transakcji
* Od 5 mln do 10 mln transakcji - €0,506 za 1 000 transakcji
* Ponad 10 mln transakcji - €0,338 za 1 000 transakcji


## Bot Framework Composer

### 1. Intro
##### 1.1. Wstępne przedstawienie serwisu
Language Understanding (LUIS) jego celem jest zrozumienie intencji użytkownika. Usługa LUIS używa technik uczenia maszynowego w celu przewidywania znaczenia danych wprowadzanych przez użytkownika.

##### 1.1. Opis serwisu

Usługa Luis przyjmuje tekst jako wejście i przewiduje jego główny cel oraz analizuje wypowiedzi.
Serwis wykorzystuje 2 kluczowe zadania w celu zrozumienia języka naturalnego:<br/>
* Klasyfikacja zamiaru – pozwala na przypisanie zdaniu wejściowemu wypowiedzi w celu określenia ogólnego znaczenia <br/>
* Rozpoznawanie jednostek nazwanych  - wyodrębnia z frazy jednostki np., nazwy miast czy daty


### 2. Use Cases
Usługa może być wykorzystywana np. w aplikacjach jako media społecznościowe, aplikacje komputerowe z obsługą mowy np.

* Bot w na stronie restauracji, który odpowiada na podstawowe pytania 
* Bot do rezerwacji biletów w kina, na podstawie wypowiedzi użytkownika, bot potrafi zrozumieć, na jaki film, kiedy i w jakim mieście użytkownik chce obejrzeć film
* Bot który na podstawie kluczowych słów potrafi postawić diagnozę medyczną 

### 3. How to
##### 3.1. Użycie serwisu

W celu skorzystania z usługi, należy utworzyć zasób LUIS w Azure Portal. Aplikacje należy utworzyć w  w tym samym regionie, co utworzona usługa. Usługa LUIS obsługuje trzy lokalizacje: Stany Zjednoczone, Europa i Azja. Dla wszystkich tych lokalizacji istnieją oddzielne portale. Następnie należy "intents" oraz "entities" . Dzięki temu Luis może wyrywać kluczowe słowa oraz rozumieć ich kombinacje.  Po konfiguracji zasobu możemy douczać model. Usługa Luis zwraca ocenę pewności z przedziału od 0 do 1. Im wyższa wartość, tym fraza lepiej została zrozumiana. Po zakończeniu trenowania należy opublikować serwis. 

##### 3.2. Opłaty
Możemy wyróżnić 2 modele: free oraz standard <br/>
Free – pozwala wykonać maksymalnie 5 zapytań ba sekundę <br/>
Standard – maksymalnie 50 zapytań na sekundę:<br/>
*	Rządanie tekstowe - $1.50 za 1000 zapytań
*	Rządanie wymawiane - $5.50 za 1000 zapytań

