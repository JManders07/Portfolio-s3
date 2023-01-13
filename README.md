# Portfolio-s3

Welkom bij mijn portfolio van semester 3. Hier vind je alles wat hoort bij mij individueel- en groepsproject.

## Introductie
Mijn naam is Jelle Manders, 20 jaar oud. Ik ben student aan de opleiding HBO-ICT bij Fontys Hogescholen in Eindhoven.

## Inhoudsopgave
- [Introductie](#introductie)
- [Web Application](#web-application)
- [Software quality](#software-quality)
- [Agile](#agile)
- [CI/CD](#cicd)
- [Cultural differences and Ethics](#cultural-differences-and-ethics)
- [Requirements and design](#requirements-and-design)
- [Business Processes](#business-processes)
- [Professional](#professional)
- [Zelfreflectie](#zelfreflectie)

## Web Application
Samenvatting leeruitkomst: You design and build user-friendly, full-stack web applications.

Voor dit leeruitkomst heb ik een full stack web applicatie voor bierliefhebbers gemaakt met een frontend geschreven met Vue met Vue bootstrap. De backend is geschreven met c# met entity framework en een MYSQL database:
- [Individueel project](https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Web-application)

Ook heb ik een UX/UI onderzoek uitgevoerd voor het user-friendly deel van de web application:
- [UI/UX onderzoek](https://github.com/JManders07/Portfolio-s3/blob/main/IP/Learningoutcomes/Web-application/UI%20research.pdf)

### Reflectie
#### Wat ging er goed?
Ik had vrij snel de connectie opstaan tussen de back en front end. Daarnaast had ik enkele functionaliteiten erin zitten. Ik heb later ook nog auth0 toegevoegd als authenticatie.
#### Wat kon er beter?
Ik ben te laat begonnen aan de functionaliteiten. Ik heb te veel onderzoek gedaan naar de API en bedacht wat ik ging maken. Hierdoor kwam ik tijd tekort voor extra functionaliteiten.
#### Wat doe ik de volgende keer anders:
De volgende keer begin ik eerder met het maken van de applicatie. Ik zorg er voor dat ik iedere sprint functionaliteiten toevoeg en niet teveel focus op andere zaken.

## Software quality
Samenvatting leeruitkomst: You use software tooling and methodology that continuously monitors and improve the software quality during software development.
 
Softwarekwaliteit is een breed begrip. De kwaliteit van software kun je eigenlijk zien als een vraag: "Doet de software wat hij moet doen?" Dat is een vraag die we kunnen beantwoorden aan de hand van testen. Het is belangrijk om testen te schrijven. Ik heb Post/Swagger gebruikt dat al mijn endpoints het juiste retourneren en dat binnen een bepaalde tijd doen. Ik gebruik SonarCloud voor de kwaliteit van mijn code. Ik heb Cypress gebruikt voor de end 2 end testen. Ik heb een OWASP research gedaan naar Injection.
- [Software quality](https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Software%20quality/README.md)

OWASP Injection research
- [Software quality onderzoek](https://github.com/JManders07/Portfolio-s3/blob/main/IP/Learningoutcomes/Software%20quality/Research.pdf)

#### Wat ging er goed?
De testen schrijven ging goed. Ik heb goede betrouwbare testen geschreven. Voor de back en front end. Ik heb mijn onderzoek gedaan naar OWASP Injection en dat ging goed en volgens het dot framework WHAT, WHY, HOW.
#### Wat kon er beter?
Ik had de tests eerder kunnen schrijven zodat de kwaliteit van de code vanaf het begin wordt gewaarborgd. Verder had ik de tests iets kunnen uitbreiden. De tests zijn klaar om geautomatiseerd worden, dit kan echter niet omdat de backend en database niet in een docker container runnen. 
#### Wat doe ik de volgende keer anders?
De volgende keer schrijf ik vanaf het begin testen zodat ik voor ieder stuk code dat ik schrijf, goed controleer of dat het daadwerkelijk werkt en veilig is. Ik begin ook eerder met het CI/CD gedeelte zodat de tests geautomatiseerd kunnen worden.

## Agile
Samenvatting leeruitkomst: You choose and implement the most suitable agile software development method for your software project.
In dit semester heb ik ervoor gekozen om met de agile methode SCRUM in combinatie met Kanban te werken. SCRUM vanwege de sprints en Kanban vanwege het bord. 
- [Agile onderzoek](https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Agile%20method)

## CI/CD
Samenvatting leeruitkomst: You design and implement a (semi)automated software release process that matches the needs of the project context.

Er is een automatische workflow gemaakt in Github. Hierdoor zouden de tests automatisch kunnen runnen. De static code analysis van SonarCloud wordt iedere keer uitgevoerd als ik push. De tests nog niet vanwege de backend en database die niet op een docker container runnen. De frontend runt wel op een docker container.
Continious integration en continious delivery:
- [CI/CD](https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/CICD/README.md)
#### Wat ging goed?
De SonarCloud analysis had ik werkend gekregen. Hierdoor kon ik zien wat de kwaliteit van mijn code was. Ik heb ook hier onderzoek naar gedaan wat een goede static code analysis was. 
#### Wat kon beter?
Ik had de applicatie eerder in een docker container moeten zetten. Wanneer ik dit eerder had gedaan kon ik eerder feedback vragen waarom het voor de backend bijvoorbeeld niet deed. Ook hier ben ik te lang bezig geweest met het onderzoeken en kijken in plaats van het gewoon proberen.
#### Wat doe ik de volgende keer anders?
De volgende keer ga ik niet teveel onderzoeken maar het daadwerkelijk implementeren. Dit is belangrijk zodat ik tijdig feedback kan vragen.

## Cultural differences and Ethics
Ik heb onderzoek gedaan naar Cultural differences and Ethics en mijn eigen kijk op dit aspect vastgelegd:
- [Cultural differences and Ethics](https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Cultural%20differences%20and%20ethics)

Ook heb ik een workshop voorbereid en gegeven:
- [Workshop Cultural differences and Ethics](https://github.com/fontys-open-up/2223nj-db03/tree/main/ethics-and-cultural-differences-workshop)

#### Wat ging er goed?
Ik heb onderzoek gedaan en dit beschreven in mijn document. Ook vind ik dat de voorbereiding van de workshop goed is gegaan. We hebben goed overleg en een goede workshop voorbereid. Ik denk dat een interactieve workshop leuk is voor de medestudenten.
#### Wat kon er beter?
In het begin vond ik het erg lastig om mijn mening te geven in het groepsproject. Dit kwam omdat er 2 personen zijn die extravert zijn en ik ben introvert. Ik hield me vaak stil omdat deze 2 personen een duidelijkere mening gaven. Dit is wel iets verbeterd maar nog niet echt zodanig als dat ik had gehoopt.
#### Wat doe ik de volgende keer anders?
De volgende keer probeer ik in het begin afspraken te maken met mijn groepsgenoten over het geven van meningen en dergelijken in het groepsproject.

## Requirements and Design
Samenvatting leeruitkomst: You analyze (non-functional) requirements, elaborate (architectural) designs and validate them using multiple types of test techniques.

Ik heb requirements en user stories opgesteld:
- [Requirements](https://github.com/JManders07/Portfolio-s3/blob/main/IP/Learningoutcomes/Requirements%20and%20design/Requirements.pdf)
Ook heb ik een UI/UX onderzoek gedaan volgens het DOT framework.
- [UI/UX onderzoek](https://github.com/JManders07/Portfolio-s3/blob/main/IP/Documentation/UI%20Research.pdf)
Via de onderstaande link kun je mijn architectuurmodel in 3 lagen bekijken. 
- [Architectuurmodel](https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Requirements%20and%20design)

#### Wat ging er goed?
De requirements opstellen ging goed. Ik heb volgens richtlijnen requirements opgesteld. Ook heb ik userstories opgesteld. Dit om duidelijk te maken wat de bedoeling van de app was. 
#### Wat kon er beter?
Ik kon beter opletten op de naamgeving. Ik had in eerste instantie bijvoorbeeld als non functional requirement dat de app in het Nederlands weergeven moest worden vanwege oudere mensen die geen of slecht Engels kunnen. Dit heb ik na feedback veranderd in maintainability. Dit omschrijft het probleem wat groter.
#### Wat doe ik de volgende keer anders?
Ik zou de volgende keer niet perse iets anders doen. Het opstellen van de requirements, userstories en architectuurmodel ging volgens het proces. 

## Business processes
Voor business processes heb ik een workshop gevolgd door mijn medestudenten. Hieruit is mijn volgende bestand gekomen:
- [Business Processes](https://github.com/JManders07/Portfolio-s3/tree/main/IP/Learningoutcomes/Business%20processes)


#### Wat ging er goed?
Het opstellen van een business process ging goed. De workshop gegeven door mijn medestudenten heeft hier erg veel aan bijgedragen. Ik vond het fijn dat we hier toch uitleg over kregen.
#### Wat kon er beter?
Ik kon beter ook extra feedback vragen aan Marc(Semestercoach). Ik heb nu een eigen business process gemaakt op basis van de workshop van mijn medestudenten. Ik heb alleen nu geen feedback gevraagd aan Marc. 
#### Wat doe ik de volgende keer anders?
De volgende keer ga ik een business process maken en deze eerder laten zien aan mijn semester coach. Zo kan ik eerder feedback krijgen en verwerken zodat het business process geoptimaliseerd word.

## Professional
Ik maak gebruik van GIT. Ik heb een projectbord aangemaakt op github.
- [Planningsbord](https://github.com/users/JManders07/projects/1) 

Hierop kan ik tags toevoegen en verslepen tussen de 4 tabjes. Zo kun je per sprint makkelijk zien wat er nog moet gebeuren en kan wanneer nodig iemand zonder problemen inspringen. Ik heb verschillende gesprekken gehad met zowel de docent(Hans) als de stakeholder van het groepsproject(Tom). Deze gesprekken zijn goed verlopen en hebben steeds de feedback opgeschreven en deze verwerkt. In het groepsproject hadden we de een na laatste sprint te maken met ziekte waardoor we niet bij de scraper konden. Dit hebben we professioneel met de stakeholder(Tom) besproken. 

#### Wat ging er goed?
De gesprekken met de opdrachtgever gingen goed. Het opzetten van het bord ging ook goed. Ik had snel een goede backlog met daarin duidelijk wat ik allemaal moest doen. 
#### Wat kon er beter?
Het bord opzetten is een ding, maar het onderhouden is een ander ding. Het bord onderhouden ging niet zo goed. Ik heb in het begin moeite gehad met het bijhouden van het bord zodat het klopte. Na een paar weken ging dit beter.
#### Wat doe ik de volgende keer anders?
De volgende keer ga ik mijn bord beter bijhouden zodat het klopt. Zo heb ik zelf een beter inzicht in wat ik nog moet doen. Hierop kan ik dan ook beter mijn planning op maken. 


## Zelfreflectie

Wat ging er goed?

In mijn individueel project ging het op het begin goed. Ik had veel onderzoek gedaan. Dit resulteerde in een brede kennis. In het groepsproject is de samenwerking ook goed gegaan. Ook de communicatie met de opdrachtgever ging goed. Zoals beschreven hadden we iemand die ziek was maar hebben we dit professioneel opgelost met de opdrachtgever. 

Wat kan er beter?

Ik ben in het begin veel met onderzoek bezig geweest. Te veel zelfs, ik had eerder moeten beginnen met het concreet afmaken van de uitkomsten van mijn onderzoek. Ook had ik mijn onderzoek beter moeten notuleren. Verder ben ik op het laatst te laat begonnen en heb ik erg hard moeten werken de laatste weken met als resultaat dat niet alles is geworden als hoe ik het voor me had gezien. 

Wat ga ik de volgende keer anders doen?

De volgende keer ga ik eerder beginnen met concrete voorbeelden te maken. Wanneer ik onderzoek heb gedaan ga ik meteen een prototype maken en daarna dit verwerken in mijn hoofdapplicatie. Voor het onderzoek houd ik de volgende keer een logboek bij. Wanneer ik een site heb bezocht, een stuk tekst heb gezien of een video heb gezien plak ik deze link in mijn logboek. Zo kan ik altijd terugvinden waar ik informatie vandaan heb.

