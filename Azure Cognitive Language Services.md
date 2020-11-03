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
Free – pozwala wykonać maksymalnie 5 zapytań 
Standard – maksymalnie 50 zapytań na sekundę:
o	Rządanie tekstowe - $1.50 za 1000 zapytań
o	Rządanie wymawiane  - $5.50 za 1000 zapytań

