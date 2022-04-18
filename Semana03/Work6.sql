

create function dbo.fn_cambio(@tipo int, @importe numeric(10,2))
returns numeric(10,2)
as
begin
	declare @cambio numeric(10,2);
	set @cambio = @importe * iif(@tipo=1,1/3.7,3.7);
	return @cambio;
end;
go

select dbo.fn_cambio(2, 1000);
go


