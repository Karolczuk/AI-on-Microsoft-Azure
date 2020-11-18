# Azure Cognitive Speech Services

## Azure Text to Speech
### 1. Intro
##### 1.1. Wstępne przedstawienie serwisu
Serwis pozwala na tworzenie aplikacji i usług, które mówią naturalnie, wybierając spośród ponad 150 głosów i ponad 50 języków i wariantów. Usługa pomaga stworzyć unikalny głos, można dostosować głos do swoich własnych scenariuszy i uruchamiać zamianę tekstu na mowę w dowolnym miejscu.

### 2. Use Cases
* zamiana artykułu na słowa dla ludzi niewodomych, dzięki temu będęą mogli odłuchać artykułu
* storzenie unikalnego głosu w filmie 

### 3. How to
##### 3.1. Użycie serwisu
W celu skorzystania z usługi, należy utworzyć zasób w Azure Portal i skopiować klucz z zakładki Keys and Endpoints. Z zasoby można korzystać za pomocą komunikacji REST oraz SDK

##### 3.2. Opłaty
Możemy wyróżnić 2 modele: free oraz standard <br/>
Free – max 1 zapytań jednocześnie <br/>
* Neuronowa — 0.5 miliona bezpłatnych znaków na miesiąc  <br/>
* Standard - 5 miliinów bezpłatnych znaków na miesiąc <br/>
* Niestandardowe- bezpłatne znaki na miesiąc: 5 million, hosting punktów końcowych: 1 bezpłatny model na miesiąc <br/>

Standard – max 20 zapytań jednocześnie:<br/>
* Niestandardowe sieci neuronow — €20,240 za 1 mln znaków, hosting punktów końcowych: €3,41 za model na godzinę  <br/>
* Standard - 	€3,374 za 1 mln znaków  <br/>
* Niestandardowe	- €5,060 za 1 mln znaków, hosting punktów końcowych: €0,0453 za model na godzinę  <br/>

## Azure Speech To Text

### 1. Intro
##### 1.1. Wstępne przedstawienie serwisu
Azure Speech to Text transkrybuje dźwięk na tekst w 85 językach i wariantach. Można dostosowywać modele, aby zwiększyć dokładność terminologii specyficznej dla domeny.
Zamiana mowy na tekst umożliwia transkrypcję strumieni audio na tekst.


### 2. Use Cases
* dodanie tlumaczeń w programie telewizyjnym dla osób głuchoniemych
* tłumcazenie wypowiedzi na tekst na potrzeby edukacyjne np. osoba wypowiada tekst po angielsku, teskt sie zpaisuje i sosoba może zweryfikować swoją poprawność gramatyczną 

### 3. How to
##### 3.1. Użycie serwisu
W celu skorzystania z usługi, należy utworzyć zasób w Azure Portal i skopiować klucz z zakładki Keys and Endpoints. Z zasoby można korzystać za pomocą komunikacji REST oraz SDK


##### 3.2. Opłaty
Możemy wyróżnić 2 modele: free oraz standard <br/>
Free – max 1 zapytań jednocześnie <br/>
* Transkrypcja konwersacji — wielokanałowe audio -  5 bezpłatnych godzin audio na miesiąc </b>
* Standard - 5 bezpłatnych godzin audio na miesiąc </b>
* Niestandardowe	- 5 bezpłatnych godzin audio na miesiąc, hosting punktów końcowych </b>

Standard – max 20 zapytań jednocześnie:<br/>
* Transkrypcja konwersacji — wielokanałowe audio €1,78 za godzinę audio 4
* Standard €0,844 za godzinę audio
* Niestandardowe	€1,181 za godzinę audio, hosting punktów końcowych: €1,0882 za model na godzinę


## Text Analytics API

### 1. Intro
##### 1.1. Wstępne przedstawienie serwisu
To usługa oparta na chmurze, która zapewnia funkcje przetwarzania języka naturalnego (NLP) do eksploracji tekstu i analizy tekstu, w tym: analizę sentymentów, eksplorację opinii oraz wyodrębnianie kluczowych fraz. 

### 2. Use Cases
* Klasyfikacja terminologi medycznej
* Bot obsługujący klinetów w różnych językach


### 3. How to
##### 3.1. Użycie serwisu
Analogiicznie jak w poprzedmich serwisach czyli musimy stworzyć resorce, skonfigurować klucze. 

##### 3.2. Opłaty
Wyróżniamy free oraz standard. </b>
* free - 5 godzin audio na miesiąc
* standard  - $3.20 za godzinę audio

