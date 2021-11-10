--create table tempkalpies
--(
--[Id] INT NOT NULL PRIMARY KEY,
--name nvarchar(50)
--);
--INSERT INTO tempkalpies (Id, name)
--VALUES (2,'ruti');

--select * from tempkalpies


CREATE PROCEDURE spGetKalpiInfo 
@PersonID AS int,
@issueDate as date
AS 
SELECT BallotID
FROM tblVoters WHERE PersonID=@PersonID and issueDate=@issueDate

INSERT INTO tblVoters
    (PersonID,issueDate,ballotID)
VALUES
    (1 , '2012-01-01',1 )
INSERT INTO tblVoters
    (PersonID,issueDate,ballotID)
VALUES
    (2 , '2012-01-02',2 )

INSERT INTO tblBallots
    (ballotID)
VALUES
    (2)
