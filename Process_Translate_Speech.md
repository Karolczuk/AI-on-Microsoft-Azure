# Azure Cognitive Speech Services

## Azure Text to Speech
### 1. Intro
##### 1.1. Wstępne przedstawienie serwisu
Azure Text to Speech transkrybuje dźwięk na tekst w 85 językach i wariantach. Można dostosowywać modele, aby zwiększyć dokładność terminologii specyficznej dla domeny.
##### 1.2. Opis serwisu
Zamiany mowy na tekst usługi mowy umożliwia transkrypcję strumieni audio na tekst.Usługa pomaga stworzyć unikalny głos, można dostosować głos do swoich scenariuszy i uruchamiać zamianę tekstu na mowę w dowolnym miejscu.

### 2. Use Cases
* zamiana artykułu na słowa dla ludzi niewodomych, dzięki temu będęą mogli odłuchać artykułu
* storzenie unikalnego głosu w filmie fantastycznym

### 3. How to
##### 3.1. Użycie serwisu
W celu skorzystania z usługi, należy utworzyć zasób Speech w Azure Portal i skopiować klucz z zakładki Keys and Endpoints. Z zasoby można korzystać za pomocą komunikacji REST oraz SDK

##### 3.2. Opłaty
Możemy wyróżnić 2 modele: free oraz standard <br/>
Free – max 1 zapytań jednocześnie <br/>
* Transkrypcja konwersacji — wielokanałowe audio - - 5 bezpłatnych godzin audio na miesiąc
* Standard - 5 bezpłatnych godzin audio na miesiąc
* Niestandardowe	- 5 bezpłatnych godzin audio na miesiąc, hosting punktów końcowych: 1 bezpłatny model na miesiąc 2 

Standard – max 20 zapytań jednocześnie:<br/>
* Transkrypcja konwersacji — wielokanałowe audio €1,78 za godzinę audio 4
* Standard €0,844 za godzinę audio
* Niestandardowe	€1,181 za godzinę audio, hosting punktów końcowych: €1,0882 za model na godzinę


## Language Understanding Intelligent Service (LUIS)

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

## Text Analytics API

### 1. Intro
##### 1.1. Wstępne przedstawienie serwisu
Text Analytics to usługa, która ma za zadanie analizować i zrozumieć tekst. Usługa ta udostępnia szczegółowe informacje o tonacji oraz kluczowych frazach w postaci tekstu bez struktury
##### 1.2. Opis serwisu
Text Analytics potrafi wykrywać język tekstu, słowa kluczowe, czy też przeanalizować tonację oraz wyszukać opinię. Serwis zwraca ocenę opinii od 0 do 1 dla. Im wartość opinii jest wyższa tym tekst jest bardziej pozytywny pozytywnym. 

### 2. Use Cases

* Sklep internetowy z recenzjami klientów. Analizę tekstu można użyć do wyszukiwania negatywnych recenzji.
* Określenie nastrojów uczniów po napisaniu matury z matematyki na podstawie komentarzy na forach. 


### 3. How to
##### 3.1. Użycie serwisu
W celu skorzystania z usługi, należy utworzyć zasób Text Analytics i uzyskać dostęp do klucza dostępowego, aby uwierzytelnić żądania. Żądania powinny być w formacie JSON.
Następnie należy wysłać żadanie z tekstem do analizy do punktu końcowegom, który został ustalony podczas rejestracji. 

##### 3.2. Opłaty
Możemy wyróżnić 2 modele: free oraz standard<br/>
Free – pozwala wykonać maksymalnie 5000 zapytań w miesiącu <br/>
Standard – cennik jest rozbity na:<br/>
* 0–500 000 rekordów tekstu — €1,687 za 1 000 rekordów tekstu
* 0,5M–2,5M rekordów tekstu — €0,844 za 1 000 rekordów tekstu
* 2,5M–10,0M rekordów tekstu — €0,422 za 1 000 rekordów tekstu
* 10M+ rekordów tekstu — €0,211 za 1 000 rekordów tekstu
