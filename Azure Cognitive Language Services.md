# AI-on-Microsoft-Azure


# Azure Cognitive Language Services

### Azure Content Moderator
### 1. Intro
##### 1.1. Wstępne przedstawienie serwisu
##### 1.2. Opis serwisu

### 2. Use Cases
##### 2.1. Wstępne przedstawienie serwisu
##### 2.2. Opis serwisu

### 3. How to
##### 3.1. Użycie serwisu
##### 3.2. Opłaty

# Language Understanding Intelligent Service (LUIS)

### 1. Intro
##### 1.1. Wstępne przedstawienie serwisu
Language Understanding (LUIS) jego celem jest zrozumienie intencji użytkownika. Usługa LUIS używa technik uczenia maszynowego w celu przewidywania znaczenia danych wprowadzanych przez użytkownika.

##### 1.1. Opis serwisu

Usługa Luis przyjmuje tekst jako wejście i przewiduje jego główny cel oraz analizuje wypowiedz
Serwis wykorzystuje 2 kluczowe zadania w celu zrozumienia języka naturalnego:
Klasyfikacja zamiaru – pozwala na przypisanie zdaniu wejściowemu wypowiedzi w celu określenia ogólnego znaczenia 
Rozpoznawanie jednostek nazwanych  - wyodrębnia z frazy jednostki np., nazwy miast czy daty


### 2. Use Cases
Usługa może być wykorzystywana np. w aplikacjach jako media społecznościowe, aplikacje komputerowe z obsługą mowy np.
Bot w na stronie restauracji, który odpowiada na podstawowe pytania 
Bot do rezerwacji biletów w kina, na podstawie wypowiedzi użytkownika, bot potrafi zrozumieć, na jaki film, kiedy i w jakim mieście użytkownik chce obejrzeć film
Bot który na podstawie kluczowych słów potrafi postawić diagnozę medyczną 

### 3. How to
##### 3.1. Użycie serwisu

W celu skorzystania z usługi, należy utworzyć zasób LUIS w Azure Portal. Aplikacje należy utworzyć w  w tym samym regionie, co utworzona usługa. Usługa LUIS obsługuje trzy lokalizacje: Stany Zjednoczone, Europa i Azja. Dla wszystkich tych lokalizacji istnieją oddzielne portale. Następnie należy "intents" oraz "entities" . Dzięki temu Luis może wyrywać kluczowe słowa oraz rozumieć ich kombinacje.  Po konfiguracji zasobu możemy douczać model. Usługa Luis zwraca ocenę pewności z przedziału od 0 do 1. Im wyższa wartość, tym fraza lepiej została zrozumiana. Po zakończeniu trenowania należy opublikować serwis. 

##### 3.2. Opłaty
Możemy wyróżnić 2 modele: free oraz standard
Free – pozwala wykonać maksymalnie 5 zapytań ba sekundę
Standard – maksymalnie 50 zapytań na sekundę:
*	Rządanie tekstowe - $1.50 za 1000 zapytań
*	Rządanie wymawiane - $5.50 za 1000 zapytań

## Text Analytics API

### 1. Intro
##### 1.1. Wstępne przedstawienie serwisu
Text Analytics to usługa, która ma za zadanie analizować i zrozumieć tekst. Usługa ta udostępnia szczegółowe informacje o tonacji oraz kluczowych frazach w postaci tekstu bez struktury
##### 1.2. Opis serwisu
Text Analytics potrafi wykrywać język tekstu, słowa kluczowe, czy też przeanalizować tonację oraz wyszukać opinię. Serwis zwraca ocenę opinii od 0 do 1 dla. Im wartość opinii jest wyższa tym tekst jest bardziej pozytywny pozytywnym. 

### 2. Use Cases
Sklep internetowy z recenzjami klientów. Analizę tekstu można użyć do wyszukiwania negatywnych recenzji.
Określenie nastrojów uczniów po napisaniu matury z matematyki na podstawie komentarzy na forach. 


### 3. How to
##### 3.1. Użycie serwisu
W celu skorzystania z usługi, należy utworzyć zasób Text Analytics i  uzyskać dostęp do klucza dostępowego, aby uwierzytelnić żądania.
Sformułuj żądanie zawierające dane jako nieprzetworzony tekst bez struktury, w formacie JSON.
Wyślij żądanie do punktu końcowego ustanowionego podczas rejestracji, dołączając żądany zasób: tonacji Analysis, wyodrębnianie kluczowych fraz, wykrywanie języka lub rozpoznawanie jednostek nazwanych.
Prześlij odpowiedź strumieniowo lub przechowaj ją lokalnie. W zależności od żądania wyniki są oceną tonacji, kolekcją wyodrębnionych kluczowych fraz lub kodem języka.

##### 3.2. Opłaty
Możemy wyróżnić 2 modele: free oraz standard
Free – pozwala wykonać maksymalnie 5000 zapytań w miesiącu
Standard – cennik jest rozbity na:
* 0–500 000 rekordów tekstu — €1,687 za 1 000 rekordów tekstu
* 0,5M–2,5M rekordów tekstu — €0,844 za 1 000 rekordów tekstu
* 2,5M–10,0M rekordów tekstu — €0,422 za 1 000 rekordów tekstu
* 10M+ rekordów tekstu — €0,211 za 1 000 rekordów tekstu

