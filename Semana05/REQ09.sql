/*
Problema 9

Cada empleado recibe 3% de comisión de cada venta. S
e necesita una consulta que permita obtener la comisión que se 
le debe pagar a cada empleado por todas sus ventas.

Base de datos: Northwind

El modelo del resultado es el siguiente: 
- NOMBRE EMPLEADO 
- CANTIDAD DE VENTAS 
- IMPORTE DE VENTAS 
- IMPORTE COMISION
*/

WITH 
V1 AS (
	SELECT 
		O.EmployeeID, COUNT(DISTINCT O.OrderID) VENTAS,
		SUM(D.Quantity*D.UnitPrice) IMPORTE
	FROM Northwind..Orders O
	JOIN Northwind..[Order Details] D ON O.OrderID=D.OrderID
	GROUP BY O.EmployeeID
)
SELECT 
	E.FirstName, E.LastName,
	V1.VENTAS, V1.IMPORTE, 
	CAST(V1.IMPORTE*0.03 AS NUMERIC(12,2)) COMISION
FROM Northwind..Employees E
JOIN V1 ON E.EmployeeID=V1.EmployeeID;
GO



