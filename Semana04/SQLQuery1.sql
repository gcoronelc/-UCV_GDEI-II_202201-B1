use educa;
go

CREATE TRIGGER tr_demo
ON curso 
FOR INSERT, UPDATE
AS
PRINT 'MENSAJE DESDE EL TRIGGER';
PRINT 'Esto es un trigger.';
GO


select * from curso;
go

update curso 
set cur_profesor='Gustavo Coronel'
where cur_id=4;
go







