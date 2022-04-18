
drop function dbo.fn_empleados;
go

CREATE FUNCTION dbo.fn_empleados ( @p_dpto int ) 
RETURNS TABLE 
AS 
RETURN 
	SELECT idempleado, apellido, nombre 
	FROM dbo.empleado 
	WHERE iddepartamento = @p_dpto; 
GO

select * from dbo.fn_empleados( 102 );
go

