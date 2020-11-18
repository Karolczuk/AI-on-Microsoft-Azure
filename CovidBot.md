# Covid Bot

## 1. Prezentacja video

Prezentcja vido przedstawiająca główne przypadki użycia znajduje się w linku: </b>
https://www.youtube.com/watch?v=U9o2TCyurLs           </b>


## 2. Kod

Kod znajaduje się w innej gałezi niż część teoretyczna. Kod znajduje się w gałęzi master. Natomiast część teoretyczna w gałęzi main. </b>
Link do kodu : </b>
https://github.com/Karolczuk/AI-on-Microsoft-Azure/tree/master/Chatbot


## 3. Use case

* bot podaje informacje o ilość zachorowań, przypadków śmiertelnych i wyzdrowien na świecie
* bot podaje podstawowe informacje dotyczące kwarantanny np. jak długo trwa kwarantanna, co to jest kwarantanna domowa
* bot przeprowadza podstawową diagnostykę pacjenta

## 4. Architektura

Bot został utworzony przy użyciu Azure Bot Framework Coposer. Użyłam usługi Azure LUIS (Language Understanding), by rozpoznać intencje użytkonwnika. Dane statystyczne są pobierane z API. </b> 

* https://coronavirus-19-api.herokuapp.com/all
</b>

## 5. Kroki do zbudowania bota

1. Pobierz Azure Bot Service Composer. </b>
* https://github.com/microsoft/BotFramework-Composer/releases
</b>
2. Pobierz emulator platformy Azure Bot Framework.  </b>
* https://github.com/Microsoft/BotFramework-Emulator/blob/master/README.md    </b>

3. Utwórz usługę LUIS w Azure Portal.  </b> 
* https://portal.azure.com/#home  </b> 

4. Podepnij usługę LUIS do Bot Composera, ustawiając klucza do usługi LUIS w aplikacji Bot Framework Composer.  </b>
5. Uruchom bota naciskająć Start w aplikacji Bot Framework Composer. 
