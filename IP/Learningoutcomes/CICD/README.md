# Portfolio-s3

## Samenvatting leeruitkomst: You design and implement a (semi)automated software release process that matches the needs of the project context.

## Inhoudsopgave
- [SonarCloud](#sonarcloud)
- [Cypress](#cypress)
- [Docker](#docker)

## SonarCloud
Ik maak gebruik van SonarCloud. Dit is een omgeving die je code analyseert. Je ziet hier de veiligheid, onderhoudbaarheid en betrouwbaarheid van je code. Kortom zie je dus een stuk code wat qua veiligheid niet in orde is. Code smells wat niet onderhoudbaar is en bugs voor betrouwbaarheid. 
![image](https://user-images.githubusercontent.com/113422379/211168406-d2168406-a9db-49d4-869e-ed34c555fee4.png)

Dit wordt geregeld in een Yaml file in github actions. In dit Yaml bestand heb ik aangegeven wanneer er een push is op de main branch dat deze file wordt uitgevoerd. In deze file staat onder andere dat de sonarCloud scan uitgevoerd moet worden. Hieronder zie je hoe het Yaml bestand eruit ziet.

![image](https://user-images.githubusercontent.com/113422379/207905750-7645ea55-6d9a-458d-8717-ac55c7c7d590.png)

## Cypress
De geschreven end to end test kunnen automatisch uitgevoerd worden als ik push. Dit werkt echter nog niet volledig omdat de Github pipeline niet bij de backend en database kan. Wanneer die zijn gedeployed kan het proces geautomatiseerd worden. Het onderstaande stuk yml is klaar voor gebruik en werkt. Ik heb een unit test gemaatk voor de frontend zodat ik kon testen of dat deze yml file goed werkt.  
```yml
name: Cypress Tests

on: [push]

jobs:
  cypress-run:
    runs-on: ubuntu-latest
    steps:
      - name: Checkout
        uses: actions/checkout@v3
      - name: Cypress run
        uses: cypress-io/github-action@v5
        with:
          build: npm run build
          start: npm run serve
```

## Docker
Ik heb mijn applicatie in een docker image staan die je vervolgens in een docker container kunt runnen. .
![image](https://user-images.githubusercontent.com/113422379/211399049-ddb0ebe5-38dc-42fb-880b-3b2837759f26.png)

Als je via de terminal de docker container runt dan zie je in het overzicht van containers het volgende. Je ziet de poort 8080 staan. Dat wil zeggen dat je nu dus via de 8080 poort de applicatie kunt bezoeken.
![image](https://user-images.githubusercontent.com/113422379/211399227-50edbac0-88a3-4cbb-9553-0b9b0bf32024.png)
 

