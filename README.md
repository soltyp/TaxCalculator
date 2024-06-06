## PRZYKŁADOWE SS
![e](images/1.png)
![e](images/2.png)

## Opis
Projekt Kalkulator Podatkowy to aplikacja Windows Forms przeznaczona do obliczania podatku i dochodu netto na podstawie rocznego dochodu użytkownika i wybranego kraju. Aplikacja obsługuje wiele krajów, z których każdy ma własne zasady obliczania podatków.

Komponenty:
- FormCalculator.cs: Główna forma, gdzie użytkownicy wprowadzają swoje dochody i wybierają kraj.
- TaxCalculatorBase.cs: Abstrakcyjna klasa bazowa dla różnych kalkulatorów podatkowych specyficznych dla krajów.
- FranceTaxCalculator.cs: Logika obliczania podatków dla Francji.
- GermanyTaxCalculator.cs: Logika obliczania podatków dla Niemiec.
- PolandTaxCalculator.cs: Logika obliczania podatków dla Polski.
- UKTaxCalculator.cs: Logika obliczania podatków dla Wielkiej Brytanii.
- USATaxCalculator.cs: Logika obliczania podatków dla Stanów Zjednoczonych.
- Program.cs: Punkt wejścia aplikacji.

## Szczegółowy Opis
1. FormCalculator.cs
Jest to główna forma, gdzie użytkownicy wchodzą w interakcję z aplikacją.

Pola i Kontrolki:
countryComboBox: Lista rozwijana do wyboru kraju.
incomeTextBox: Pole tekstowe do wprowadzania rocznego dochodu.
calculateButton: Przycisk do uruchamiania obliczeń podatkowych.
taxResultLabel: Etykieta do wyświetlania obliczonego podatku.
netIncomeResultLabel: Etykieta do wyświetlania dochodu netto.

Zdarzenia:
FormCalculator_Load: Inicjalizuje formę.
calculateButton_Click: Obsługuje zdarzenie kliknięcia przycisku obliczeń.

Logika:
Walidacja danych wprowadzonych przez użytkownika.
Instancjonowanie odpowiedniego kalkulatora podatkowego na podstawie wybranego kraju.
Obliczanie podatku i dochodu netto oraz wyświetlanie wyników.

2. TaxCalculatorBase.cs
Ta abstrakcyjna klasa definiuje strukturę dla kalkulatorów podatkowych specyficznych dla krajów.

Metody:
CalculateTax(decimal income): Abstrakcyjna metoda do obliczania podatku na podstawie dochodu.

4. FranceTaxCalculator.cs
Implementuje logikę obliczania podatków specyficzną dla Francji.

Progi Podatkowe:
Dochód do 10 064 €: 0%
10 064 € - 25 659 €: 11%
25 659 € - 73 369 €: 30%
73 369 € - 157 806 €: 41%
Powyżej 157 806 €: 45%
Metoda:
CalculateTax(decimal annualIncome): Oblicza podatek na podstawie francuskich progów podatkowych.

4. GermanyTaxCalculator.cs
Implementuje logikę obliczania podatków specyficzną dla Niemiec.

Progi Podatkowe:
Dochód do 9 984 €: 0%
9 984 € - 58 596 €: 14%
58 596 € - 277 825 €: 42%
Powyżej 277 825 €: 45%

Metoda:
CalculateTax(decimal incomeEur): Oblicza podatek na podstawie niemieckich progów podatkowych.

5. PolandTaxCalculator.cs
Implementuje logikę obliczania podatków specyficzną dla Polski.

Progi Podatkowe:
Dochód do 120 000 PLN: 12%
Powyżej 120 000 PLN: 32%

Metoda:
CalculateTax(decimal income): Oblicza podatek na podstawie polskich progów podatkowych.

6. UKTaxCalculator.cs
Implementuje logikę obliczania podatków specyficzną dla Wielkiej Brytanii.

Progi Podatkowe:
Dochód do £12 570: 0%
£12 570 - £50 270: 20%
£50 270 - £150 000: 40%
Powyżej £150 000: 45%

Metoda:
CalculateTax(decimal income): Oblicza podatek na podstawie brytyjskich progów podatkowych.

7. USATaxCalculator.cs
Implementuje logikę obliczania podatków specyficzną dla Stanów Zjednoczonych.

Progi Podatkowe:
Dochód do $9 950: 10%
$9 950 - $40 525: 12%
$40 525 - $86 375: 22%
$86 375 - $164 925: 24%
$164 925 - $209 425: 32%
$209 425 - $523 600: 35%
Powyżej $523 600: 37%

Metoda:
CalculateTax(decimal annualIncome): Oblicza podatek na podstawie amerykańskich progów podatkowych.

8. Program.cs
Punkt wejścia aplikacji.
Metody:
Main(): Konfiguruje i uruchamia aplikację.

## Użytkowanie
Uruchomienie Aplikacji:
Uruchom plik wykonywalny, aby otworzyć główną formę.

Wybór Kraju:
Wybierz kraj z listy rozwijanej.

Wprowadzenie Dochodu:
Wprowadź roczny dochód w podanym polu tekstowym.

Obliczanie:
Kliknij przycisk "Calculate", aby obliczyć podatek i dochód netto.

Wyniki:
Obliczony podatek i dochód netto są wyświetlane na formie.

Obsługa Błędów

Nieprawidłowy Wybór Kraju:
Wyświetla komunikat, jeśli nie wybrano żadnego kraju.

Nieprawidłowy Dochód:
Wyświetla komunikat, jeśli dochód nie jest poprawną liczbą dziesiętną lub jest mniejszy od 0.

Rozszerzenia
Dodatkowe Kraje:
Nowe kalkulatory podatkowe dla krajów można dodać, tworząc nowe klasy dziedziczące po TaxCalculatorBase i implementujące metodę CalculateTax.

Ulepszenia Interfejsu:
Interfejs użytkownika można ulepszyć dla lepszego doświadczenia użytkownika.

## Jest to projekt przedstawiajacy polimorfizm
