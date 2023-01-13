# Portfolio-s3
## Leeruitkomst: You design and build user-friendly, full-stack web applications

Voor een fullstack applicatie moeten we gebruik maken van een algemeen geaccepteerd fronted Javascript framework. Ik heb gekozen voor Vue met Vue-Bootstrap. Voor de backend maak ik gebruik van c#. Voor de algemene backend gebruik ik C# met entity framework. De bedoeling was ook om nog Java te gebruiken maar dit is er niet meer van gekomen door gebrek aan tijd. Mijn beargumentatie is te vinden in mijn [onderzoeksdocument](https://github.com/JManders07/Portfolio-s3/blob/main/IP/Learningoutcomes/Web-application/Research.pdf). Nadat ik onderzoek had gedaan, heb ik ook wat [prototypes](https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Web-application) gemaakt.

Wanneer de gebruiker op de hoofdpagina komt dan ziet de gebruiker het volgende. De gebruiker kan vervolgens in de navigatiebalk aanklikken naar welke pagina die zou willen gaan. Dit wordt mogelijk door vue-router.

![image](https://user-images.githubusercontent.com/113422379/211394905-4c316f0a-8130-42f4-9d59-ac51b60f6461.png)

Voor accounts gebruik in een extentie genaamd Auth0. Auth0 is makkelijk toe te voegen als authenticatie- en autorisatieservice. Ik heb gekozen om niet zelf een loginsysteem te maken omdat er al ontzettend veel systemen bestaan. Het is daarom zonde van de tijd, en risicovoller wat betreft beveiliging, als ik zelf een loginsysteem ga maken.

![image](https://user-images.githubusercontent.com/113422379/211667445-0f51f4fe-b74b-457c-b707-80c6f5c0396a.png)

Om verder in te gaan op Auth0, heb ik een functionaliteit toegevoegd die ervoor zorgt dat je alleen als admin de create functie kunt uitvoeren. Zoals je hieronder in het filmpje ziet is er niet ingelogd. De create functie is niet zichtbaar. Wanneer ik inlog met Admin@Admin.com verschijnt de create beer button. Als ik vervolgens inlog met jellemanders2001@gmail.com verdwijnt de create button weer.


https://user-images.githubusercontent.com/113422379/212413145-749beff0-16ba-4a06-9b75-32b384360721.mp4



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
