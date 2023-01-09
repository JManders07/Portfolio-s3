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

Voor een fullstack applicatie moeten we gebruik maken van een algemeen geaccepteerd fronted Javascript framework. Ik heb gekozen voor Vue met Vue-Bootstrap. Voor de backend maak ik gebruik van c#. Voor de algemene backend gebruik ik C# met entity framework. De bedoeling was ook om nog Java te gebruiken maar dit is er niet meer van gekomen door gebrek aan tijd. Mijn beargumentatie is te vinden in mijn [onderzoeksdocument](https://github.com/JManders07/Portfolio-s3/blob/main/IP/Learningoutcomes/Web-application/Research.pdf). Nadat ik onderzoek had gedaan, heb ik ook wat [prototypes](https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Web-application) gemaakt.

Wanneer de gebruiker op de hoofdpagina komt dan ziet de gebruiker het volgende. De gebruiker kan vervolgens in de navigatiebalk aanklikken naar welke pagina die zou willen gaan. Dit wordt mogelijk door vue-router.

![image](https://user-images.githubusercontent.com/113422379/211394905-4c316f0a-8130-42f4-9d59-ac51b60f6461.png)

!!Wel mee bezig geweest en onderzoek naar gedaan maar niet volledig werkend gekregen!!
Voor accounts gebruik in een extentie genaamd Auth0. Auth0 is makkelijk toe te voegen als authenticatie- en autorisatieservice. Ik heb gekozen om niet zelf een loginsysteem te maken omdat er al ontzettend veel systemen bestaan. Het is daarom zonde van de tijd, en risicovoller wat betreft beveiliging, als ik zelf een loginsysteem ga maken.

Gebruikers van mijn applicatie kunnen een review achterlaten op een bepaald biertje. Ze kunnen een score geven van 1 tot 10 op basis van sterren. Dit maakt het wat gebruiksvriendelijker dan een getal. Ook kunnen ze een reactie typen als toevoeging op de review.

![image](https://user-images.githubusercontent.com/113422379/211395434-e817e452-e7f7-4b9e-bb62-3f7214f3f6d9.png)

Tot zover mijn frontend uitgelegd. Wat betreft de backend maak ik gebruik van een apart lopende database. Hier staan alle bieren en reviews in opgeslagen. Ik maak gebruik van een MySQL database. In een relationele database wordt alle data opgeslagen in opslagruimtes, genaamd tabellen. Het databasebeheersysteem is ontwikkeld door Oracle. Hieronder zie je een voorbeeld van een tabel.

![image](https://user-images.githubusercontent.com/113422379/211395645-b1642188-3f18-49c4-8d4e-1f385edc63fb.png)

In mijn C# backend heb ik zelf API calls gemaakt die ervoor zorgen dat ik met de frontend kan communiceren. Ik kan bijvoorbeeld via de frontend bieren opvragen aan de backend. Deze worden vervolgens door middel van een API call doorgestuurd aan de frontend. De pagina staat nu vol met de opgevraagde bieren. Dit is een POST in de backend. 

```c#
[HttpPost]
        public string NewBeer([FromBody] Beer beer)
        {
            if (beer != null)
            {
                try
                {
                    _beerLogic.NewBeer(beer);
                    return "Perfect";

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return "";
        }
  ```

Anderssom kan het namelijk ook. Wanneer ik een biertje of review wil toevoegen aan de database roept de frontend ook een API call aan. De backend verkrijgt nu informatie van de frontend en stopt deze in de database. Dit is een GET.

Hieronder zie je een afbeelding van hoe een GET method eruit ziet:

```c#
[Route("[action]")]
        [HttpGet]
        public JsonResult Beers()
        {
            List<Beer> beers = new();
            foreach (var beer in _beerLogic.Beers())
            {
                beers.Add(beer);
            }
            return Json(beers);
        }

        [HttpGet("{id:int}")]
        public JsonResult Beer(int id)
        {
            Beer beer = _beerLogic.Beer(id);
            return Json(beer);
        }
```

Voor mijn project maak ik gebruik van aparte git repo's voor de backend en frontend.  
[BeerWithFriends-Front-end](https://github.com/JManders07/BeerWithFriends-Front-end)  
[BeerWithFriends-Back-end](https://github.com/JManders07/BeerWithFriends-Back-end)

 ## Software quality
 Samenvatting leeruitkomst: You use software tooling and methodology that continuously monitors and improve the software quality during software development.
 
Softwarekwaliteit is een breed begrip. Het is vaak moeilijk toe te passen omdat veel verschillende werkwijzes zijn om goede software te maken. De kwaliteit van software kun je eigenlijk zien als een vraag: "Doet de software wat hij moet doen?" Dat is een vraag die we kunnen beantwoorden aan de hand van testen. Het is belangrijk om testen te schrijven. Ik heb unit tests en integratie test gemaakt. Een unit test is een test waarbij een indivudeel component wordt getest. Het doel is om losse functies te controleren op de kwaliteit. Wanneer alle unit testen met succes uitgevoerd worden is het tijd voor de integratietesten. Een integratietest is een test die het geheel test, dus de hele applicatie ofwel alle componenten tegelijk. Een integratietest kijkt of alle componenten goed samenwerken.

Hieronder zie je hoe ik een in memory database opzet. Dit is een tijdelijke database die iedere keer opgezet wordt als er een test wordt uitgevoerd. Er worden iedere keer 2 bieren aan toegevoegd zodat er altijd data in de testdatabase zit. Dit zou je ook op een andere manier kunnen doen, namelijk door middel van profiles. Je kunt dan aangeven in welke omgeving je werkt. Wanneer je bijvoorbeeld in een testomgeving werkt kun je dat selecteren en dan pakt hij automatisch bijvoorbeeld een andere connectiestring.

```c#
[TestInitialize]
        public void Setup()
        {
            var dbContextOptions =
                new DbContextOptionsBuilder<BeerWithFriendsBackendContext>().UseInMemoryDatabase("TestDb");
            _context = new BeerWithFriendsBackendContext(dbContextOptions.Options);
            _context.Database.EnsureCreated();

            var beerData = new BeerData(_context);

            _logic = new BeerLogic(beerData);

            var beer1 = new Beer
            {
                Name = "La chouffe",
                Description = "Erg lekker",
                AlcoholPercentage = 6
            };

            var beer2 = new Beer
            {
                Name = "Heineken",
                Description = "Lekker",
                AlcoholPercentage = 5
            };

            _logic.NewBeer(beer1);
            _logic.NewBeer(beer2);
        }
```

Hieronder zie je een unit test:

```c#
[TestMethod]
        public void TryCreate1BeerTest()
        {
            var beer3 = new Beer
            {
                Name = "La chouffe",
                Description = "Erg lekker",
                AlcoholPercentage = 6
            };


            var text = _logic.NewBeer(beer3);

            Assert.AreEqual("Succes", text);
        }
 ```

Hieronder zie je een integratie test: 

```c#
[TestMethod]
        public void TryCreate2Beers1Fail1SuccesTest()
        {
            var beer3 = new Beer
            {
                Name = "La chouffe",
                Description = "Erg lekker",
                AlcoholPercentage = -6
            };

            var beer4 = new Beer
            {
                Name = "Heineken",
                Description = "Lekker",
                AlcoholPercentage = 5
            };

            _logic.NewBeer(beer3);
            _logic.NewBeer(beer4);

            Assert.AreEqual(3, _logic.Beers().Count);
        }
 ```

Er zijn ook nog end 2 end tests gemaakt. Deze zijn gemaakt met het Cypress framework. Dit is een erg populair en krachtig testframework. Hieronder zie je hoe een end 2 end test eruit ziet. Deze end 2 end test kijkt of dat je naar de pagina kan gaan voor een nieuw biertje aan te maken, vervolgens maakt cypress dit biertje aan en kijkt of hij daadwerkelijk is aangemaakt. Als dit alles klopt dan verwijderd cypress het biertje weer om onnodige data te voorkomen.

```js
describe('template spec', () => {
  it('Goes to the beerpage and finds a beer with the name Jupiler', () => {
    cy.visit('/')
    cy.contains('New Beer').click()
    cy.get('#__BVID__19').type('Cypress')
    cy.get('#__BVID__20').type('Cypress is very good at testing')
    cy.get('#__BVID__21').type('5')
    cy.contains('Submit').click()
    cy.contains('Beers').click()
    cy.get(':nth-child(2) > .card-body > :nth-child(3) > a').click()
    cy.contains('Cypress')
    cy.contains('Delete').click()
    cy.reload()
  })
})
```
Voor de kwaliteit van mijn software is mijn backend geschreven in 3 lagen. Ik gebruik op dit moment Entity framework zodat ikzelf de database als het ware niet aanraak. Je hoeft dan niet zelf query's te schrijven en beperkt hiermee de veiligheidsrisico's. Entity framework zorgt ervoor dat je door middel van een context toch acties kan uitvoeren op de database. De 3 lagen zorgen ervoor dat er niet direct vanuit de controller acties uitgevoerd kunnen worden die met de database te maken hebben.

## CI/CD
Samenvatting leeruitkomst: You design and implement a (semi)automated software release process that matches the needs of the project context.
Ik maak gebruik van SonarCloud. Dit is een omgeving die je code analyseert. Je ziet hier de veiligheid, onderhoudbaarheid en betrouwbaarheid van je code. Kortom zie je dus een stuk code wat qua veiligheid niet in orde is. Code smells wat niet onderhoudbaar is en bugs voor betrouwbaarheid. 
![image](https://user-images.githubusercontent.com/113422379/211168406-d2168406-a9db-49d4-869e-ed34c555fee4.png)

Dit wordt geregeld in een Yaml file in github actions. In dit Yaml bestand heb ik aangegeven wanneer er een push is op de main branch dat deze file wordt uitgevoerd. In deze file staat onder andere dat de sonarCloud scan uitgevoerd moet worden. Hieronder zie je hoe het Yaml bestand eruit ziet.

![image](https://user-images.githubusercontent.com/113422379/207905750-7645ea55-6d9a-458d-8717-ac55c7c7d590.png)

De hierboven beschreven end to end test wordt automatisch getest door de pipeline van github. Door het onderstaande stuk code worden alle end 2 end tests uitgevoerd en weet ik meteen als er iets niet goed werkt.
```yml
name: Cypress Tests

on: [push]

jobs:
  cypress-run:
    runs-on: ubuntu-latest
    steps:
      - name: Checkout
        uses: actions/checkout@v3
      # Install NPM dependencies, cache them correctly
      # and run all Cypress tests
      - name: Cypress run
        uses: cypress-io/github-action@v5 # use the explicit version number
        with:
          build: npm run build
          start: npm run serve
```

Ik heb mijn applicatie in een docker image staan die je vervolgens in een docker container kunt runnen. Deze docker container kun je gebruiken als je de website online gaat zetten. Het maakt dan niet uit vanaf welk apparaat je het opstart. Hieronder zie je de image.
![image](https://user-images.githubusercontent.com/113422379/211399049-ddb0ebe5-38dc-42fb-880b-3b2837759f26.png)

Als je via de terminal de docker container runt dan zie je in het overzicht van containers het volgende. Je ziet de poort 8080 staan. Dat wil zeggen dat je nu dus via de 8080 poort de applicatie kunt bezoeken.
![image](https://user-images.githubusercontent.com/113422379/211399227-50edbac0-88a3-4cbb-9553-0b9b0bf32024.png)
 
## Requirements and Design
Samenvatting leeruitkomst: You analyze (non-functional) requirements, elaborate (architectural) designs and validate them using multiple types of test techniques.
Zie hier mijn opgestelde [requirements](https://github.com/JManders07/Portfolio-s3/blob/main/IP/Learningoutcomes/Requirements%20and%20design/Requirements.pdf). In dit bestand vind je ook user stories en de requirements gesorteerd op MoSCoW wijze. Mijn [onderzoek](https://github.com/JManders07/Portfolio-s3/blob/main/IP/Documentation/UI%20Research.pdf) voor design is voor de schermontwerpen. Mijn compleet uitgewerkte c4 model kun je per laag vinden in de map voor [requirements en design](https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Requirements%20and%20design).

## Business processes
//TODO uitwerken

## Professional
Ik maak gebruik van GIT. Ik heb branches aangemaakt. Master is waar mijn applicatie altijd op staat zonder fouten. In Development maak ik de features die er nog bij gaan komen. Deze merge ik vervolgens met de master branch zodat er alleen maar funtionaliteiten inkomen die goed werken. Ik heb een projectbord aangemaakt op github. Hierop kan ik tags toevoegen en verslepen tussen de 4 tabjes. Zo kun je per sprint makkelijk zien wat er nog moet gebeuren en kan wanneer nodig iemand zonder problemen inspringen. Ik heb verschillende gesprekken gehad met zowel de docent(Hans) als de stakeholder van het groepsproject(Tom). Deze gesprekken zijn goed verlopen en hebben steeds de feedback opgeschreven en deze verwerkt. In het groepsproject hadden we de een na laatste sprint te maken met ziekte waardoor we niet bij de scraper konden. Dit hebben we professioneel met de stakeholder(Tom) besproken. 

Huidige zelfreflectie:
Leeruikomst | Beoordeling | Uitleg | Link naar leeruikomst |
|:-------------|:------------|:-----------------|:----:|
| Web application | Proficient | Er is communicatie tussen front en back end. GET, POST, DELETE en PUT kunnen worden uitgevoerd. Ook kan je een rating aan een biertje geven. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Web-application | 
| Software quality | Proficient | Onderzoek gedaan naar wat ik moet doen voor de software kwaliteit. Unit test en integratietests geschreven. end 2 end test geschreven. Deze is ook geautomatisserd wanneer ik push. Ook is SonarCloud geautomatiseerd wanneer ik push. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Software%20quality
| Agile | Proficient | Ik werk in sprints met user stories. Ook in het groepsproject maken we gebruik van sprints. Ik bekijk iedere sprint wat er moet gebeuren en pas waar nodig de requirements aan zodat ik flexibel te werk kan gaan. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Agile%20method
| CI/CD | Proficient | Ik heb gekeken wat ik hiervoor moet doen en onderzoek gedaan. Ik heb Sonarcloud werkend gekregen. Iedere keer als ik push dan wordt de scan uitgevoerd. Ook wordt de end2end test automatisch uitgevoerd door github actions. De applicatie is gedockerized. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/CICD
| Cultural differences and ethics | Beginning | Ik schrijf onderzoeken en code in het Engels en praat Engels wanneer er iemand uit het buitenland bij is. Ik heb een workshop voorbereid (//todo geven). Ik houd rekening met hoe mijn groepsgenoten zijn. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Cultural%20differences%20and%20ethics
| Requirements and design | Proficient | Ik heb requirements opgesteld en gesorteerd op MoSCow wijze. Ook heb ik userstories gemaakt. Verder heb ik designs gemaakt. C4/Architectuur model klaar. Ook het databasediagram gemaakt. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Requirements%20and%20design
| Business processes | beginning | Business processen nog beschrijven. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Business%20processes
| Professional | Proficient | Ik maak gebruik van GIT. Voor front en back-end een aparte repo gemaakt. Onderzoek en code in het Engels zodat ook andere mijn onderzoek en code kunnen bekijken. Ik heb iedere week een gesprek met mijn individuele docent om te laten zien wat ik heb. In het groepsproject hebben we iedere 3 weken een gesprek met de stakeholder. We gaan hierin het gesprek aan over wat zij willen dat er klaar is de volgende sprint. Ik maak gebruik van het Github planningsbord met labels. Zo heb ik altijd duidelijk wat ik doe en kunnen anderen die in mijn project inspringen | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Professional

2e zelfreflectie:
Leeruikomst | Beoordeling | Uitleg | Link naar leeruikomst |
|:-------------|:------------|:-----------------|:----:|
| Web application | Beginning | Er is communicatie tussen front en back end. Onderzoek gedaan. Nog functies toevoegen. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Web-application | 
| Software quality | Beginning | Onderzoek gedaan naar wat ik moet doen voor de software kwaliteit. Unit test en integratietests geschreven. Nu nog meer andere soorten tests. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Software%20quality
| Agile | Proficient | Ik werk in sprints met user stories. Ook in het groepsproject maken we gebruik van sprints. Ik bekijk iedere sprint wat er moet gebeuren en pas waar nodig de requirements aan zodat ik flexibel te werk kan gaan. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Agile%20method
| CI/CD | Beginning | Ik heb gekeken wat ik hiervoor moet doen en onderzoek gedaan. Ik heb Sonarcloud werkend gekregen. Iedere keer als ik push dan wordt de scan uitgevoerd. De applicatie moet nog gedockerized worden. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/CICD
| Cultural differences and ethics | Beginning | Ik schrijf onderzoeken en code in het Engels en praat Engels wanneer er iemand uit het buitenland bij is. Ik heb een workshop voorbereid (//todo geven). Ik houd rekening met hoe mijn groepsgenoten zijn. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Cultural%20differences%20and%20ethics
| Requirements and design | Beginning | Ik heb requirements opgesteld en gesorteerd op MoSCow wijze. Ook heb ik userstories gemaakt. Verder heb ik designs gemaakt. C4/Architectuur model nog aanpassen. Als het moet nog databasediagram maken. | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Requirements%20and%20design
| Business processes | Proficient | Ik heb iedere week een gesprek met mijn individuele docent om te laten zien wat ik heb. In het groepsproject hebben we iedere 3 weken een gesprek met de stakeholder. We gaan hierin het gesprek aan over wat zij willen dat er klaar is de volgende sprint. Ik maak gebruik van het Github planningsbord met labels. Zo heb ik altijd duidelijk wat ik doe en kunnen anderen die in mijn project inspringen | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Business%20processes
| Professional | Orienting | Ik maak gebruik van GIT. Voor front en back-end een aparte repo gemaakt. Onderzoek en code in het Engels zodat ook andere mijn onderzoek en code kunnen bekijken | https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Professional

1e zelfreflectie:
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

