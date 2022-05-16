
insert into clientes2
select * from customers
go

select * into clientes2
from Customers
go

select * from clientes2
where ContactName='Philip Cramer'
go

CREATE INDEX clientes_idx_2
ON clientes2(contactname)
go

select * from clientes2
go

drop index clientes_idx_2 on  clientes2
go

select * from clientes2
go

CREATE INDEX clientes_idx_4
ON clientes2(city)
go

select * from clientes2
where city='Madrid'
go