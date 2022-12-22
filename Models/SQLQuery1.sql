use CDExcellent

go 

CREATE TABLE Account (
    idUser int IDENTITY(1,1) PRIMARY KEY ,
    FirstName  varchar(50),
    LastName  varchar(50),
    Email  varchar(50),
    Password  varchar(50)
);