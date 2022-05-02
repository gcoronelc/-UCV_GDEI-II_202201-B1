/*
Se necesita saber la cantidad de pedidos que ha 
atendido cada empleado, que incluya la cantidad 
de artículos, el importe respectivo y el porcentaje 
que representa del total de pedidos.

El modelo del resultado es el siguiente: 
- CODIGO EMPLEADO 
- NOMBRE EMPLEADO 
- CANTIDAD PEDIDOS 
- CANTIDAD PRODUCTOS 
- IMPORTE 
- PORCENTAJE DEL TOTAL
*/


WITH 
V1 AS (
	SELECT 
		O.EmployeeID, COUNT(DISTINCT O.OrderID) PEDIDOS,
		SUM(D.Quantity) PRODUCTOS,
		SUM(D.Quantity*D.UnitPrice) IMPORTE
	FROM Northwind..Orders O
	JOIN Northwind..[Order Details] D ON O.OrderID=D.OrderID
	GROUP BY O.EmployeeID
),
V2 AS (SELECT SUM(IMPORTE) TOTAL FROM V1)
SELECT 
	E.EmployeeID CODIGO,
	CONCAT(E.FirstName,', ', E.LastName) NOMBRE,
	V1.PEDIDOS, V1.PRODUCTOS, V1.IMPORTE,
	CAST(V1.IMPORTE*100.0/V2.TOTAL AS NUMERIC(10,2)) PORCENTAJE
FROM Northwind..Employees E
JOIN V1 ON E.EmployeeID = V1.EmployeeID
CROSS JOIN V2;
GO


