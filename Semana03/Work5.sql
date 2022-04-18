drop FUNCTION dbo.fn_ventas
go


CREATE FUNCTION dbo.fn_ventas ( ) 
RETURNS @tabla TABLE ( 
	CategoryID int primary key not null, 
	CategoryName varchar(50) not null, 
	quantity int default 0,
	importe numeric(12,2) default 0
) AS 
BEGIN 

	INSERT INTO @tabla(CategoryID,CategoryName) 
	select CategoryID, CategoryName from Categories;

	update @tabla
	set 
		quantity = (select sum(od.Quantity) 
					from [Order Details] od
					join Products p on od.ProductID = p.ProductID
					where p.CategoryId=t.CategoryID),
		importe = (select sum(od.Quantity*od.UnitPrice*(1-od.Discount)) 
					from [Order Details] od
					join Products p on od.ProductID = p.ProductID
					where p.CategoryId=t.CategoryID)
	from @tabla t;

	RETURN; 
END; 
GO

select * from dbo.fn_ventas();
go

select sum(Quantity), sum(Quantity*UnitPrice*(1-Discount))
from [Order Details];
go

select * from [Order Details];
go

