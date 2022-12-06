# Portfolio-s3

Welkom bij mijn portfolio van semester 3. Hier vind je alles wat hoort bij mij individueel- en groepsproject.

## Introductie
Mijn naam is Jelle Manders, 20 jaar oud. Ik ben student aan de opleiding HBO-ICT bij Fontys Hogescholen in Eindhoven.

## Inhoudsopgave
- [Introductie](#introductie)
- [Web Application](#web-application)
- [Software quality](#software-quality)
- [CI/CD](#ci-cd)
- [Requirements and design](#requirements-and-design)
- [Professional](#professional)

## Web Application
Samenvatting leeruitkomst: You design and build user-friendly, full-stack web applications.

Voor dit leeruitkomst maak ik een full stack web applicatie voor bierliefhebbers. Voor het user-friendly design heb ik een [onderzoek](https://github.com/JManders07/Portfolio-s3/blob/main/IP/Learningoutcomes/Web-application/UI%20research.pdf) gedaan over UI/UX. In dit document onderzoek ik verschillende aspecten wat betreft de UI/UX. Onder andere gaat het document over wat een UI is, hoe een een goede UI kan ontwerpen en hoe ik mijn design heb gemaakt.

Voor een fullstack applicatie moeten we gebruik maken van een algemeen geaccepteerd fronted Javascript framework. Ik heb gekozen voor Vue met Vue-Bootstrap. Voor de backend maak ik gebruik van 2 verschillende talen. Voor de algemene backend gebruik ik C# met entity framework. Ik gebruik ook Java met (nog te bepalen) framework. Dit om ook iets anders te leren dan C#. Mijn beargumentatie is te vinden in mijn [onderzoeksdocument](https://github.com/JManders07/Portfolio-s3/blob/main/IP/Learningoutcomes/Web-application/Research.pdf). Nadat ik onderzoek had gedaan, heb ik ook wat [prototypes](https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Web-application) gemaakt.

//TODO Wanneer de gebruiker op de hoofdpagina komt dan ziet de gebruiker het volgende. De gebruiker kan vervolgens in de navigatiebalk aanklikken naar welke pagina die zou willen gaan. Dit wordt mogelijk door vue-router.

//TODO plaatje hoofdscherm

//TODO Voor accounts gebruik in een extentie genaamd Auth0. Auth0 is makkelijk toe te voegen als authenticatie- en autorisatieservice. Ik heb gekozen om niet zelf een loginsysteem te maken omdat er al ontzettend veel systemen bestaan. Het is daarom zonde van de tijd, en risicovoller wat betreft beveiliging, als ik zelf een loginsysteem ga maken.

//TODO plaatje Auth0

//TODO Gebruikers van mijn applicatie kunnen een review achterlaten op een bepaald biertje. Ze kunnen een score geven van 1 tot 10 op basis van sterren. Dit maakt het wat gebruiksvriendelijker dan een getal. Ook kunnen ze een reactie typen als toevoeging op de review.

//TODO plaatje review

Tot zover mijn frontend uitgelegd. Wat betreft de backend maak ik gebruik van een apart lopende database. Hier staan alle bieren en reviews in opgeslagen. Ik maak gebruik van een MySQL database. In een relationele database wordt alle data opgeslagen in opslagruimtes, genaamd tabellen. Het databasebeheersysteem is ontwikkeld door Oracle. 

//TODO plaatje database

In mijn C# backend heb ik zelf API calls gemaakt die ervoor zorgen dat ik met de frontend kan communiceren. Ik kan bijvoorbeeld via de frontend bieren opvragen aan de backend. Deze worden vervolgens door middel van een API call doorgestuurd aan de frontend. De pagina staat nu vol met de opgevraagde bieren. Dit is een POST in de backend. Anderssom kan het namelijk ook. Wanneer ik een biertje of review wil toevoegen aan de database roept de frontend ook een API call aan. De backend verkrijgt nu informatie van de frontend en stopt deze in de database. Dit is een GET.

//TODO plaatje POSTmethod

//TODO plaatje GETmethod

Voor mijn project maak ik gebruik van aparte git repo's voor de backend en frontend.  
[BeerWithFriends-Front-end](https://github.com/JManders07/BeerWithFriends-Front-end)  
[BeerWithFriends-Back-end](https://github.com/JManders07/BeerWithFriends-Back-end)

 ## Software quality
 Samenvatting leeruitkomst: You use software tooling and methodology that continuously monitors and improve the software quality during software development.
 
//TODO Softwarekwaliteit is een breed begrip. Het is vaak moeilijk toe te passen omdat veel verschillende werkwijzes zijn om goede software te maken. De kwaliteit van software kun je eigenlijk zien als een vraag: "Doet de software wat hij moet doen?" Dat is een vraag die we kunnen beantwoorden aan de hand van testen. Het is belangrijk om testen te schrijven. Ik heb unit tests en integratie test gemaakt. Een unit test is een test waarbij een indivudeel component wordt getest. Het doel is om losse functies te controleren op de kwaliteit. Wanneer alle unit testen met succes uitgevoerd worden is het tijd voor de integratietesten. Een integratietest is een test die het geheel test, dus de hele applicatie ofwel alle componenten tegelijk. Een integratietest kijkt of alle componenten goed samenwerken.

//TODO plaatjes van testen met uitleg erbij

Voor de kwaliteit van mijn software is mijn backend geschreven in 5 lagen. Ik gebruik op dit moment Entity framework zodat ikzelf de database als het ware niet aanraak. Entity framework zorgt ervoor dat je door middel van een context toch acties kan uitvoeren op de database. De 5 lagen zorgen ervoor dat ik kan wisselen van databse. Dit is vooral belangijk voor het testen. Wanneer ik met mijn echte database test kan het voorkomen dat ik belangrijke informatie wis of onjuiste informatie toevoeg. Ik maak een mock database zodat ik altijd mijn originele data veilig houd.

//TODO plaatje van factory of iets dergelijks om duidelijk te maken dat je kan wisselen van datalaag.

## CI/CD
Samenvatting leeruitkomst: 
//TODO Ik maak gebruik van SonarCloud. Dit is een omgeving die je code analyseert. Je ziet hier de veiligheid, onderhoudbaarheid en betrouwbaarheid van je code. Kortom zie je dus een stuk code wat qua veiligheid niet in orde is. Code smells wat niet onderhoudbaar is en bugs voor betrouwbaarheid.

//TODO plaatje overzicht veiligheid, onderhoudbaarheid en betrouwbaarheid.

//TODO Microsoft azure.
 
## Requirements and Design
Zie hier [requirements](https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Requirements%20and%20design). En mijn [onderzoek](https://github.com/JManders07/Portfolio-s3/blob/main/IP/Documentation/UI%20Research.pdf) voor design.

## Professional
Ik maak gebruik van GIT. //TODO Ik heb branches aangemaakt. Master is waar mijn applicatie altijd op staat zonder fouten. In Development maak ik de features die er nog bij gaan komen. Deze merge ik vervolgens met de master branch zodat er alleen maar funtionaliteiten inkomen die goed werken. 

Leeruikomst | Beoordeling | Uitleg | Link naar leeruikomst |
|:-------------|:------------|:-----------------|:----:|
| Web application | Beginning | Er is communicatie tussen front en back end. Onderzoek gedaan | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Web-application | 
| Software quality | Orienting | Onderzoek gedaan naar wat ik moet doen voor de software kwaliteit. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Software%20quality
| Agile | Orienting | Ik werk in sprints met user stories | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Agile%20method
| CI/CD | Orienting | Ik heb gekeken wat ik hiervoor moet doen en klein beetje onderzoek gedaan | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/CICD
| Cultural differences and ethics | Orienting | Ik schrijf onderzoeken en code in het Engels en praten Engels wanneer er iemand uit het buitenland bij is. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Cultural%20differences%20and%20ethics
| Requirements and design | Orienting | Ik heb wat requirements opgesteld en user stories gemaakt. Ook heb ik een begin gemaakt aan het design onderzoek. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Requirements%20and%20design
| Business processes | Undefined | Wordt later aangepast, krijgen we nog een workshop over | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Business%20processes
| Professional | Orienting | Ik maak gebruik van GIT. Voor front en back-end een aparte repo gemaakt. Onderzoek en code in het Engels zodat ook andere mijn onderzoek en code kunnen bekijken | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Professional

