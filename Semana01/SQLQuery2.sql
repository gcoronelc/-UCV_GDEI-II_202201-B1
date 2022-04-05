-- CTE: Common Table Expression

-- No contestaron
-- ==========================================
-- Juan Carlos Patricio
-- Jean Ayala Aldave
-- Leonardo Palacios
-- Luis Quispe
-- 


/*
Requerimiento 1
-------------------------------------------------------------------------
Se necesita saber el producto mas caro de cada categor�a.
*/


/*
1. Analizar cada requerimiento.
-------------------------------------------------------------------------
Se entiende que de cada categor�a se tienen varios productos, lo que
se quiere saber es el precio mas caro de cada categor�a y a que producto
o productos pertenece ese precio.

2. Identificar los datos que debe tener el reporte.
-------------------------------------------------------------------------
Los datos del reporte:
- Codigo de la categor�a
- Nombre de la categor�a
- C�dgio del producto
- Nombre del producto
- Precio del producto

3. Identificar las tablas de donde obtendr� los datos.
-------------------------------------------------------------------------
- Categories: Codigo de la categor�a
- Categories: Nombre de la categor�a
- Products: C�dgio del producto
- Products: Nombre del producto
- Products: Precio del producto


4. Elaborar la consulta.
-------------------------------------------------------------------------
*/


-- 4.1 Averiguar el precio mas caro por categoria

select CategoryID,  max(UnitPrice) PrecioCaro
from Northwind..Products
group by CategoryID;
go

-- 4.2 Averiguar los productos que corresponden a los caros.

with 
v1 as (
	select CategoryID,  max(UnitPrice) PrecioCaro
	from Northwind..Products
	group by CategoryID
)
select P.CategoryID, P.ProductID, P.ProductName, P.UnitPrice
from Northwind..Products P
join v1 on P.CategoryID = v1.CategoryID and P.UnitPrice = v1.PrecioCaro
order by P.CategoryID;
go

-- 4.3 Completar con el nombre de la categor�a

with 
v1 as (
	select CategoryID,  max(UnitPrice) PrecioCaro
	from Northwind..Products
	group by CategoryID
),
v2 as (
	select P.CategoryID, P.ProductID, P.ProductName, P.UnitPrice
	from Northwind..Products P
	join v1 on P.CategoryID = v1.CategoryID and P.UnitPrice = v1.PrecioCaro
)
select 
	C.CategoryID, C.CategoryName,
	v2.ProductID, v2.ProductName, v2.UnitPrice
from Northwind..Categories C
join v2 on C.CategoryID = v2.CategoryID
order by 1;
go



-- 5. Verificar su resultado

-- 1	Beverages	38	C�te de Blaye	263.50


select * 
from Northwind..Products
where CategoryID = 1
order by UnitPrice desc;







