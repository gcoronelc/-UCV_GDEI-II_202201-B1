
select count(*) from rh..empleado;
go

select count(1) from rh..empleado;
go

select count(idempleado) from rh..empleado;
go

select count(comision) from rh..empleado;
go

select count(1) from rh..empleado
where comision is not null and comision > 0;
go


select isnull(60, 100);
go

select isnull(null, 100);
go


declare @valor int;
set @valor = isnull(60, 100);
print @valor;
go

begin
	declare @valor int;
	set @valor = isnull(60, 100);
	print @valor;
end;
go


BEGIN 
	DECLARE @NUM1 INT, @NUM2 INT, @SUMA INT; 
	SET @NUM1 = CAST( RAND() * 100 AS INT ); 
	SET @NUM2 = CAST( RAND() * 100 AS INT ); 
	SET @SUMA = @NUM1 + @NUM2; 
	PRINT CONCAT( 'NUM1 = ', @NUM1 ); 
	PRINT CONCAT( 'NUM2 = ', @NUM2 ); 
	PRINT CONCAT( 'SUMA = ', @SUMA ); 
END; 
GO









