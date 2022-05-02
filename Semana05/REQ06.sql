/*
Problema 6
Se necesita saber la cantidad de pedidos que se han realizado por país, 
que incluya la cantidad de artículos, el importe respectivo 
y el porcentaje que representa del total de pedidos.

Base de datos: Northwind

El modelo del resultado es el siguiente: 
- PAIS 
- CANTIDAD PEDIDOS 
- CANTIDAD PRODUCTOS 
- IMPORTE 
- PORCENTAJE DEL TOTAL

*/

WITH 
V1 AS (
	SELECT 
		O.ShipCountry, COUNT(DISTINCT O.OrderID) PEDIDOS,
		SUM(D.Quantity) CANTPRODUCTOS, SUM(D.Quantity*D.UnitPrice) IMPORTE
	FROM Northwind..Orders O
	JOIN Northwind..[Order Details] D ON O.OrderID=D.OrderID
	GROUP BY O.ShipCountry
),
V2 AS ( SELECT SUM(IMPORTE) TOTAL FROM V1 )
SELECT 
	V1.ShipCountry, V1.PEDIDOS, V1.CANTPRODUCTOS, V1.IMPORTE,
	CAST(ROUND(V1.IMPORTE*100.0/V2.TOTAL,2) AS NUMERIC(8,2)) PORCENTAJE
FROM V1 CROSS JOIN V2
ORDER BY 1;
GO


