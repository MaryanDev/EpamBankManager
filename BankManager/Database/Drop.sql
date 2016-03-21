USE BANK;
GO
--ALTER TABLE tblCredits
--DROP CONSTRAINT fkCreditsDebitorId_DebitorId

--ALTER TABLE tblCredits
--DROP CONSTRAINT fkCreditsTypeId_TypesOfCreditId

--ALTER TABLE tblPayments 
--DROP CONSTRAINT fkPaymentsCreditId_CreditId

--ALTER TABLE tblCredits
--DROP CONSTRAINT ckCheckAmount

--ALTER TABLE tblPayments
--DROP CONSTRAINT ckCheckPaymentAmount

--ALTER TABLE tblTypeOfCredit
--DROP CONSTRAINT ckMaxTerm

DROP PROCEDURE spAddNewDebitor;
DROP PROCEDURE spOpenNewCredit;
DROP PROCEDURE spGetDebitors;
DROP PROCEDURE spGetCredits;
DROP PROCEDURE spPassNewPayment;
DROP PROCEDURE spGetPayments;
DROP PROCEDURE spGetUser;
DROP PROCEDURE spGetTypesOfCredit;
GO

DROP TABLE tblPayments;
DROP TABLE tblCredits;
DROP TABLE tblDebitors;
DROP TABLE tblTypeOfCredit;
DROP TABLE tblUser;
GO

