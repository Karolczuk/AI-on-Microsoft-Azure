
# Custom  Vision

### 1. Intro
##### 1.1. Wstępne przedstawienie serwisu
Custom Vision umożliwia tworzenie, trenowanie modelu oraz testowanie. Usługa Custom Vision używa algorytmu uczenia maszynowego do analizowania obrazów. Korzystanie z usługi jest bardzo proste. Wystarczy, że prześlecmy do do portalu usługi Custom Vision obrazki z zdefiniowanymi tagami i usługa sama wytrenuje model, który pozwala na rozróżnianie obrazków. Ponadto usługa Custom Vision jest zoptymalizowana pod kątem szybkiego rozpoznawania głównych różnic między obrazami. Z serwisu Custom Vision Service  można korzystać za pomocą SDK, a także za pośrednictwem interfejsu opartego na sieci Web/

### 2. Use Cases
* sklasyfikowanie do jakiego autora należy dzieło sztuki
* aplikacja rozpoznająca rasy psów
* szukanie przestępcy w tłumie

### 3. How to
##### 3.1. Użycie serwisu
W pierwszym kroku należy wejść do portalu usługi Custom Vision : https://www.customvision.ai/  i utwórzyć nowy projekt. Następnie trzeba stworzyć tagi i dodać do nich obrazy. Obrazy będą rozpoznawane po tagach. Po przekazaniu oznakowanych obrazów następnym krokiem jest nauczenie modelu przy użyciu tych obrazów, aby mógł rozróżnić poszczególne obrazy Następnie trzeba prztrenować model. W tym celu należy wybrać przycisk Trenuj z górnej części strony. Po procesie trenowania nalezy przejść do etapu testowania.  
Model testujemy, klikając na przycisk szybki test i podając zdjęcie, które chcemy sklasyfikować.


##### 3.2. Opłaty
Możemy wyróżnić 2 modele: free oraz standard <br/>

 - Free
    - max 2 projekty
    - do 1 godziny trenowania na miesiąc
    - 5000 obrazów na potrzeby uczenia na projekt
    - 10000 prognoz miesięcznie
    - 2 transakcj/s (TPS)
 - Standard
    - 10 transakcji/s (TPS)
    - transakcje przekazywania i przewidywania
      - €1,687 za 1000 transakcji
      - max 100 projektów

    - szkolenia	
      - €16,866 za godzinę obliczeniową
    - Magazyn obrazów
      = max 6 MB każdy
      = €0,591 za następującą liczbę obrazów: 1 000

       

