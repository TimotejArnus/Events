# Naloga NetStandard

- Naloga se nahaja v GIT projektu https://gitlab.gooya.io:444/timotej-arnus/gooya.naloga.netstandard.git.
- Pred začetkom reševanja se naredi GIT clone projekta. Uporabi se veja master.
- Naloga mora biti naložena na to vejo.

## Opis

- Potrebno je implementirati MVC aplikacijo, ki prikazuje seznam in podrobnosti dogodkov. 
- Projekt naj bo .netcoreapp 2.1 ali net5.
- Za obliko se lahko uporabi osnovni bootstrap.
- Za shranjevanje dogodkov naj se uporabi EntityFrameworkCore. 
- Baza se lahko shranjuje v pomnilniku s pomočjo Microsoft.EntityFrameworkCore.InMemory.
- Dogodki naj se ustvarijo ob zagonu aplikacije.
- Dogodek naj ima naslednja polja: Id, DatumZacetka, DatumKonca, Naziv, Opis. DatumKonca je lahko null.
- Na seznamu naj se prikazujejo naslednji stolpci: Naziv, DatumZacetka in DatumKonca.
- Ob kliku na seznam se mora odpreti stran s podrobnostmi, kjer so izpisani vsi podatki.

## Paziti na

- Koda naj bo dokumentirana (razredi, lastnosti, metode).
- Pri definiciji modela za dogodke naj bodo uporabljeni primerni podatkovni tipi.
- Pravilna uporaba konfiguracije DbContext. (Starup)
- Dela se na GIT https://gitlab.gooya.io:444/timotej-arnus/gooya.naloga.netstandard.git. Naloga mora biti oddana na to vejo.

## Uporabljene tehnologije

- GIT
- NetCore 2.1 ali Net5
- C#
- EntityFrameworkCore, Microsoft.EntityFrameworkCore.InMemory