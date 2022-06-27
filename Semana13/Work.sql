
-- >,<,>=,<=,!=, = o IN.

select * from rh..empleado
where sueldo <> (select avg(sueldo) from rh..empleado);
go


select * from rh..empleado
where sueldo in (select min(sueldo) from rh..empleado);
go

-- Any o some, ALL, IN, NOT IN

select * from rh..empleado
where idempleado < all (select idempleado from rh..empleado
	where comision is not null and ISNULL(comision,0) > 0);
go



