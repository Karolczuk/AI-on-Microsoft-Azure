# System COVIDowy - rozpoznawanie, czy osoba ma założoną maseczkę

## 1. Prezentacja video

Prezentcja vido przedstawiająca główne przypadki użycia znajduje się w linku: </b> https://www.youtube.com/watch?v=_6nqOo-pRic&feature=youtu.be      </b>


## 2. Use case

Aplikacja pomaga rozpoznać, czy osoba ma założoną maseczkę stworzona oraz określa prawdopodobieńtwo prawidłowego rozpoznania obrazu. Zostały nałożone 3 tagi: 
* with - zdjęcie z maseczką
* without - zdjęcie bez maseczki
* other - inne obrazy

## 3. Architektura

Zadanie zostałi stworzone przy użyciu Custom Vision. Projekt został stworzony w https://www.customvision.ai/ . Projekt również można uruchomić przy użyciu aplikacji .net. przekazująć predictionKey, url, projektId oraz publishedName serwisu custom vision. </b> 
</b>


## 4. Kroki do zbudowania systemu rozpoznawania maseczki na zdjęciu


1. Zaloguj się  do Azure portal https://portal.azure.com/ i stwórz resouce group  </b>

2. Wejdż do portalu usługi Custom Vision : https://www.customvision.ai/ i utwórz nowy projekt.

3. Stworz tagi: with, without oraz other  i dodaj do nich obrazy.

4. Wybierz przycisk Trenuj z górnej części strony. 

5. Po procesie trenowania nalezy przejść do etapu testowania.Model testujemy, klikając na przycisk szybki test i podając zdjęcie, które chcemy sklasyfikować.

6. Dodatkowo można uruchomić aplikacje w .net ustwiając odpowiednie scieżko do zdjęć oraz:

      * static string url = "";
      * static string PredictionKey = "";
      * static string ProjetId = "";
      * static string PublishedName = "";
      
- Struktura zdjęc musi być zchowana następująco:
  - Należe stworzyć 2 foldery nadrzędne : test oraz prediction. Każdy z tych folderów zawiera 3 foldery: 
    - without
    - with
    - other
 
 

