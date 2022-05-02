/*
Desarrollar una consulta para encontrar la planilla de profesores de un determinado ciclo.
Base de datos: EDUTEC
El modelo del resultado es el siguiente: 

- NOMBRE DEL PROFESOR  
- AULAS PROGRAMADAS 
- HORAS DICTADAS 
- IMPORTE

*/


-- EDUARDO RAUL JESUS BALDOVINO MONTES para todos 02:51 PM

use EduTec
GO

SELECT 
	p.ApeProfesor as 'PROFESOR',
	COUNT(cp.IdCursoProg) as 'AULAS PROGRAMADAS',
	SUM(t.Horas) AS 'HORAS DICTADAS',
	SUM (t.Horas * t.PagoHora) as 'IMPORTE' 
FROM Profesor p 
INNER JOIN CursoProgramado CP on cp.IdProfesor=p.IdProfesor
INNER JOIN Curso c on c.IdCurso=cp.IdCurso
INNER JOIN Tarifa t on t.IdTarifa=c.IdTarifa
WHERE CP.IdCiclo='2021-01'
GROUP BY p.ApeProfesor;
GO


-- GUILLERMO ALBERTO ROJAS VALLEJOS para todos 02:54 PM

SELECT P.IdProfesor,P.NomProfesor,P.ApeProfesor,CU.IdCurso,T.Horas,T.Horas*T.PagoHora PLANILLA  
FROM EDUTEC..Profesor P
JOIN EDUTEC..CursoProgramado CU ON P.IdProfesor=CU.IdProfesor
JOIN EDUTEC..CURSO U ON CU.IDCURSO=U.IdCurso
JOIN EDUTEC..TARIFA T ON U.IdTarifa=T.IdTarifa
WHERE CU.IdCiclo='2021-01'
ORDER BY P.ApeProfesor ASC 
GO

-- OTRA SOLUCION

SELECT 
	p.ApeProfesor as 'PROFESOR',
	COUNT(cp.IdCursoProg) as 'AULAS',
	SUM(t.Horas) AS 'HORAS',
	SUM (t.Horas * t.PagoHora) as 'IMPORTE' 
FROM Profesor p 
INNER JOIN CursoProgramado CP on cp.IdProfesor=p.IdProfesor
INNER JOIN Curso c on c.IdCurso=cp.IdCurso
INNER JOIN Tarifa t on t.IdTarifa=c.IdTarifa
WHERE CP.IdCiclo='2021-01'
GROUP BY p.ApeProfesor;
GO

