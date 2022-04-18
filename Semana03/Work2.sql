
CREATE FUNCTION dbo.fn_suma ( @num1 int, @num2 int ) 
RETURNS int 
AS 
BEGIN 
	DECLARE @suma int; 
	SET @suma = @num1 + @num2; 
	RETURN @suma; 
END; 
GO

SELECT dbo.fn_suma( 24, 56 ) as suma;
go

begin
	declare @suma int;
	set @suma = dbo.fn_suma(1,2);
	print concat('Suma: ',@suma);
end;
go



