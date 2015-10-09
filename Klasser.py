# Klasser

## Organisation

## Medarbejder

## CRM

## Customer

## Projekt

| Hændelse          | Organisation | Medarbejder | Projects | Kunde | Documents | Billing | Booking | Produkt |
|-------------------|--------------|-------------|----------|-------|-----------|---------|---------|---------|
| Kunde oprettet    | x            |             |          | x     |           |         |         |         |
| Kunde slettet     | x            |             |          | x     |           |         |         |         |
| Projekt oprettet  | x            |             | x        |       |           |         |         |         |
| Projekt afsluttet | x            |             | x        |       |           |         |         |         |
| Produkt oprettet  | x            |             |          |       |           | ?       |         | x       |
| Produkt solgt     |              | ?           |          | x     |           | x       |         | x       |
| Kunde faktureret  | x            |             |          | x     | x         | x       |         | x       |

class Organization:
    navn
    cvr
    medarbejder_list

class Medarbejder:
    navn
    cpr
    medarbejdernr
    alder
    Ansat_dato
    uddannelse
    stilling
    