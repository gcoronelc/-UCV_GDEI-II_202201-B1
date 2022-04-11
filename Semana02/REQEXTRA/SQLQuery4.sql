
select CategoryID, sum(UnitsInStock) stock
from Northwind..Products
group by CategoryID;
go

with
v1 as (
	select CategoryID, sum(UnitsInStock) stock
	from Northwind..Products
	group by CategoryID
)
select sum(stock) stock_total from v1;
go


with
v1 as (
	select CategoryID, sum(UnitsInStock) stock
	from Northwind..Products
	group by CategoryID
),
v2 as (
	select sum(stock) stock_total from v1
)
select v1.CategoryID, v1.stock, (v1.stock * 100.0 / v2.stock_total) porcentaje
from v1 cross join v2
go


