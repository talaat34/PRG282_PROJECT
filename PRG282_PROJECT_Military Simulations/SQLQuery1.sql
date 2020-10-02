use PROJECT_PRG282
GO
create table users(
PersonID int primary key not null IDENTITY(1,1),
name varchar(255),
surname varchar(255)
);

select * from users