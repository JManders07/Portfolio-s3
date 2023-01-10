# Portfolio-s3
## Samenvatting leeruitkomst: You use software tooling and methodology that continuously monitors and improve the software quality during software development.

Ik heb unit tests en integratie test gemaakt. Een unit test is een test waarbij een indivudeel component wordt getest. Het doel is om losse functies te controleren op de kwaliteit. Wanneer alle unit testen met succes uitgevoerd worden is het tijd voor de integratietesten. Een integratietest is een test die het geheel test, dus de hele applicatie ofwel alle componenten tegelijk. Een integratietest kijkt of alle componenten goed samenwerken.

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

Ik maak gebruik van een handig framework genaamd SonarCloud. Dit is een omgeving die je code analyseert. Je ziet hier de veiligheid, onderhoudbaarheid en betrouwbaarheid van je code. Kortom zie je dus een stuk code wat qua veiligheid niet in orde is. Code smells wat niet onderhoudbaar is en bugs voor betrouwbaarheid. 
![image](https://user-images.githubusercontent.com/113422379/211168406-d2168406-a9db-49d4-869e-ed34c555fee4.png)

Een ander framework dat ik gebruik voor performancetesten is Postman. Ik test hier de performance van een API call. Zoals je hieronder kunt zien test ik of dat de API de status heeft dat het werk, snel genoeg de data teruggeeft en ofdat het voldoet aan de eisen.
![image](https://user-images.githubusercontent.com/113422379/211668948-164296e3-18cb-4802-8b33-4b15162276cb.png)

Via een google lighthouse extensie kan ik de frontend testen op performance. Dit is echter wel via een extensie bij mij vanwege tijdstekort maar je kunt er ook een script voor schrijven. Een script schrijven is beter want dan kun je via github actions dit script laten uitvoeren als je bijvoorbeeld pusht.
![image](https://user-images.githubusercontent.com/113422379/211669900-1162d03f-d8ee-4a70-8c5d-da95c2082a89.png)

