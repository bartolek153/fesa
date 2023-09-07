+ Botao Backup: Sqlite VACCUM, savepoint
~ Constraint DEFAULT e CHECK || Domains
SQLITE TUTORIAL

-- CREATE TRIGGER trg 
-- AFTER INSERT ON tbl
-- BEGIN 
-- END

-- PRAGMAS SQLITE https://phiresky.github.io/blog/2020/sqlite-performance-tuning/
PRAGMA foreign_keys = ON;
PRAGMA journal_mode = wal;



CREATE TABLE Statuss -- Read-only
(
    description TEXT NOT NULL
);
INSERT INTO Statuss (desc) 
VALUES ('Open'), ('Pending'), ('Paused'), ('Finalized');


CREATE TABLE Category -- Public|Private
(
    description TEXT NOT NULL
);
INSERT INTO Category (description)
VALUES ()


CREATE TABLE Frequency -- Private
(
    codeID CHAR(1) NOT NULL,
    description TEXT NOT NULL,

    PRIMARY KEY (codeID) -- D M Y 'O'nce
);
INSERT INTO Frequency (codeID, description)
VALUES ('D', 'Diary'), ('M', 'Monthly'), ('Y', 'Yearly'), ('U', 'Unique');


CREATE TABLE TargetObject -- Public
(
    description TEXT NOT NULL
);





CREATE TABLE Spends -- Public
(
    value REAL NOT NULL,
    fk_categoryID INTEGER NOT NULL,
    fk_statusID INTEGER NOT NULL,
    fk_frequencyID INTEGER NOT NULL,
    spend_date_start TEXT NOT NULL,
    spend_date_end TEXT,

    FOREGIN KEY (fk_categoryID)     REFERENCES Category(rowid),
    FOREGIN KEY (fk_statusID)       REFERENCES Statuss(rowid),
    FOREGIN KEY (fk_frequencyID)    REFERENCES Frequency(codeID);
);
INSERT INTO Spends

CREATE TABLE Totals
(
    monthly REAL NOT NULL,
    yearly REAL NOT NULL
);


CREATE TRIGGER spend_trg 
AFTER INSERT 
ON Spends
BEGIN 
    UPDATE Totals SET yearly = (yearly + NEW.value), monthly = (monthly + NEW.value);

    INSERT INTO OutstandingSpends(fk_spendEndDate)
    VALUES((
        CASE WHEN NEW.spend_date_end IS NOT NULL 
        OR NEW.spend_date_start > DATETIME() THEN 
        NEW.spend_date_end 
        END
    ));
END;


CREATE TABLE OutstandingSpends -- Private
(
    fk_spendID INTEGER NOT NULL,
    fk_spendStartDate TEXT NOT NULL,
    fk_spendEndDate TEXT NOT NULL,
    parcel REAL NOT NULL,

    FOREGIN KEY (fk_spendID)        REFERENCES Spends(rowid),
    FOREGIN KEY (fk_spendStartDate) REFERENCES Spends(spend_date_start),
    FOREGIN KEY (fk_spendEndDate)   REFERENCES Spends(spend_date_end)
);

CREATE TABLE Control -- Public
(
    fk_object INTEGER NOT NULL,
    fk_status INTEGER NOT NULL,
    value REAL NOT NULL,
    expression TEXT,

    FOREIGN KEY (fk_object) REFERENCES TargetObject(rowid)
    FOREIGN KEY (fk_status) REFERENCES Status(rowid)
);