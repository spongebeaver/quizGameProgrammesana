1. Lejupielāde un instalācija
* Lejupielādējiet projekta failus.
* Nodrošiniet, ka datorā ir instalēta .NET Framework un Visual Studio.
* Instalējiet SQLite un DB Browser for SQLite, lai apskatītu un pārvaldītu datu bāzi.
* Palaidiet programmu, atverot .exe failu vai izpildot projektu Visual Studio vidē.

2. Reģistrācija un pieteikšanās
* Pirmajā palaišanas reizē programma parādīs autorizācijas logu.
Lai reģistrētos:
* Ierakstiet lietotājvārdu un paroli.
* Noklikšķiniet uz "Reģistrēties". Lietotājs tiks saglabāts datu bāzē.
Lai pieteiktos:
* Ierakstiet savus reģistrācijas datus un spiediet "Pieslēgties".
* Ja informācija ir pareiza, programma ielādēs galveno logu ar viktorīnu.

3. Viktorīnas lietošana
* Pēc pieteikšanās sāksies viktorīna. Tiek ielādēti 10 nejauši jautājumi no datu bāzes.
* Atbildiet, izvēloties pareizo atbildi no četriem variantiem.
* Pēc katras atbildes nospiežiet "Tālāk".
* Programma parādīs, vai atbilde bija pareiza vai nepareiza.
* Pēc 10 jautājumiem tiks parādīts gala rezultāts.

4. Pogu funkcijas
"Reģistrēties" – izveido jaunu lietotāju datu bāzē.
"Pieslēgties" – pieslēdzas spēlei ar ievadīto lietotājvārdu un paroli.
"Tālāk" – pāriet pie nākamā jautājuma.
"Iziet" – aizver programmu.

5. Datu bāzes apskate un rediģēšana (DB Browser for SQLite)
* Atveriet DB Browser for SQLite.
* Nospiediet "Open Database" un izvēlieties Questions.db failu.
* Dodieties uz cilni "Browse Data", lai apskatītu esošos jautājumus un atbildes.
Jautājumu un atbilžu labošana:
* Izvēlieties ierakstu un rediģējiet vērtības.
* Nospiediet "Write Changes", lai saglabātu izmaiņas.
* Ja nepieciešams, jauni jautājumi tiek pievienoti cilnē "Execute SQL", izmantojot SQL komandas.

6. Problēmu novēršana
* Ja spēle neielādē jautājumus, pārbaudiet, vai datu bāze Questions.db atrodas pareizajā mapē.
* Ja programma nedarbojas, pārbaudiet Visual Studio Output logu un kļūdu ziņojumus.
* Ja aizmirsta parole, manuāli labojiet datu bāzi DB Browser, lai atiestatītu lietotāja informāciju.