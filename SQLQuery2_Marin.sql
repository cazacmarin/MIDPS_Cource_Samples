--create database agenda;
use agenda;
drop table Agenda_Address;
drop table Address;
drop table eMail;
drop table Agenda;
create table Agenda(
 id_agenda int primary key not null,
 name1 varchar(50),
 surname varchar(50),
 phoneNumber varchar(50)
);
create table eMail(
 id_email int primary key not null, 
 eMailAddress varchar(50),
 type1 smallint,
 id_eMail_Agenda int,
 constraint Fk_eMail_Agenda foreign key (id_eMail_Agenda)
references Agenda (id_agenda)
);
insert into Agenda values (1,'Dorin','Recean','902');
insert into Agenda values (2,'Vovacica','Pecikin','901');

insert into eMail values (3,'Dorin.Recean@mai.md',0,1);
insert into eMail values (4,'Dorin.Recean@gmail.md',1,1);

insert into eMail values (5,'Vovacica.Pecikin@sis.md',0,2);
insert into eMail values (6,'Vovacica.Pecikin@gmail.md',1,2);

select * from Agenda;
select * from eMail;

--insert into Agenda (id_agenda,name1) values (7,'Kesha test');

--select * from Agenda where name1 like 'vov%';

create table Address(
 id_address int primary key not null,
 city varchar(50),
 street varchar(100),
 type2 smallint
);

insert into Address values (7, 'Chisinau', 'Studentilor 7/1', 1);
insert into Address values (8, 'Chisinau', 'Stefan cel Mare 124', 0);
insert into Address values (9, 'Ratus', 'Florilor', 1);
select * from Address ;

create table Agenda_Address(
 id_agenda_fk int,
 id_address_fk int,
 constraint Fk_AgendaAddress_Agenda foreign key (id_agenda_fk)
references Agenda (id_agenda),
 constraint Fk_AgendaAddress_Address foreign key (id_address_fk)
references Address (id_address)
);

insert into Agenda_Address values (1, 9);
insert into Agenda_Address values (1, 8);
insert into Agenda_Address values (2, 7);
insert into Agenda_Address values (2, 8);
select * from Agenda_Address;

--select * from Agenda where id_agenda = (select id_agenda_fk from )
SELECT *
FROM Agenda AS A
WHERE EXISTS
( SELECT *
    FROM Agenda_Address AS AA
    WHERE AA.id_agenda_fk = A.id_agenda
	--and AA.id_agenda_fk = 2
)  

SELECT *
FROM Address AS Ad
WHERE EXISTS
( SELECT *
    FROM Agenda_Address AS AA
    WHERE AA.id_address_fk = Ad.id_address
	and AA.id_address_fk = 8
)

SELECT *
FROM Agenda AS A 
WHERE EXISTS
( SELECT *
    FROM Agenda_Address AS AA
    WHERE AA.id_agenda_fk = A.id_agenda
	and AA.id_agenda_fk = 1
)

select * from agenda.dbo.Agenda
select max (id_agenda) from agenda.dbo.Agenda
select * from agenda.dbo.EMail
select max (id_email) from agenda.dbo.EMail
select * from agenda.dbo.Address
select max(id_address) from agenda.dbo.Address
insert into agenda.dbo.EMail (id_email,eMailAddress,type1) values (7, 'kesa@e-mail.md', 0 )
select * from agenda.dbo.EMail