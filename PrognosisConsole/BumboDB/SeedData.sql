INSERT INTO dbo.Locaties (Postcode, Huisnummer, Plaats)
VALUES ('1234AB', '10A', 'Den Bosch');

INSERT INTO dbo.Filialen (FiliaalID, LocatieID, Naam, MeterSchappen)
VALUES (1, 1, 'Hogezande', 130);

INSERT INTO dbo.Eenheden (EenheidType)
VALUES
    ('Coli'),
    ('Klanten'),
    ('Meter')
;

INSERT INTO dbo.Afdelingen (Naam)
VALUES
    ('Kassa'),
    ('Vakkenvullers')
;

INSERT INTO dbo.Activiteiten (Beschrijving, AfdelingNaam)
VALUES
    ('Coli doen', 'Vakkenvullers'),
    ('klanten doen', 'Kassa'),
    ('meter doen', 'Vakkenvullers')
;

INSERT INTO dbo.Normeringen (EenheidType, ActiviteitBeschrijving, FiliaalId, AantalPerUur)
VALUES 
    ('Coli', 'Coli doen', 1, 2),
    ('Klanten', 'klanten doen', 1, 30),
    ('Meter', 'meter doen', 1, 120)
;
