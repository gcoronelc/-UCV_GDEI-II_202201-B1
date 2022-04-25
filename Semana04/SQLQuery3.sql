use educa;
go

CREATE TRIGGER tr_seguridad 
ON DATABASE 
FOR DROP_TABLE, ALTER_TABLE 
AS 
BEGIN 
	RAISERROR('No se permite eliminar ni modificar tablas.',16,1); 
	ROLLBACK; 
END; 
GO

drop table pago;
go


