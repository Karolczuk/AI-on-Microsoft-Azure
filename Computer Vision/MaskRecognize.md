# System COVIDowy - rozpoznawanie, czy osoba ma założoną maseczkę

## 1. Prezentacja video

Prezentcja vido przedstawiająca główne przypadki użycia znajduje się w linku: </b> https://www.youtube.com/watch?v=_6nqOo-pRic&feature=youtu.be      </b>


## 2. Use case

Aplikacja pomaga rozpoznać, czy osoba ma założoną maseczkę stworzona oraz określa prawdopodobieńtwo prawidłowego rozpoznania obrazu. Zostały nałożone 3 tagi: 
* with - zdjęcie z maseczką
* without - zdjęcie bez maseczki
* other - inne obrazy

## 3. Architektura



Bot został utworzony przy użyciu Azure Bot Framework Coposer. Użyłam usługi Azure LUIS (Language Understanding), by rozpoznać intencje użytkonwnika. Dane statystyczne są pobierane z API. </b> 

* https://coronavirus-19-api.herokuapp.com/all  </b>
</b>

* Diagram architektury



## 4. Kroki do zbudowania systemu rozpoznawania maseczki na zdjęciu


1. Zaloguj się  do Azure portal https://portal.azure.com/ i stwórz resouce group  </b>

2. Wejdż do portalu usługi Custom Vision : https://www.customvision.ai/ i utwórz nowy projekt.

3. Stworz tagi: with, without oraz other  i dodaj do nich obrazy.

4. Wybierz przycisk Trenuj z górnej części strony. 

5. Po procesie trenowania nalezy przejść do etapu testowania.Model testujemy, klikając na przycisk szybki test i podając zdjęcie, które chcemy sklasyfikować.

6. Dodatkowo można uruchomić aplikacje w .net ustwiając:

      * static string url = "";
      * static string PredictionKey = "";
      * static string ProjetId = "";
      * static string PublishedName = "";
      
  oraz ścieżki do zdjęć.
Struktura zdjęc musi być zchowana następująco:



