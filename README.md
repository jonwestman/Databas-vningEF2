# Databas-vningEF2

# Om uppgiften

Denna uppgift handlar om att du ska skapa en ER-modell för en helt ny databas, skapa den databasen samt skriva några grundläggande SQL-frågor som hämtar data ur databasen.

# Case

Den databas du skall skapa är en fiktiv skola som vill lagra information om elever, lärare, kurser, betyg m.m. Skolan är en gymnasieskola. 

Deras kravställning är följande:

- Vi vill kunna spara ner vår personal och se om de är lärare, administratörer, rektor eller om de har någon annan befattning.
- Vi vill kunna spara ner studenter och se vilken klass de går i. Studenterna behöver ha namn och personnummer m.m.
- Vi vill kunna spara ner betyg för en elev i varje kurs de läst och vi vill kunna se vilken lärare som satt betyget. Betyg ska också ha ett datum då de satts.

# Vad du ska göra

- [ ]  Ta fram en ER-modell för databasen. Denna ska visa vilka entiteter som finns, deras attribut samt relationerna mellan dessa.
- [ ]  Skapa databasen i SQL Server Management Studio (SSMS). Databasen du skapar ska följa din ER-modell.
- [ ]  Sätta in lite testdata i databasen (ca 3-5 rader i varje tabell)
- [ ]  Ta fram SQL queries för följande:
    - [ ]  Hämta alla lärare (dvs. inte personal med andra befattningar)
    - [ ]  Hämta alla studenter i bokstavsordning, sorterat på efternamn
    - [ ]  Hämta alla studenter i en viss klass
    - [ ]  Hämta alla betyg som satts den senaste månaden
