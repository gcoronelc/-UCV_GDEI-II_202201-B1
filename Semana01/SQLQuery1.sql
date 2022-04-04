-- Convinación de tablas

select * from Northwind..Categories;
select * from Northwind..Products;
go



select * 
from Northwind..Categories C
join Northwind..Products P on C.CategoryID = P.CategoryID;
go



select 
	C.CategoryID, C.CategoryName, 
	count(P.ProductID) Productos,
	sum(P.UnitsInStock) Stock
from Northwind..Categories C
join Northwind..Products P on C.CategoryID = P.CategoryID
group by C.CategoryID, C.CategoryName;
go




